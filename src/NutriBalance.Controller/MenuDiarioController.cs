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
}