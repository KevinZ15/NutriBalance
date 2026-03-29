using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.View;

/// <summary>
/// Form used to display the authenticated user's profile information.
/// </summary>
public partial class MiPerfilForm : Form
{
    private readonly UsuarioController _usuarioController;

    /// <summary>
    /// Initializes a new instance of the form with the required user controller.
    /// </summary>
    /// <param name="usuarioController">Controller used to manage user data.</param>
    public MiPerfilForm(UsuarioController usuarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
    }

    private void MiPerfilForm_Load(object sender, EventArgs e)
    {
        CargarInformacionUsuario();
    }

    private void CargarInformacionUsuario()
    {
        Usuario? usuario = _usuarioController.UsuarioAutenticado;

        if (usuario is null)
        {
            MessageBox.Show(
                "No hay usuario autenticado.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            Close();
            return;
        }

        lblNombreValor.Text = usuario.Nombre;
        lblPesoValor.Text = $"{usuario.Peso} kg";
        lblAlturaValor.Text = usuario.Estatura.ToString();
        lblObjetivoValor.Text = usuario.Objetivo.ToString();
        lblTipoDietaValor.Text = usuario.TipoDieta.ToString();
        lblNivelActividadValor.Text = usuario.NivelActividad.ToString();
    }

    private void BtnEditarPerfil_Click(object sender, EventArgs e)
    {
        using EditarUsuarioForm form = new(_usuarioController);
        form.ShowDialog();

        CargarInformacionUsuario();
    }

    private void BtnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }
}