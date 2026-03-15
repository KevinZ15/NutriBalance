using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.View;

public partial class MainForm : Form
{
    private readonly UsuarioController _usuarioController;

    public MainForm(UsuarioController usuarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        CargarInformacionUsuario();
    }

    private void CargarInformacionUsuario()
    {
        Usuario? usuario = _usuarioController.UsuarioAutenticado;

        if (usuario is null)
        {
            MessageBox.Show("No hay usuario autenticado.");
            Close();
            return;
        }

        lblNombre.Text = $"Nombre: {usuario.Nombre}";
        lblPeso.Text = $"Peso: {usuario.Peso} kg";
        lblEstatura.Text = $"Estatura: {usuario.Estatura} m";
        lblActividad.Text = $"Nivel de actividad: {usuario.NivelActividad}";
        lblObjetivo.Text = $"Objetivo: {usuario.Objetivo}";
        lblDieta.Text = $"Tipo de dieta: {usuario.TipoDieta}";
    }

    private void btnEditarPerfil_Click(object sender, EventArgs e)
    {
        using EditarUsuarioForm form = new(_usuarioController);
        form.ShowDialog();

        CargarInformacionUsuario();
    }
}