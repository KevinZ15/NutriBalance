using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.View;

public partial class HistoricoForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly MenuDiarioController _menuDiarioController;
    private readonly NutricionController _nutricionController;

    public HistoricoForm(
        UsuarioController usuarioController,
        MenuDiarioController menuDiarioController,
        NutricionController nutricionController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _menuDiarioController = menuDiarioController;
        _nutricionController = nutricionController;
    }

    private void HistoricoForm_Load(object sender, EventArgs e)
    {
        ConfigurarTabla();
        nudAnio.Value = DateTime.Today.Year;
        cmbMes.SelectedIndex = DateTime.Today.Month - 1;
    }

    private void ConfigurarTabla()
    {
        dgvHistorico.Columns.Clear();
        dgvHistorico.AutoGenerateColumns = false;

        dgvHistorico.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "Fecha",
            HeaderText = "Fecha",
            DataPropertyName = "Fecha",
            DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
        });

        dgvHistorico.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "CaloriasConsumidas",
            HeaderText = "Calorías consumidas",
            DataPropertyName = "CaloriasConsumidas",
            DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
        });

        dgvHistorico.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "CaloriasObjetivo",
            HeaderText = "Calorías objetivo",
            DataPropertyName = "CaloriasObjetivo",
            DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
        });

        dgvHistorico.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "DiferenciaCalorica",
            HeaderText = "Diferencia",
            DataPropertyName = "DiferenciaCalorica",
            DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
        });

        dgvHistorico.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "EstadoMeta",
            HeaderText = "Meta",
            DataPropertyName = "EstadoMeta"
        });
    }

    private void CargarHistorico()
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

        int anio = (int)nudAnio.Value;
        int mes = cmbMes.SelectedIndex + 1;
        decimal caloriasObjetivo = _nutricionController.CalcularCaloriasObjetivo(usuario);

        List<ResumenDiaMes> resumen = _menuDiarioController.ObtenerResumenMensual(
            usuario.Id,
            anio,
            mes,
            caloriasObjetivo
        );

        dgvHistorico.DataSource = null;
        dgvHistorico.DataSource = resumen;

        int diasCumplidos = resumen.Count(r => r.Estado == EstadoMetaDiaria.Cumplida);
        int diasExcedidos = resumen.Count(r => r.Estado == EstadoMetaDiaria.Excedida);
        int diasPorDebajo = resumen.Count(r => r.Estado == EstadoMetaDiaria.PorDebajo);
        int totalDias = resumen.Count;

        lblResumen.Text = totalDias == 0
            ? "Sin registros para este mes."
            : $"Días registrados: {totalDias}   |   Cumplidos: {diasCumplidos}   |   Excedidos: {diasExcedidos}   |   Por debajo: {diasPorDebajo}";

        ColorearFilas();
    }

    private void ColorearFilas()
    {
        foreach (DataGridViewRow fila in dgvHistorico.Rows)
        {
            if (fila.DataBoundItem is ResumenDiaMes resumen)
            {
                if (resumen.Estado == EstadoMetaDiaria.Cumplida)
                {
                    fila.DefaultCellStyle.ForeColor = Color.Green;
                }
                else if (resumen.Estado == EstadoMetaDiaria.Excedida)
                {
                    fila.DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    fila.DefaultCellStyle.ForeColor = Color.DarkOrange;
                }
            }
        }
    }

    private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
    {
        CargarHistorico();
    }

    private void nudAnio_ValueChanged(object sender, EventArgs e)
    {
        CargarHistorico();
    }

    private void btnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }
}