using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Controller;

public class MenuDiarioController(IMenuDiarioRepository menuDiarioRepository)
{
    private readonly IMenuDiarioRepository _menuDiarioRepository = menuDiarioRepository;

    /// <summary>
    /// Retrieves the daily menu for a specific user and date.
    /// If no menu exists, a new empty menu is returned.
    /// </summary>
    /// <param name="usuarioId">The unique identifier of the user.</param>
    /// <param name="fecha">The date of the menu.</param>
    /// <returns>The existing or a new initialized daily menu.</returns>
    public MenuDiario ObtenerMenuPorUsuarioYFecha(Guid usuarioId, DateTime fecha)
    {
        MenuDiario? menu = _menuDiarioRepository.ObtenerPorUsuarioYFecha(usuarioId, fecha);

        if (menu is not null)
        {
            return menu;
        }

        return new MenuDiario
        {
            UsuarioId = usuarioId,
            Fecha = fecha.Date,
            Detalles = []
        };
    }

    /// <summary>
    /// Saves a daily menu. If it already exists, it updates it; otherwise, it creates a new one.
    /// </summary>
    /// <param name="menu">The daily menu to be saved.</param>
    /// <returns>
    /// A tuple indicating whether the operation was successful and a message describing the result.
    /// </returns>
    public (bool Exito, string Mensaje) GuardarMenu(MenuDiario menu)
    {
        if (menu.UsuarioId == Guid.Empty)
        {
            return (false, "El usuario del menú es obligatorio.");
        }

        if (menu.Fecha == default)
        {
            return (false, "La fecha del menú es obligatoria.");
        }

        MenuDiario? menuExistente = _menuDiarioRepository.ObtenerPorUsuarioYFecha(menu.UsuarioId, menu.Fecha);

        if (menuExistente is null)
        {
            _menuDiarioRepository.Agregar(menu);
        }
        else
        {
            menuExistente.Detalles = menu.Detalles;
            _menuDiarioRepository.Actualizar(menuExistente);
        }

        return (true, "Menú guardado correctamente.");
    }

    /// <summary>
    /// Calculates total calories and macronutrients for a given daily menu.
    /// </summary>
    /// <param name="menu">The daily menu to evaluate.</param>
    /// <returns>
    /// A tuple containing total calories, proteins, fats, and carbohydrates.
    /// </returns>
    public static (decimal Calorias, decimal Proteinas, decimal Grasas, decimal Carbohidratos) CalcularTotales(MenuDiario menu)
    {
        decimal totalCalorias = menu.Detalles.Sum(d => d.Calorias);
        decimal totalProteinas = menu.Detalles.Sum(d => d.Proteinas);
        decimal totalGrasas = menu.Detalles.Sum(d => d.Grasas);
        decimal totalCarbohidratos = menu.Detalles.Sum(d => d.Carbohidratos);

        return (totalCalorias, totalProteinas, totalGrasas, totalCarbohidratos);
    }

    /// <summary>
    /// Evaluates whether the consumed calories meet the daily calorie goal.
    /// </summary>
    /// <param name="caloriasConsumidas">The total calories consumed.</param>
    /// <param name="caloriasObjetivo">The target calorie goal.</param>
    /// <returns>The evaluation result indicating if the goal was met, exceeded, or below target.</returns>
    public static EstadoMetaDiaria EvaluarMetaCalorica(decimal caloriasConsumidas, decimal caloriasObjetivo)
    {
        decimal minimo = caloriasObjetivo * 0.9m;
        decimal maximo = caloriasObjetivo * 1.1m;

        if (caloriasConsumidas > maximo)
        {
            return EstadoMetaDiaria.Excedida;
        }

        if (caloriasConsumidas < minimo)
        {
            return EstadoMetaDiaria.PorDebajo;
        }

        return EstadoMetaDiaria.Cumplida;
    }

    /// <summary>
    /// Generates a monthly summary of daily menus for a specific user.
    /// </summary>
    /// <param name="usuarioId">The unique identifier of the user.</param>
    /// <param name="anio">The year to filter.</param>
    /// <param name="mes">The month to filter.</param>
    /// <param name="caloriasObjetivo">The daily calorie goal.</param>
    /// <returns>A list of daily summaries for the selected month.</returns>
    public List<ResumenDiaMes> ObtenerResumenMensual(Guid usuarioId, int anio, int mes, decimal caloriasObjetivo)
    {
        List<MenuDiario> menus =
        [.. _menuDiarioRepository.ObtenerTodos()
            .Where(m => m.UsuarioId == usuarioId && m.Fecha.Year == anio && m.Fecha.Month == mes)
            .OrderBy(m => m.Fecha)];

        List<ResumenDiaMes> resumen = [];

        foreach (MenuDiario menu in menus)
        {
            var (calorias, _, _, _) = CalcularTotales(menu);
            EstadoMetaDiaria estado = EvaluarMetaCalorica(calorias, caloriasObjetivo);

            resumen.Add(new ResumenDiaMes
            {
                Fecha = menu.Fecha,
                CaloriasConsumidas = calorias,
                CaloriasObjetivo = caloriasObjetivo,
                DiferenciaCalorica = calorias - caloriasObjetivo,
                Estado = estado
            });
        }

        return resumen;
    }
}

public enum EstadoMetaDiaria
{
    Cumplida,
    PorDebajo,
    Excedida
}

/// <summary>
/// Represents a daily summary of calorie intake and goal evaluation.
/// </summary>
public class ResumenDiaMes
{
    /// <summary>
    /// The date of the summary.
    /// </summary>
    public DateTime Fecha { get; set; }

    /// <summary>
    /// Total calories consumed on that day.
    /// </summary>
    public decimal CaloriasConsumidas { get; set; }

    /// <summary>
    /// Target calorie goal for the day.
    /// </summary>
    public decimal CaloriasObjetivo { get; set; }

    /// <summary>
    /// Difference between consumed calories and the target goal.
    /// </summary>
    public decimal DiferenciaCalorica { get; set; }

    /// <summary>
    /// Evaluation status of the daily calorie goal.
    /// </summary>
    public EstadoMetaDiaria Estado { get; set; }

    /// <summary>
    /// Indicates whether the calorie goal was achieved.
    /// </summary>
    public bool CumplioMeta => Estado == EstadoMetaDiaria.Cumplida;

    /// <summary>
    /// Returns a human-readable description of the goal status.
    /// </summary>
    public string EstadoMeta =>
        Estado switch
        {
            EstadoMetaDiaria.Cumplida => "✔ Cumplida",
            EstadoMetaDiaria.Excedida => "▲ Se excedió",
            _ => "▼ Por debajo"
        };
}