using NutriBalance.Controller;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services.SQLite;
using NutriBalance.Web.Components;
using NutriBalance.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Register Razor components with interactive server-side rendering
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Resolve the database path relative to the project root
string baseDir = AppDomain.CurrentDomain.BaseDirectory;
string projectRoot = Path.GetFullPath(Path.Combine(baseDir, @"..\..\..\..\..\"));
string rutaData = Path.Combine(projectRoot, "data");
string rutaBaseDatos = Path.Combine(rutaData, "nutribalance.db");

// Ensure the data directory exists before initializing the database
Directory.CreateDirectory(rutaData);

// Initialize the SQLite database schema and default data
SqliteDatabaseInitializer.Inicializar(rutaBaseDatos);

// Register SQLite repository implementations
builder.Services.AddScoped<IUsuarioRepository>(_ => new UsuarioSqliteRepository(rutaBaseDatos));
builder.Services.AddScoped<IAlimentoRepository>(_ => new AlimentoSqliteRepository(rutaBaseDatos));
builder.Services.AddScoped<IMenuDiarioRepository>(_ => new MenuDiarioSqliteRepository(rutaBaseDatos));

// Register application controllers
builder.Services.AddScoped<UsuarioController>();
builder.Services.AddScoped<AlimentoController>();
builder.Services.AddScoped<MenuDiarioController>();
builder.Services.AddScoped(_ => new AdminEstadisticasController(rutaBaseDatos));

// Register web services for session, registration state and menu drafts
builder.Services.AddScoped<UserSessionService>();
builder.Services.AddScoped<RegistroUsuarioState>();
builder.Services.AddScoped<MenuDiarioDraftService>();

var app = builder.Build();

// Configure error handling and HTTPS for non-development environments
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

// Map static assets and Razor components with interactive server rendering
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();