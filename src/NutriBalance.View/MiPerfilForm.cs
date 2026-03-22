using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.View;

public partial class MiPerfilForm : Form
{
    private readonly UsuarioController _usuarioController;

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

    private void btnEditarPerfil_Click(object sender, EventArgs e)
    {
        using EditarUsuarioForm form = new(_usuarioController);
        form.ShowDialog();

        CargarInformacionUsuario();
    }

    private void btnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }
}