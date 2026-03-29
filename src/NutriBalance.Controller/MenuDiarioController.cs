using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Controller;

public class MenuDiarioController
{
    private readonly IMenuDiarioRepository _menuDiarioRepository;

    public MenuDiarioController(IMenuDiarioRepository menuDiarioRepository)
    {
        _menuDiarioRepository = menuDiarioRepository;
    }

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
            Detalles = new List<MenuDiarioDetalle>()
        };
    }

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

    public (decimal Calorias, decimal Proteinas, decimal Grasas, decimal Carbohidratos) CalcularTotales(MenuDiario menu)
    {
        decimal totalCalorias = menu.Detalles.Sum(d => d.Calorias);
        decimal totalProteinas = menu.Detalles.Sum(d => d.Proteinas);
        decimal totalGrasas = menu.Detalles.Sum(d => d.Grasas);
        decimal totalCarbohidratos = menu.Detalles.Sum(d => d.Carbohidratos);

        return (totalCalorias, totalProteinas, totalGrasas, totalCarbohidratos);
    }

    public EstadoMetaDiaria EvaluarMetaCalorica(decimal caloriasConsumidas, decimal caloriasObjetivo)
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

    public List<ResumenDiaMes> ObtenerResumenMensual(Guid usuarioId, int anio, int mes, decimal caloriasObjetivo)
    {
        List<MenuDiario> menus = _menuDiarioRepository.ObtenerTodos()
            .Where(m => m.UsuarioId == usuarioId && m.Fecha.Year == anio && m.Fecha.Month == mes)
            .OrderBy(m => m.Fecha)
            .ToList();

        List<ResumenDiaMes> resumen = new();

        foreach (MenuDiario menu in menus)
        {
            var totales = CalcularTotales(menu);
            EstadoMetaDiaria estado = EvaluarMetaCalorica(totales.Calorias, caloriasObjetivo);

            resumen.Add(new ResumenDiaMes
            {
                Fecha = menu.Fecha,
                CaloriasConsumidas = totales.Calorias,
                CaloriasObjetivo = caloriasObjetivo,
                DiferenciaCalorica = totales.Calorias - caloriasObjetivo,
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

public class ResumenDiaMes
{
    public DateTime Fecha { get; set; }
    public decimal CaloriasConsumidas { get; set; }
    public decimal CaloriasObjetivo { get; set; }
    public decimal DiferenciaCalorica { get; set; }
    public EstadoMetaDiaria Estado { get; set; }
    public bool CumplioMeta => Estado == EstadoMetaDiaria.Cumplida;

    public string EstadoMeta =>
        Estado switch
        {
            EstadoMetaDiaria.Cumplida => "✔ Cumplida",
            EstadoMetaDiaria.Excedida => "▲ Se excedió",
            _ => "▼ Por debajo"
        };
}