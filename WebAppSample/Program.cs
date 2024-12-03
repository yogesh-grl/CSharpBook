using WebAppSample;
using WebAppSample.Helper.Middleware;
using WebAppSample.Helper.Middleware.TaskMiddleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Versioning;
using WebAppSample.Helper;
using Microsoft.AspNetCore.Authorization;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<AppSetting>(builder.Configuration.GetSection("ApplicationSettings"));

//Authentication Service 
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["ApplicationSettings:Secret"])),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

//Authorization Service - Policy Based
builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("Admin", p => p.RequireClaim("Role", "Admin"));
});


#region 

//Policy-based Authorization Example:

//------------------------------------------------------------------------------------------------------------------------------------//
//Custom requirement and handler

//When a user calls the AdultOnly action method,ASP.NET Core's authorization system kicks in.
//It checks the policies specified in the [Authorize] attribute on the action method.
//In this case, the policy is "MinimumAgePolicy", which is already configured during application startup.
//The system then looks for the corresponding authorization handler for this policy.
//Since MinimumAgeHandler is already registered as a singleton service during startup,
//it will be used to handle the authorization requirement without being called again during the request to AdultOnly.

//Registering the Requirement in Service 
builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("MinimumAgePolicy", policy =>
    {
        policy.Requirements.Add(new MinimumAgeRequirement(18));
    });
});

//Registering the Handler in Service 
builder.Services.AddSingleton<IAuthorizationHandler, MinimumAgeHandler>();

//------------------------------------------------------------------------------------------------------------------------------------//


//Without Custome Requirement and Handler 
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MinimumAgePolicy", policy =>
    {
        policy.RequireClaim("Age", "18", "19", "20"); // Specify allowed ages
    });
});

//------------------------------------------------------------------------------------------------------------------------------------//

#endregion


builder.Services.AddApiVersioning(o =>
{
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    o.ReportApiVersions = true;
    o.ApiVersionReader = ApiVersionReader.Combine(
        new QueryStringApiVersionReader("api-version"),
        new HeaderApiVersionReader("X-Version"),
        new MediaTypeApiVersionReader("ver"));

});

builder.Services.AddVersionedApiExplorer(
    options =>
    {
        options.GroupNameFormat = "'v'VVV";
    });


var app = builder.Build();

app.UseWebSockets();
app.Map("/ws", ConfigureWebSocket);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

// Middleware example 
app.UseMiddleware<RequestLoggingMiddleware>();
app.UseMiddleware<SampleLoggingMiddelware>();

//Custom Exception middelware example
//app.UseMiddleware<CustomDeveloperExceptionLogger>();

//Auth Middleware
//app.UseMiddleware<BasicAuthHandler>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//Conventional Based Rounting 
//Version Control 
//app.MapControllerRoute(
//    name: "V2",
//    pattern: "{controller=Home}/v2/{action=Index}/{id?}/");                     

app.Run();

void ConfigureWebSocket(IApplicationBuilder app)
{
    app.Use(async (HttpContext context, RequestDelegate next) =>
    {
        if (context.WebSockets.IsWebSocketRequest)
        {
            await WebSocketHandler.HandleWebSocketRequest(context);
        }
        else
        {
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
        }
    });
}

