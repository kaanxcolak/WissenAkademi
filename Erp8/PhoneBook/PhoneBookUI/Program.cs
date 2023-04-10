var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(); //wwwroot klasörünü görmesi için

app.UseRouting(); // /home/indexe gidebilmesi iiçin

app.UseAuthorization(); //Yetkilendirme için

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // route' default pattern vermek için

app.Run(); //uygulamayı çalıştırır
