using NutriBalance.Controller;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;
using NutriBalance.View;

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

        string rutaUsuarios = Path.Combine(rutaData, "usuarios.json");
        string rutaMenus = Path.Combine(rutaData, "menus.json");
        string rutaAlimentosGlobal = Path.Combine(rutaData, "alimentos.json");

        IUsuarioRepository usuarioRepository = new UsuarioJsonRepository(rutaUsuarios);
        IMenuDiarioRepository menuDiarioRepository = new MenuDiarioJsonRepository(rutaMenus);

        UsuarioController usuarioController = new(usuarioRepository);
        MenuDiarioController menuDiarioController = new(menuDiarioRepository);

        Application.Run(
            new InicioForm(
                usuarioController,
                menuDiarioController,
                rutaAlimentosGlobal,
                rutaData
            )
        );
    }
}