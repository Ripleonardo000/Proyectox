using Microsoft.EntityFrameworkCore;
using Proyectox.Data;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProyectoxContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProyectoxContext") ?? throw new InvalidOperationException("Connection string 'ProyectoxContext' not found.")));



/*
// Agrega el contexto de base de datos
builder.Services.AddDbContext<LeonardoAndradeProject_RContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LeonardoAndradeProject_RContext")));
*/

// Agrega controladores con vistas
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuraci�n del pipeline de solicitudes HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
