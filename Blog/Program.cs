using Blog.Data.Context;
using Blog.Data.Extensions;
using Blog.Entity.Entities;
using Blog.Service.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
//buray� eklemek yeterli oldu zaten context de ef core u �a��r�yor.

var builder = WebApplication.CreateBuilder(args);
var assembly = Assembly.GetExecutingAssembly().FullName;
builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceLayerExtension();
builder.Services.AddSession();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireUppercase = false;
})
    .AddRoleManager<RoleManager<AppRole>>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = new PathString("/Admin/Auth/Login");
    config.LogoutPath = new PathString("/Admin/Auth/Logout");
    config.Cookie = new CookieBuilder
    {
        Name = "Blog",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest//always -> canl�da 
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan= TimeSpan.FromDays(7);
    config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();
app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}"

        );
    endpoints.MapDefaultControllerRoute();
});

app.Run();
