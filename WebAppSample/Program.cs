using WebAppSample.Helper.Middleware;
using WebAppSample.Helper.Middleware.TaskMiddleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseMiddleware<BasicAuthHandler>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
