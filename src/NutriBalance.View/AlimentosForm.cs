using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.View;

/// <summary>
/// Form used to manage food items in the system.
/// </summary>
public partial class AlimentosForm : Form
{
    private readonly AlimentoController _alimentoController;
    private List<Alimento> _todosLosAlimentos = [];

    /// <summary>
    /// Initializes a new instance of the form with the required food controller.
    /// </summary>
    /// <param name="alimentoController">Controller used to manage food data.</param>
    public AlimentosForm(AlimentoController alimentoController)
    {
        InitializeComponent();
        _alimentoController = alimentoController;
    }

    private void AlimentosForm_Load(object sender, EventArgs e)
    {
        ConfigurarTabla();
        CargarAlimentos();
    }

    private void ConfigurarTabla()
    {
        dgvAlimentos.Columns.Clear();
        dgvAlimentos.AutoGenerateColumns = false;

        dgvAlimentos.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Id",
            HeaderText = "Id",
            DataPropertyName = "Id",
            Visible = false
        });

        dgvAlimentos.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Nombre",
            HeaderText = "Alimento",
            DataPropertyName = "Nombre"
        });

        dgvAlimentos.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Grasas",
            HeaderText = "Grasas",
            DataPropertyName = "Grasas"
        });

        dgvAlimentos.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Proteinas",
            HeaderText = "Proteína",
            DataPropertyName = "Proteinas"
        });

        dgvAlimentos.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Carbohidratos",
            HeaderText = "Carbohidratos",
            DataPropertyName = "Carbohidratos"
        });
    }

    private void CargarAlimentos()
    {
        _todosLosAlimentos = _alimentoController.ObtenerTodos();
        FiltrarAlimentos(string.Empty);
    }

    private void FiltrarAlimentos(string filtro)
    {
        List<Alimento> resultado = string.IsNullOrWhiteSpace(filtro)
            ? _todosLosAlimentos
            : [.. _todosLosAlimentos
                .Where(a => a.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase))];

        dgvAlimentos.DataSource = null;
        dgvAlimentos.DataSource = resultado;
    }

    private void TxtBuscar_TextChanged(object sender, EventArgs e)
    {
        FiltrarAlimentos(txtBuscar.Text);
    }

    private void BtnAgregarAlimento_Click(object sender, EventArgs e)
    {
        using RegistroAlimentoForm form = new(_alimentoController);

        if (form.ShowDialog() == DialogResult.OK)
        {
            CargarAlimentos();
        }
    }

    private void BtnEditarAlimentos_Click(object sender, EventArgs e)
    {
        using EditarAlimentoForm form = new(_alimentoController);

        if (form.ShowDialog() == DialogResult.OK)
        {
            CargarAlimentos();
        }
    }

    private void BtnEliminarAlimento_Click(object sender, EventArgs e)
    {
        if (dgvAlimentos.CurrentRow is null)
        {
            MessageBox.Show(
                "Debe seleccionar un alimento.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        object? valorId = dgvAlimentos.CurrentRow.Cells["Id"].Value;

        if (valorId is null || !Guid.TryParse(valorId.ToString(), out Guid id))
        {
            MessageBox.Show(
                "No se pudo identificar el alimento seleccionado.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        string nombreAlimento = dgvAlimentos.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "este alimento";

        DialogResult confirmacion = MessageBox.Show(
            $"¿Desea eliminar '{nombreAlimento}'?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (confirmacion != DialogResult.Yes)
        {
            return;
        }

        var (exito, mensaje) = _alimentoController.EliminarAlimento(id);

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

        CargarAlimentos();
    }

    private void BtnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }
}