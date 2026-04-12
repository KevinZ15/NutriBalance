using NutriBalance.Controller;

namespace NutriBalance.View;

public partial class InicioForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly AlimentoController _alimentoController;
    private readonly MenuDiarioController _menuDiarioController;

    public InicioForm(
        UsuarioController usuarioController,
        AlimentoController alimentoController,
        MenuDiarioController menuDiarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _alimentoController = alimentoController;
        _menuDiarioController = menuDiarioController;
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
            using MainForm mainForm = new(
                _usuarioController,
                _alimentoController,
                _menuDiarioController
            );
            mainForm.ShowDialog();
        }

        Show();
    }
}