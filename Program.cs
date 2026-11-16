using Microsoft.EntityFrameworkCore;
using GamesKorn.Data;
using GamesKorn.Components;
using GamesKorn.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Registro único de servicios y estados
builder.Services.AddSingleton<BusquedaState>();
builder.Services.AddSingleton<ToastService>();
builder.Services.AddScoped<CarritoState>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionGamer")));

// 2. ÚNICA llamada a AddRazorComponents
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<GamesKorn.Components.Services.FiltroService>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// 3. Mapeo de componentes interactivos
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();