using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.View;

/// <summary>
/// Form used to display the user's daily nutritional summary.
/// </summary>
public partial class ResumenDiarioForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly MenuDiarioController _menuDiarioController;

    /// <summary>
    /// Initializes a new instance of the form with the required controllers.
    /// </summary>
    /// <param name="usuarioController">Controller used to access authenticated user data.</param>
    /// <param name="menuDiarioController">Controller used to manage daily menu data.</param>
    public ResumenDiarioForm(
        UsuarioController usuarioController,
        MenuDiarioController menuDiarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
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

        decimal imc = NutricionController.CalcularIMC(usuario);
        string clasificacion = NutricionController.ClasificarIMC(imc);
        decimal caloriasObjetivo = NutricionController.CalcularCaloriasObjetivo(usuario);
        var (Proteinas, Grasas, Carbohidratos, NombreDieta) = NutricionController.CalcularMacros(usuario);

        lblIMCValor.Text = $"{imc:F2} ({clasificacion})";
        lblCaloriasObjetivoValor.Text = $"{caloriasObjetivo:F2} kcal/día";
        lblDietaValor.Text = NombreDieta;
        lblProteinasObjetivoValor.Text = $"{Proteinas:F2} g/día";
        lblGrasasObjetivoValor.Text = $"{Grasas:F2} g/día";
        lblCarbohidratosObjetivoValor.Text = $"{Carbohidratos:F2} g/día";

        MenuDiario menuHoy = _menuDiarioController.ObtenerMenuPorUsuarioYFecha(
            usuario.Id,
            DateTime.Today
        );

        var totales = MenuDiarioController.CalcularTotales(menuHoy);

        decimal caloriasRestantes = caloriasObjetivo - totales.Calorias;
        decimal proteinasRestantes = Proteinas - totales.Proteinas;
        decimal grasasRestantes = Grasas - totales.Grasas;
        decimal carbohidratosRestantes = Carbohidratos - totales.Carbohidratos;

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

        EstadoMetaDiaria estadoCalorias = MenuDiarioController.EvaluarMetaCalorica(totales.Calorias, caloriasObjetivo);

        string mensajeEstado =
            estadoCalorias switch
            {
                EstadoMetaDiaria.Cumplida => "Meta calórica del día: cumplida",
                EstadoMetaDiaria.Excedida => "Meta calórica del día: excedida",
                _ => "Meta calórica del día: por debajo"
            };

        lblCaloriasRestantes.Text = mensajeEstado;
    }

    private static string FormatearResultadoMeta(decimal diferencia, string unidad)
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

    private static Color ObtenerColorResultado(decimal diferencia)
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

    private void BtnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }
}