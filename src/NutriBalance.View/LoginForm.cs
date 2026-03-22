using NutriBalance.Controller;

namespace NutriBalance.View;

public partial class LoginForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly AlimentoController _alimentoController;

    public LoginForm(UsuarioController usuarioController, AlimentoController alimentoController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _alimentoController = alimentoController;
    }

    private void btnVolver_Click(object sender, EventArgs e)
    {
        Close();
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

        DialogResult = DialogResult.OK;
        Close();
    }
}