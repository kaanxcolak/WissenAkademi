using AutoMapper.Extensions.ExpressionMapping;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using PhoneBookBusinessLayer.EmailSenderBusiness;
using PhoneBookBusinessLayer.ImplementationsOfManagers;
using PhoneBookBusinessLayer.InterfacesOfManagers;
using PhoneBookDataLayer;
using PhoneBookDataLayer.ImplementationsOfRepo;
using PhoneBookDataLayer.InterfacesOfRepo;
using PhoneBookEntityLayer.Mappings;

var builder = WebApplication.CreateBuilder(args);

//context bilgisi eklenir
builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Local"));
});

//CookieAuthentication ayarı eklendi
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
builder.Services.AddAutoMapper(x=>
{
    x.AddExpressionMapping();
    x.AddProfile(typeof(Maps)); //Kimin kime dönüşeceğini Maps class'ı içinde tanımladık. Yaptığımız tanımlamayı ayarlara ekledik.
});


// Add services to the container.
builder.Services.AddControllersWithViews();

//interfacelerin işlerini gerçekleştirecek classları burada yaşam döngülerini tanımlamalıyız
builder.Services.AddScoped<IMemberRepository,MemberRepository>(); 
builder.Services.AddScoped<IMemberManager,MemberManager>(); 
builder.Services.AddScoped<IEmailSender,EmailSender>(); 


builder.Services.AddScoped<IPhoneTypeRepository,PhoneTypeRepository>(); 
builder.Services.AddScoped<IPhoneTypeManager,PhoneTypeManager>(); 

builder.Services.AddScoped<IMemberPhoneRepository, MemberPhoneRepository>(); 
builder.Services.AddScoped<IMemberPhoneManager, MemberPhoneManager>(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(); //wwwroot klasörünü görmesi için

app.UseRouting(); //browserdaki url için /home/indexe gidebilmesi için

app.UseAuthentication(); //Login ve logout işlemlerimiz için     ->>Sıralama önemli
app.UseAuthorization(); //Yetkilendirme için

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // route' default pattern vermek için

app.Run(); //uygulamayı çalıştırır
