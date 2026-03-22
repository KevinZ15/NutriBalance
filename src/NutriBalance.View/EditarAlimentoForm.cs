using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.View;

public partial class EditarAlimentoForm : Form
{
    private readonly AlimentoController _alimentoController;
    private List<Alimento> _alimentos = new();

    public EditarAlimentoForm(AlimentoController alimentoController)
    {
        InitializeComponent();
        _alimentoController = alimentoController;
    }

    private void EditarAlimentoForm_Load(object sender, EventArgs e)
    {
        CargarAlimentos();
    }

    private void CargarAlimentos()
    {
        _alimentos = _alimentoController.ObtenerTodos();

        cmbAlimentos.DataSource = null;
        cmbAlimentos.DisplayMember = "Nombre";
        cmbAlimentos.ValueMember = "Id";
        cmbAlimentos.DataSource = _alimentos;

        if (_alimentos.Count > 0)
        {
            cmbAlimentos.SelectedIndex = 0;
            CargarDatosAlimentoSeleccionado();
        }
        else
        {
            LimpiarCampos();
        }
    }

    private void CargarDatosAlimentoSeleccionado()
    {
        if (cmbAlimentos.SelectedItem is not Alimento alimentoSeleccionado)
        {
            LimpiarCampos();
            return;
        }

        txtGrasas.Text = alimentoSeleccionado.Grasas.ToString();
        txtProteinas.Text = alimentoSeleccionado.Proteinas.ToString();
        txtCarbohidratos.Text = alimentoSeleccionado.Carbohidratos.ToString();
    }

    private void LimpiarCampos()
    {
        txtGrasas.Text = string.Empty;
        txtProteinas.Text = string.Empty;
        txtCarbohidratos.Text = string.Empty;
    }

    private void cmbAlimentos_SelectedIndexChanged(object sender, EventArgs e)
    {
        CargarDatosAlimentoSeleccionado();
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
        if (cmbAlimentos.SelectedItem is not Alimento alimentoSeleccionado)
        {
            MessageBox.Show(
                "Debe seleccionar un alimento.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (!decimal.TryParse(txtGrasas.Text, out decimal grasas))
        {
            MessageBox.Show(
                "Las grasas deben ser numéricas.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (!decimal.TryParse(txtProteinas.Text, out decimal proteinas))
        {
            MessageBox.Show(
                "Las proteínas deben ser numéricas.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (!decimal.TryParse(txtCarbohidratos.Text, out decimal carbohidratos))
        {
            MessageBox.Show(
                "Los carbohidratos deben ser numéricos.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        decimal calorias = (proteinas * 4) + (carbohidratos * 4) + (grasas * 9);

        Alimento alimentoActualizado = new()
        {
            Id = alimentoSeleccionado.Id,
            Nombre = alimentoSeleccionado.Nombre,
            Porcion = alimentoSeleccionado.Porcion,
            Grasas = grasas,
            Proteinas = proteinas,
            Carbohidratos = carbohidratos,
            Calorias = calorias
        };

        var resultado = _alimentoController.ActualizarAlimento(alimentoActualizado);

        if (!resultado.Exito)
        {
            MessageBox.Show(
                resultado.Mensaje,
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        MessageBox.Show(
            resultado.Mensaje,
            "NutriBalance",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );

        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }
}