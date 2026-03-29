using NutriBalance.Controller;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;

namespace NutriBalance.View;

/// <summary>
/// Form used to edit the currently authenticated user's profile.
/// </summary>
public partial class EditarUsuarioForm : Form
{
    private readonly UsuarioController _usuarioController;

    /// <summary>
    /// Initializes a new instance of the form with the required user controller.
    /// </summary>
    /// <param name="usuarioController">Controller used to manage user data.</param>
    public EditarUsuarioForm(UsuarioController usuarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
    }

    private void EditarUsuarioForm_Load(object sender, EventArgs e)
    {
        CargarCombos();
        CargarUsuarioActual();
    }

    private void CargarCombos()
    {
        cmbObjetivo.Items.Clear();
        cmbObjetivo.Items.AddRange(Enum.GetNames<ObjetivoUsuario>());

        cmbNivelActividad.Items.Clear();
        cmbNivelActividad.Items.AddRange(Enum.GetNames<NivelActividad>());

        cmbTipoDieta.Items.Clear();
        cmbTipoDieta.Items.AddRange(Enum.GetNames<TipoDieta>());
    }

    private void CargarUsuarioActual()
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

        txtNombre.Text = usuario.Nombre;
        txtContrasena.Text = usuario.Contrasena;
        txtPeso.Text = usuario.Peso.ToString();
        txtEstatura.Text = usuario.Estatura.ToString();

        cmbObjetivo.SelectedItem = usuario.Objetivo.ToString();
        cmbNivelActividad.SelectedItem = usuario.NivelActividad.ToString();
        cmbTipoDieta.SelectedItem = usuario.TipoDieta.ToString();
    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
        Usuario? usuarioActual = _usuarioController.UsuarioAutenticado;

        if (usuarioActual is null)
        {
            MessageBox.Show(
                "No hay usuario autenticado.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (!decimal.TryParse(txtPeso.Text, out decimal peso))
        {
            MessageBox.Show(
                "El peso debe ser numérico.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (!decimal.TryParse(txtEstatura.Text, out decimal estatura))
        {
            MessageBox.Show(
                "La altura debe ser numérica.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (cmbObjetivo.SelectedItem is null)
        {
            MessageBox.Show(
                "Debe seleccionar un objetivo.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (cmbNivelActividad.SelectedItem is null)
        {
            MessageBox.Show(
                "Debe seleccionar un nivel de actividad.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (cmbTipoDieta.SelectedItem is null)
        {
            MessageBox.Show(
                "Debe seleccionar un tipo de dieta.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        Usuario usuarioActualizado = new()
        {
            Id = usuarioActual.Id,
            NombreUsuario = usuarioActual.NombreUsuario,
            Contrasena = txtContrasena.Text,
            Nombre = txtNombre.Text.Trim(),
            Peso = peso,
            Estatura = estatura,
            Objetivo = Enum.Parse<ObjetivoUsuario>(cmbObjetivo.SelectedItem.ToString()!),
            NivelActividad = Enum.Parse<NivelActividad>(cmbNivelActividad.SelectedItem.ToString()!),
            TipoDieta = Enum.Parse<TipoDieta>(cmbTipoDieta.SelectedItem.ToString()!)
        };

        var (exito, mensaje) = _usuarioController.ActualizarPerfil(usuarioActualizado);

        if (!exito)
        {
            MessageBox.Show(
                mensaje,
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        MessageBox.Show(
            mensaje,
            "NutriBalance",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }
}