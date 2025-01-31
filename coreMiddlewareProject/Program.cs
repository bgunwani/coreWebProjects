var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.Use(async (context, next) =>
{
    // Request Logic
    // Console.WriteLine($"Request Path: {context.Request.Path}");
    Console.WriteLine("Middleware A (Request) => ");
    // Call the next Middleware
    await next.Invoke();
    // Response Logic
    Console.WriteLine("Middleware A (Response)");
});

app.Use(async (context, next) =>
{
    // Request Logic
    // Console.WriteLine($"Request Path: {context.Request.Path}");
    Console.WriteLine("Middleware B (Request) => ");
    // Call the next Middleware
    await next.Invoke();
    // Response Logic
    Console.WriteLine("Middleware B (Response) => ");
});

app.Use(async (context,next) =>
{
    // Request Logic
    // Console.WriteLine($"Request Path: {context.Request.Path}");
    Console.WriteLine("Middleware C (Request) => ");
    // Call the next Middleware
    await next.Invoke();
    // Response Logic
    Console.WriteLine("Middleware C (Response) => ");
});


//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
