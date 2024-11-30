var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Purpose",
    pattern: "purpose ",
    defaults: new { controller = "Purpose", action = "Index" });

app.MapControllerRoute(
    name: "HowWorks",
    pattern: "how-works",
    defaults: new { controller = "HowWorks", action = "Index" });

app.Run();
