using NutriBalance.Controller;

namespace NutriBalance.View;

public partial class LoginForm : Form
{
    private readonly UsuarioController _usuarioController;

    public LoginForm(UsuarioController usuarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        var resultado = _usuarioController.IniciarSesion(
            txtUsuario.Text.Trim(),
            txtContrasena.Text
        );

        if (!resultado.Exito)
        {
            MessageBox.Show(resultado.Mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Hide();

        MainForm mainForm = new(_usuarioController);
        mainForm.FormClosed += (s, args) => Close();
        mainForm.Show();
    }

    private void btnRegistrarse_Click(object sender, EventArgs e)
    {
        using RegistroUsuarioForm form = new(_usuarioController);
        form.ShowDialog();
    }
}