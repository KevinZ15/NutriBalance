using NutriBalance.Controller;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;

namespace NutriBalance.View;

public partial class EditarUsuarioForm : Form
{
    private readonly UsuarioController _usuarioController;

    public EditarUsuarioForm(UsuarioController usuarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
    }

    private void EditarUsuarioForm_Load(object sender, EventArgs e)
    {
        cmbNivelActividad.Items.Clear();
        cmbNivelActividad.Items.AddRange(Enum.GetNames(typeof(NivelActividad)));

        cmbObjetivo.Items.Clear();
        cmbObjetivo.Items.AddRange(Enum.GetNames(typeof(ObjetivoUsuario)));

        cmbTipoDieta.Items.Clear();
        cmbTipoDieta.Items.AddRange(Enum.GetNames(typeof(TipoDieta)));

        CargarUsuarioActual();
    }

    private void CargarUsuarioActual()
    {
        Usuario? usuario = _usuarioController.UsuarioAutenticado;

        if (usuario is null)
        {
            MessageBox.Show("No hay usuario autenticado.");
            Close();
            return;
        }

        txtContrasena.Text = usuario.Contrasena;
        txtNombre.Text = usuario.Nombre;
        txtPeso.Text = usuario.Peso.ToString();
        txtEstatura.Text = usuario.Estatura.ToString();
        cmbNivelActividad.SelectedItem = usuario.NivelActividad.ToString();
        cmbObjetivo.SelectedItem = usuario.Objetivo.ToString();
        cmbTipoDieta.SelectedItem = usuario.TipoDieta.ToString();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        Usuario? usuarioActual = _usuarioController.UsuarioAutenticado;

        if (usuarioActual is null)
        {
            MessageBox.Show("No hay usuario autenticado.");
            return;
        }

        if (!decimal.TryParse(txtPeso.Text, out decimal peso))
        {
            MessageBox.Show("El peso debe ser numérico.");
            return;
        }

        if (!decimal.TryParse(txtEstatura.Text, out decimal estatura))
        {
            MessageBox.Show("La estatura debe ser numérica.");
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
            NivelActividad = Enum.Parse<NivelActividad>(cmbNivelActividad.SelectedItem!.ToString()!),
            Objetivo = Enum.Parse<ObjetivoUsuario>(cmbObjetivo.SelectedItem!.ToString()!),
            TipoDieta = Enum.Parse<TipoDieta>(cmbTipoDieta.SelectedItem!.ToString()!)
        };

        var resultado = _usuarioController.ActualizarPerfil(usuarioActualizado);

        if (!resultado.Exito)
        {
            MessageBox.Show(resultado.Mensaje, "Editar perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show(resultado.Mensaje, "Editar perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Close();
    }
}