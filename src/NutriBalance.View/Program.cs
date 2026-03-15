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

        string rutaArchivo = Path.GetFullPath(
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "..", "..", "..", "..", "..",
                "data",
                "usuarios.json"
            )
        );

        IUsuarioRepository usuarioRepository = new UsuarioJsonRepository(rutaArchivo);
        UsuarioController usuarioController = new(usuarioRepository);

        Application.Run(new LoginForm(usuarioController));
    }
}