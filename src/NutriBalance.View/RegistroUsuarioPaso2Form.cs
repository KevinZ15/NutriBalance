using NutriBalance.Controller;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;

namespace NutriBalance.View;

public partial class RegistroUsuarioPaso2Form : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly AlimentoController _alimentoController;
    private readonly string _nombreUsuario;
    private readonly string _nombre;
    private readonly string _contrasena;

    public RegistroUsuarioPaso2Form(
        UsuarioController usuarioController,
        AlimentoController alimentoController,
        string nombreUsuario,
        string nombre,
        string contrasena)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _alimentoController = alimentoController;
        _nombreUsuario = nombreUsuario;
        _nombre = nombre;
        _contrasena = contrasena;
    }

    private void RegistroUsuarioPaso2Form_Load(object sender, EventArgs e)
    {
        cmbObjetivo.Items.Clear();
        cmbObjetivo.Items.AddRange(Enum.GetNames(typeof(ObjetivoUsuario)));

        cmbNivelActividad.Items.Clear();
        cmbNivelActividad.Items.AddRange(Enum.GetNames(typeof(NivelActividad)));

        cmbTipoDieta.Items.Clear();
        cmbTipoDieta.Items.AddRange(Enum.GetNames(typeof(TipoDieta)));

        cmbObjetivo.SelectedIndex = 0;
        cmbNivelActividad.SelectedIndex = 0;
        cmbTipoDieta.SelectedIndex = 0;
    }

    private void btnAceptar_Click(object sender, EventArgs e)
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

        var resultado = _usuarioController.RegistrarUsuario(usuario);

        if (!resultado.Exito)
        {
            MessageBox.Show(resultado.Mensaje, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show(resultado.Mensaje, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        DialogResult = DialogResult.OK;
        Close();
    }
}