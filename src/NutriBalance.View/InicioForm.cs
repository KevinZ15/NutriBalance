using NutriBalance.Controller;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.View;

/// <summary>
/// Main startup form that provides access to registration and login features.
/// </summary>
public partial class InicioForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly MenuDiarioController _menuDiarioController;
    private readonly string _rutaAlimentosGlobal;
    private readonly string _rutaData;

    /// <summary>
    /// Initializes a new instance of the startup form with the required dependencies.
    /// </summary>
    /// <param name="usuarioController">Controller used to manage user operations.</param>
    /// <param name="menuDiarioController">Controller used to manage daily menu operations.</param>
    /// <param name="rutaAlimentosGlobal">Path to the global food catalog file.</param>
    /// <param name="rutaData">Path to the application's data directory.</param>
    public InicioForm(
        UsuarioController usuarioController,
        MenuDiarioController menuDiarioController,
        string rutaAlimentosGlobal,
        string rutaData)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _menuDiarioController = menuDiarioController;
        _rutaAlimentosGlobal = rutaAlimentosGlobal;
        _rutaData = rutaData;
    }

    private void BtnRegistrarse_Click(object sender, EventArgs e)
    {
        using RegistroUsuarioPaso1Form form = new(_usuarioController);
        Hide();
        form.ShowDialog();
        Show();
    }

    private void BtnIniciarSesion_Click(object sender, EventArgs e)
    {
        using LoginForm form = new(_usuarioController);
        Hide();
        form.ShowDialog();

        if (_usuarioController.UsuarioAutenticado is not null)
        {
            string rutaAlimentosUsuario = Path.Combine(
                _rutaData,
                $"alimentos_{_usuarioController.UsuarioAutenticado.Id}.json"
            );

            AlimentoJsonRepository.InicializarCatalogoUsuario(_rutaAlimentosGlobal, rutaAlimentosUsuario);

            IAlimentoRepository alimentoRepositoryUsuario = new AlimentoJsonRepository(rutaAlimentosUsuario);
            AlimentoController alimentoControllerUsuario = new(alimentoRepositoryUsuario);

            using MainForm mainForm = new(
                _usuarioController,
                alimentoControllerUsuario,
                _menuDiarioController
            );
            mainForm.ShowDialog();
        }

        Show();
    }
}