var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();

app.MapControllerRoute(name: "landing", pattern: "", defaults: new { controller = "Home", action = "Landing" }).WithStaticAssets();
app.MapControllerRoute(name: "inicio", pattern: "inicio", defaults: new { controller = "Home", action = "Index" }).WithStaticAssets();
app.MapControllerRoute(name: "landing-alias", pattern: "landing", defaults: new { controller = "Home", action = "Landing" }).WithStaticAssets();
app.MapControllerRoute(name: "iniciar-sesion", pattern: "iniciar-sesion", defaults: new { controller = "Cuenta", action = "IniciarSesion" }).WithStaticAssets();
app.MapControllerRoute(name: "registrarse", pattern: "registrarse", defaults: new { controller = "Cuenta", action = "Registrarse" }).WithStaticAssets();
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}").WithStaticAssets();

app.Run();
