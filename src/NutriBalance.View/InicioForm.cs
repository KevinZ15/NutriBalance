using NutriBalance.Controller;

namespace NutriBalance.View;

public partial class InicioForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly AlimentoController _alimentoController;

    public InicioForm(UsuarioController usuarioController, AlimentoController alimentoController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _alimentoController = alimentoController;
    }

    private void btnRegistrarse_Click(object sender, EventArgs e)
    {
        using RegistroUsuarioPaso1Form form = new(_usuarioController, _alimentoController);
        Hide();
        form.ShowDialog();
        Show();
    }

    private void btnIniciarSesion_Click(object sender, EventArgs e)
    {
        using LoginForm form = new(_usuarioController, _alimentoController);
        Hide();
        form.ShowDialog();

        if (_usuarioController.UsuarioAutenticado is not null)
        {
            using MainForm mainForm = new(_usuarioController, _alimentoController);
            mainForm.ShowDialog();
        }

        Show();
    }
}