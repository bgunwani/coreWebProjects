using Microsoft.AspNetCore.Routing.Patterns;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// Middleware to server default static files
// app.UseDefaultFiles();
//var defaultFileOptions = new DefaultFilesOptions();
//defaultFileOptions.DefaultFileNames.Clear();
//defaultFileOptions.DefaultFileNames.Add("home.html");
//defaultFileOptions.DefaultFileNames.Add("dashboard.html");
//app.UseDefaultFiles(defaultFileOptions);

// Middleware for Routing to use endpoints for MVC
app.UseRouting();

// Middleware to servie files from wwwroot
app.UseStaticFiles();

// default endpoint
app.UseEndpoints(endpoints =>
{
    // Maps to the default Route: {controller=Home}/{action=Index}/{id?}
    // endpoints.MapDefaultControllerRoute();

    _ = endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Message}/{id?}");

});


app.Run();
