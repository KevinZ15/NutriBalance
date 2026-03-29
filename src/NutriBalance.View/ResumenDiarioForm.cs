using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.View;

public partial class ResumenDiarioForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly NutricionController _nutricionController;
    private readonly MenuDiarioController _menuDiarioController;

    public ResumenDiarioForm(
        UsuarioController usuarioController,
        NutricionController nutricionController,
        MenuDiarioController menuDiarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _nutricionController = nutricionController;
        _menuDiarioController = menuDiarioController;
    }

    private void ResumenDiarioForm_Load(object sender, EventArgs e)
    {
        CargarInformacion();
    }

    private void CargarInformacion()
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

        decimal imc = _nutricionController.CalcularIMC(usuario);
        string clasificacion = _nutricionController.ClasificarIMC(imc);
        decimal caloriasObjetivo = _nutricionController.CalcularCaloriasObjetivo(usuario);
        var macros = _nutricionController.CalcularMacros(usuario);

        lblIMCValor.Text = $"{imc:F2} ({clasificacion})";
        lblCaloriasObjetivoValor.Text = $"{caloriasObjetivo:F2} kcal/día";
        lblDietaValor.Text = macros.NombreDieta;
        lblProteinasObjetivoValor.Text = $"{macros.Proteinas:F2} g/día";
        lblGrasasObjetivoValor.Text = $"{macros.Grasas:F2} g/día";
        lblCarbohidratosObjetivoValor.Text = $"{macros.Carbohidratos:F2} g/día";

        MenuDiario menuHoy = _menuDiarioController.ObtenerMenuPorUsuarioYFecha(
            usuario.Id,
            DateTime.Today
        );

        var totales = _menuDiarioController.CalcularTotales(menuHoy);

        decimal caloriasRestantes = caloriasObjetivo - totales.Calorias;
        decimal proteinasRestantes = macros.Proteinas - totales.Proteinas;
        decimal grasasRestantes = macros.Grasas - totales.Grasas;
        decimal carbohidratosRestantes = macros.Carbohidratos - totales.Carbohidratos;

        lblCaloriasConsumidasValor.Text = $"{totales.Calorias:F2} kcal";
        lblProteinasConsumidasValor.Text = $"{totales.Proteinas:F2} g";
        lblGrasasConsumidasValor.Text = $"{totales.Grasas:F2} g";
        lblCarbohidratosConsumidasValor.Text = $"{totales.Carbohidratos:F2} g";

        lblCaloriasRestantesValor.Text = FormatearResultadoMeta(caloriasRestantes, "kcal");
        lblProteinasRestantesValor.Text = FormatearResultadoMeta(proteinasRestantes, "g");
        lblGrasasRestantesValor.Text = FormatearResultadoMeta(grasasRestantes, "g");
        lblCarbohidratosRestantesValor.Text = FormatearResultadoMeta(carbohidratosRestantes, "g");

        lblCaloriasRestantesValor.ForeColor = ObtenerColorResultado(caloriasRestantes);
        lblProteinasRestantesValor.ForeColor = ObtenerColorResultado(proteinasRestantes);
        lblGrasasRestantesValor.ForeColor = ObtenerColorResultado(grasasRestantes);
        lblCarbohidratosRestantesValor.ForeColor = ObtenerColorResultado(carbohidratosRestantes);

        EstadoMetaDiaria estadoCalorias = _menuDiarioController.EvaluarMetaCalorica(totales.Calorias, caloriasObjetivo);

        string mensajeEstado =
            estadoCalorias switch
            {
                EstadoMetaDiaria.Cumplida => "Meta calórica del día: cumplida",
                EstadoMetaDiaria.Excedida => "Meta calórica del día: excedida",
                _ => "Meta calórica del día: por debajo"
            };

        lblCaloriasRestantes.Text = mensajeEstado;
    }

    private string FormatearResultadoMeta(decimal diferencia, string unidad)
    {
        if (diferencia < 0)
        {
            return $"Excedido por {Math.Abs(diferencia):F2} {unidad}";
        }

        if (diferencia == 0)
        {
            return $"Meta exacta: 0.00 {unidad}";
        }

        return $"Faltan {diferencia:F2} {unidad}";
    }

    private Color ObtenerColorResultado(decimal diferencia)
    {
        if (diferencia < 0)
        {
            return Color.Red;
        }

        if (diferencia == 0)
        {
            return Color.Blue;
        }

        return Color.Green;
    }

    private void btnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }
}