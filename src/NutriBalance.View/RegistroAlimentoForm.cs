using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.View;

/// <summary>
/// Form used to register a new food item.
/// </summary>
public partial class RegistroAlimentoForm : Form
{
    private readonly AlimentoController _alimentoController;

    /// <summary>
    /// Initializes a new instance of the form with the required food controller.
    /// </summary>
    /// <param name="alimentoController">Controller used to manage food data.</param>
    public RegistroAlimentoForm(AlimentoController alimentoController)
    {
        InitializeComponent();
        _alimentoController = alimentoController;
    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            MessageBox.Show(
                "El nombre del alimento es obligatorio.",
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

        if (!chkKeto.Checked && !chkVegetariano.Checked && !chkEstandar.Checked)
        {
            MessageBox.Show(
                "Debe seleccionar al menos una clasificación para el alimento.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        decimal calorias = (proteinas * 4) + (carbohidratos * 4) + (grasas * 9);

        Alimento nuevoAlimento = new()
        {
            Nombre = txtNombre.Text.Trim(),
            Porcion = 100,
            Grasas = grasas,
            Proteinas = proteinas,
            Carbohidratos = carbohidratos,
            Calorias = calorias,
            EsKeto = chkKeto.Checked,
            EsVegetariano = chkVegetariano.Checked,
            EsEstandar = chkEstandar.Checked
        };

        var (Exito, Mensaje) = _alimentoController.RegistrarAlimento(nuevoAlimento);

        if (!Exito)
        {
            MessageBox.Show(
                Mensaje,
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        MessageBox.Show(
            Mensaje,
            "NutriBalance",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );

        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }
}