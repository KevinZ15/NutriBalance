using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.View;

/// <summary>
/// Form used to manage and track the user's daily diet.
/// </summary>
public partial class MiDietaForm : Form
{
    private readonly MenuDiarioController _menuDiarioController;
    private readonly AlimentoController _alimentoController;
    private readonly UsuarioController _usuarioController;

    private MenuDiario? _menuActual;

    /// <summary>
    /// Initializes a new instance of the form with the required controllers.
    /// </summary>
    /// <param name="menuDiarioController">Controller used to manage daily menu data.</param>
    /// <param name="alimentoController">Controller used to manage food data.</param>
    /// <param name="usuarioController">Controller used to access authenticated user data.</param>
    public MiDietaForm(
        MenuDiarioController menuDiarioController,
        AlimentoController alimentoController,
        UsuarioController usuarioController)
    {
        InitializeComponent();
        _menuDiarioController = menuDiarioController;
        _alimentoController = alimentoController;
        _usuarioController = usuarioController;
    }

    private void MiDietaForm_Load(object sender, EventArgs e)
    {
        ConfigurarTabla();
        dtpFecha.Value = DateTime.Today;
        CargarMenuPorFecha();
    }

    private void ConfigurarTabla()
    {
        dgvMiDieta.Columns.Clear();
        dgvMiDieta.AutoGenerateColumns = false;

        dgvMiDieta.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Id",
            HeaderText = "Id",
            DataPropertyName = "Id",
            Visible = false
        });

        dgvMiDieta.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "NombreAlimento",
            HeaderText = "Alimento",
            DataPropertyName = "NombreAlimento"
        });

        dgvMiDieta.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "CantidadUnidades",
            HeaderText = "Unidades",
            DataPropertyName = "CantidadUnidades"
        });

        dgvMiDieta.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "GramosPorUnidad",
            HeaderText = "g/unidad",
            DataPropertyName = "GramosPorUnidad"
        });

        dgvMiDieta.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Cantidad",
            HeaderText = "Total (g)",
            DataPropertyName = "Cantidad"
        });

        dgvMiDieta.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Proteinas",
            HeaderText = "Proteína",
            DataPropertyName = "Proteinas"
        });

        dgvMiDieta.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Grasas",
            HeaderText = "Grasas",
            DataPropertyName = "Grasas"
        });

        dgvMiDieta.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Carbohidratos",
            HeaderText = "Carbohidratos",
            DataPropertyName = "Carbohidratos"
        });

        dgvMiDieta.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "Eliminar",
            HeaderText = "Acción",
            Text = "Eliminar",
            UseColumnTextForButtonValue = true
        });
    }

    private void DtpFecha_ValueChanged(object sender, EventArgs e)
    {
        CargarMenuPorFecha();
    }

    private void CargarMenuPorFecha()
    {
        if (_usuarioController.UsuarioAutenticado is null)
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

        _menuActual = _menuDiarioController.ObtenerMenuPorUsuarioYFecha(
            _usuarioController.UsuarioAutenticado.Id,
            dtpFecha.Value.Date
        );

        RefrescarPantalla();
    }

    private void RefrescarPantalla()
    {
        if (_menuActual is null)
        {
            dgvMiDieta.DataSource = null;
            LimpiarTotales();
            return;
        }

        dgvMiDieta.DataSource = null;
        dgvMiDieta.DataSource = _menuActual.Detalles.ToList();

        ActualizarTotales();
    }

    private void ActualizarTotales()
    {
        if (_menuActual is null)
        {
            LimpiarTotales();
            return;
        }

        var (Calorias, Proteinas, Grasas, Carbohidratos) = MenuDiarioController.CalcularTotales(_menuActual);

        lblTotalCaloriasValor.Text = $"{Calorias:F2} kcal";
        lblTotalProteinasValor.Text = $"{Proteinas:F2} g";
        lblTotalGrasasValor.Text = $"{Grasas:F2} g";
        lblTotalCarbohidratosValor.Text = $"{Carbohidratos:F2} g";
    }

    private void LimpiarTotales()
    {
        lblTotalCaloriasValor.Text = "0.00 kcal";
        lblTotalProteinasValor.Text = "0.00 g";
        lblTotalGrasasValor.Text = "0.00 g";
        lblTotalCarbohidratosValor.Text = "0.00 g";
    }

    private void BtnAgregarAlimento_Click(object sender, EventArgs e)
    {
        if (_menuActual is null)
        {
            MessageBox.Show(
                "No se pudo cargar el menú actual.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        using AgregarAlimentoMenuForm form = new(_alimentoController, _usuarioController);

        if (form.ShowDialog() != DialogResult.OK || form.DetalleGenerado is null)
        {
            return;
        }

        _menuActual.Detalles.Add(form.DetalleGenerado);
        RefrescarPantalla();
    }

    private void BtnGuardar_Click(object sender, EventArgs e)
    {
        if (_menuActual is null)
        {
            MessageBox.Show(
                "No se pudo cargar el menú actual.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        _menuActual.Fecha = dtpFecha.Value.Date;

        var (Exito, Mensaje) = _menuDiarioController.GuardarMenu(_menuActual);

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

        CargarMenuPorFecha();
    }

    private void DgvMiDieta_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (_menuActual is null) return;
        if (e.RowIndex < 0) return;
        if (dgvMiDieta.Columns[e.ColumnIndex].Name != "Eliminar") return;

        object? valorId = dgvMiDieta.Rows[e.RowIndex].Cells["Id"].Value;

        if (valorId is null || !Guid.TryParse(valorId.ToString(), out Guid detalleId))
        {
            MessageBox.Show(
                "No se pudo identificar el alimento seleccionado.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        MenuDiarioDetalle? detalle = _menuActual.Detalles.FirstOrDefault(d => d.Id == detalleId);

        if (detalle is null)
        {
            MessageBox.Show(
                "No se encontró el alimento en el menú actual.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        DialogResult confirmacion = MessageBox.Show(
            $"¿Desea eliminar '{detalle.NombreAlimento}' del menú?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (confirmacion != DialogResult.Yes) return;

        _menuActual.Detalles.Remove(detalle);
        RefrescarPantalla();
    }

    private void BtnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }
}