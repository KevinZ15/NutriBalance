using NutriBalance.Controller;

namespace NutriBalance.View;

public partial class LoginForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly AlimentoController _alimentoController;
    private readonly MenuDiarioController _menuDiarioController;

    public LoginForm(
        UsuarioController usuarioController,
        AlimentoController alimentoController,
        MenuDiarioController menuDiarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _alimentoController = alimentoController;
        _menuDiarioController = menuDiarioController;
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