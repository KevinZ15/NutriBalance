using NutriBalance.Controller;

namespace NutriBalance.View;

/// <summary>
/// Form used to collect the first step of user registration data.
/// </summary>
public partial class RegistroUsuarioPaso1Form : Form
{
    private readonly UsuarioController _usuarioController;

    /// <summary>
    /// Initializes a new instance of the form with the required user controller.
    /// </summary>
    /// <param name="usuarioController">Controller used to manage user data.</param>
    public RegistroUsuarioPaso1Form(UsuarioController usuarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
    }

    private void BtnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void BtnContinuar_Click(object sender, EventArgs e)
    {
        string nombreUsuario = txtNombreUsuario.Text.Trim();
        string nombre = txtNombre.Text.Trim();
        string contrasena = txtContrasena.Text;

        if (string.IsNullOrWhiteSpace(nombreUsuario))
        {
            MessageBox.Show("El nombre de usuario es obligatorio.");
            return;
        }

        if (string.IsNullOrWhiteSpace(nombre))
        {
            MessageBox.Show("El nombre es obligatorio.");
            return;
        }

        if (string.IsNullOrWhiteSpace(contrasena))
        {
            MessageBox.Show("La contraseña es obligatoria.");
            return;
        }

        using RegistroUsuarioPaso2Form form = new(
            _usuarioController,
            nombreUsuario,
            nombre,
            contrasena
        );

        Hide();
        form.ShowDialog();
        Show();

        if (form.DialogResult == DialogResult.OK)
        {
            Close();
        }
    }
}