using AutoMapper.Extensions.ExpressionMapping;
using Microsoft.EntityFrameworkCore;
using PhoneBookDataLayer;
using PhoneBookEntityLayer.Mappings;

var builder = WebApplication.CreateBuilder(args);

//context bilgisi eklenir
builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Local"));

});

builder.Services.AddAutoMapper(x=>
{
    //x.AddExpressionMapping();
    x.AddProfile(typeof(Maps)); //Kimin kime dönüşeceğini Maps class'ı içinde tanımladık. Yaptığımız tanımlamayı ayarlara ekledik.4



});


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
