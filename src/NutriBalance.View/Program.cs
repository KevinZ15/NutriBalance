using NutriBalance.Controller;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services.SQLite;

namespace NutriBalance.View;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        string projectRoot = Path.GetFullPath(Path.Combine(baseDir, @"..\..\..\..\..\"));
        string rutaData = Path.Combine(projectRoot, "data");

        Directory.CreateDirectory(rutaData);

        string rutaBaseDatos = Path.Combine(rutaData, "nutribalance.db");

        SqliteDatabaseInitializer.Inicializar(rutaBaseDatos);

        IUsuarioRepository usuarioRepository = new UsuarioSqliteRepository(rutaBaseDatos);
        IAlimentoRepository alimentoRepository = new AlimentoSqliteRepository(rutaBaseDatos);
        IMenuDiarioRepository menuDiarioRepository = new MenuDiarioSqliteRepository(rutaBaseDatos);

        UsuarioController usuarioController = new(usuarioRepository);
        AlimentoController alimentoController = new(alimentoRepository);
        MenuDiarioController menuDiarioController = new(menuDiarioRepository);

        Application.Run(
            new InicioForm(
                usuarioController,
                alimentoController,
                menuDiarioController
            )
        );
    }
}