using NutriBalance.Controller;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;

namespace NutriBalance.View;

public partial class RegistroUsuarioForm : Form
{
    private readonly UsuarioController _usuarioController;

    public RegistroUsuarioForm(UsuarioController usuarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
    }

    private void RegistroUsuarioForm_Load(object sender, EventArgs e)
    {
        cmbNivelActividad.Items.Clear();
        cmbNivelActividad.Items.AddRange(Enum.GetNames(typeof(NivelActividad)));

        cmbObjetivo.Items.Clear();
        cmbObjetivo.Items.AddRange(Enum.GetNames(typeof(ObjetivoUsuario)));

        cmbTipoDieta.Items.Clear();
        cmbTipoDieta.Items.AddRange(Enum.GetNames(typeof(TipoDieta)));

        cmbNivelActividad.SelectedIndex = 0;
        cmbObjetivo.SelectedIndex = 0;
        cmbTipoDieta.SelectedIndex = 0;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
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

        Usuario usuario = new()
        {
            NombreUsuario = txtNombreUsuario.Text.Trim(),
            Contrasena = txtContrasena.Text,
            Nombre = txtNombre.Text.Trim(),
            Peso = peso,
            Estatura = estatura,
            NivelActividad = Enum.Parse<NivelActividad>(cmbNivelActividad.SelectedItem!.ToString()!),
            Objetivo = Enum.Parse<ObjetivoUsuario>(cmbObjetivo.SelectedItem!.ToString()!),
            TipoDieta = Enum.Parse<TipoDieta>(cmbTipoDieta.SelectedItem!.ToString()!)
        };

        var resultado = _usuarioController.RegistrarUsuario(usuario);

        MessageBox.Show(resultado.Mensaje);

        if (resultado.Exito)
        {
            Close();
        }
    }
}