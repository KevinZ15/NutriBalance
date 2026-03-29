using NutriBalance.Controller;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;

namespace NutriBalance.View;

/// <summary>
/// Form used to collect the second step of user registration data.
/// </summary>
public partial class RegistroUsuarioPaso2Form : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly string _nombreUsuario;
    private readonly string _nombre;
    private readonly string _contrasena;

    /// <summary>
    /// Initializes a new instance of the form with the required registration data and user controller.
    /// </summary>
    /// <param name="usuarioController">Controller used to manage user data.</param>
    /// <param name="nombreUsuario">The username entered in the first registration step.</param>
    /// <param name="nombre">The name entered in the first registration step.</param>
    /// <param name="contrasena">The password entered in the first registration step.</param>
    public RegistroUsuarioPaso2Form(
        UsuarioController usuarioController,
        string nombreUsuario,
        string nombre,
        string contrasena)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _nombreUsuario = nombreUsuario;
        _nombre = nombre;
        _contrasena = contrasena;
    }

    private void RegistroUsuarioPaso2Form_Load(object sender, EventArgs e)
    {
        cmbObjetivo.Items.Clear();
        cmbObjetivo.Items.AddRange(Enum.GetNames<ObjetivoUsuario>());

        cmbNivelActividad.Items.Clear();
        cmbNivelActividad.Items.AddRange(Enum.GetNames<NivelActividad>());

        cmbTipoDieta.Items.Clear();
        cmbTipoDieta.Items.AddRange(Enum.GetNames<TipoDieta>());

        cmbObjetivo.SelectedIndex = 0;
        cmbNivelActividad.SelectedIndex = 0;
        cmbTipoDieta.SelectedIndex = 0;
    }

    private void BtnAceptar_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(txtPeso.Text, out decimal peso))
        {
            MessageBox.Show("El peso debe ser numérico.");
            return;
        }

        if (!decimal.TryParse(txtEstatura.Text, out decimal estatura))
        {
            MessageBox.Show("La altura debe ser numérica.");
            return;
        }

        Usuario usuario = new()
        {
            NombreUsuario = _nombreUsuario,
            Nombre = _nombre,
            Contrasena = _contrasena,
            Peso = peso,
            Estatura = estatura,
            Objetivo = Enum.Parse<ObjetivoUsuario>(cmbObjetivo.SelectedItem!.ToString()!),
            NivelActividad = Enum.Parse<NivelActividad>(cmbNivelActividad.SelectedItem!.ToString()!),
            TipoDieta = Enum.Parse<TipoDieta>(cmbTipoDieta.SelectedItem!.ToString()!)
        };

        var (exito, mensaje) = _usuarioController.RegistrarUsuario(usuario);

        if (!exito)
        {
            MessageBox.Show(mensaje, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show(mensaje, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        DialogResult = DialogResult.OK;
        Close();
    }
}