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

        string rutaUsuarios = Path.GetFullPath(
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "..", "..", "..", "..", "..",
                "data",
                "usuarios.json"
            )
        );

        string rutaAlimentos = Path.GetFullPath(
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "..", "..", "..", "..", "..",
                "data",
                "alimentos.json"
            )
        );

        string rutaMenus = Path.GetFullPath(
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "..", "..", "..", "..", "..",
                "data",
                "menus.json"
            )
        );

        IUsuarioRepository usuarioRepository = new UsuarioJsonRepository(rutaUsuarios);
        IAlimentoRepository alimentoRepository = new AlimentoJsonRepository(rutaAlimentos);
        IMenuDiarioRepository menuDiarioRepository = new MenuDiarioJsonRepository(rutaMenus);

        UsuarioController usuarioController = new(usuarioRepository);
        AlimentoController alimentoController = new(alimentoRepository);
        MenuDiarioController menuDiarioController = new(menuDiarioRepository);

        Application.Run(new InicioForm(usuarioController, alimentoController, menuDiarioController));
    }
}