using NutriBalance.Controller;

namespace NutriBalance.View;

public partial class RegistroUsuarioPaso1Form : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly AlimentoController _alimentoController;

    public RegistroUsuarioPaso1Form(UsuarioController usuarioController, AlimentoController alimentoController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _alimentoController = alimentoController;
    }

    private void btnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnContinuar_Click(object sender, EventArgs e)
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
            _alimentoController,
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