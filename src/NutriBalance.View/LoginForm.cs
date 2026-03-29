using NutriBalance.Controller;

namespace NutriBalance.View;

/// <summary>
/// Form used to authenticate a user into the system.
/// </summary>
public partial class LoginForm : Form
{
    private readonly UsuarioController _usuarioController;

    /// <summary>
    /// Initializes a new instance of the login form with the required user controller.
    /// </summary>
    /// <param name="usuarioController">Controller used to manage user authentication.</param>
    public LoginForm(UsuarioController usuarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
    }

    private void BtnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void BtnIngresar_Click(object sender, EventArgs e)
    {
        var (Exito, Mensaje) = _usuarioController.IniciarSesion(
            txtUsuario.Text.Trim(),
            txtContrasena.Text
        );

        if (!Exito)
        {
            MessageBox.Show(Mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DialogResult = DialogResult.OK;
        Close();
    }
}