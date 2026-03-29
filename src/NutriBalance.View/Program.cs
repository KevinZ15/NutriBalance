using NutriBalance.Controller;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.View;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        string rutaData = Path.GetFullPath(
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "..", "..", "..", "..", "..",
                "data"
            )
        );

        string rutaUsuarios = Path.Combine(rutaData, "usuarios.json");
        string rutaAlimentosGlobal = Path.Combine(rutaData, "alimentos.json");
        string rutaMenus = Path.Combine(rutaData, "menus.json");

        IUsuarioRepository usuarioRepository = new UsuarioJsonRepository(rutaUsuarios);
        IMenuDiarioRepository menuDiarioRepository = new MenuDiarioJsonRepository(rutaMenus);

        UsuarioController usuarioController = new(usuarioRepository);
        MenuDiarioController menuDiarioController = new(menuDiarioRepository);
        NutricionController nutricionController = new();

        Application.Run(new InicioForm(
            usuarioController,
            menuDiarioController,
            nutricionController,
            rutaAlimentosGlobal,
            rutaData
        ));
    }
}