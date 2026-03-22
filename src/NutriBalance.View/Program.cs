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

        IUsuarioRepository usuarioRepository = new UsuarioJsonRepository(rutaUsuarios);
        IAlimentoRepository alimentoRepository = new AlimentoJsonRepository(rutaAlimentos);

        UsuarioController usuarioController = new(usuarioRepository);
        AlimentoController alimentoController = new(alimentoRepository);

        Application.Run(new InicioForm(usuarioController, alimentoController));
    }
}