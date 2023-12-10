using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WebListaEsperaMentoria.Infra;
using WebListaEsperaMentoria.Interfaces;
using WebListaEsperaMentoria.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IPacienteServices, PacienteServices>();
//builder.Services.AddScoped<ISessao, Sessao>();
builder.Services.AddScoped<IUsuarioServices, UsuarioServices>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(o =>
{
    o.Cookie.HttpOnly = true;
    o.Cookie.IsEssential = true;
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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
