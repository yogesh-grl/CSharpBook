using WebAppSample;
using WebAppSample.Helper.Middleware;
using WebAppSample.Helper.Middleware.TaskMiddleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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


var app = builder.Build();

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

app.Run();
