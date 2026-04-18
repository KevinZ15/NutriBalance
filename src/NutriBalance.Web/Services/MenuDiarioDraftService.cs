using NutriBalance.Model.Entities;

namespace NutriBalance.Web.Services;

public class MenuDiarioDraftService
{
    public MenuDiario? MenuActual { get; private set; }

    public void Establecer(MenuDiario menu)
    {
        MenuActual = menu;
    }

    public bool EsMismoMenu(Guid usuarioId, DateTime fecha)
    {
        return MenuActual is not null
            && MenuActual.UsuarioId == usuarioId
            && MenuActual.Fecha.Date == fecha.Date;
    }

    public void Limpiar()
    {
        MenuActual = null;
    }
}