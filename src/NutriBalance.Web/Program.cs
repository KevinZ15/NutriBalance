using NutriBalance.Controller;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services.SQLite;
using NutriBalance.Web.Components;
using NutriBalance.Web.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

string baseDir = AppDomain.CurrentDomain.BaseDirectory;
string projectRoot = Path.GetFullPath(Path.Combine(baseDir, @"..\..\..\..\..\"));
string rutaData = Path.Combine(projectRoot, "data");
string rutaBaseDatos = Path.Combine(rutaData, "nutribalance.db");

Directory.CreateDirectory(rutaData);

SqliteDatabaseInitializer.Inicializar(rutaBaseDatos);

builder.Services.AddScoped<IUsuarioRepository>(_ => new UsuarioSqliteRepository(rutaBaseDatos));
builder.Services.AddScoped<IAlimentoRepository>(_ => new AlimentoSqliteRepository(rutaBaseDatos));
builder.Services.AddScoped<IMenuDiarioRepository>(_ => new MenuDiarioSqliteRepository(rutaBaseDatos));

builder.Services.AddScoped<UsuarioController>();
builder.Services.AddScoped<AlimentoController>();
builder.Services.AddScoped<MenuDiarioController>();
builder.Services.AddScoped(_ => new AdminEstadisticasController(rutaBaseDatos));

builder.Services.AddScoped<UserSessionService>();
builder.Services.AddScoped<RegistroUsuarioState>();
builder.Services.AddScoped<MenuDiarioDraftService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();