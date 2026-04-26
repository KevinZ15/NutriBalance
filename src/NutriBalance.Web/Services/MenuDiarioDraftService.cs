using NutriBalance.Model.Entities;

namespace NutriBalance.Web.Services;

/// <summary>
/// Holds an in-memory draft of the current daily menu being edited.
/// </summary>
public class MenuDiarioDraftService
{
    /// <summary>
    /// Gets the current draft menu, or <c>null</c> if none is set.
    /// </summary>
    public MenuDiario? MenuActual { get; private set; }

    /// <summary>
    /// Sets the specified menu as the current draft.
    /// </summary>
    /// <param name="menu">The menu to set as the current draft.</param>
    public void Establecer(MenuDiario menu)
    {
        MenuActual = menu;
    }

    /// <summary>
    /// Determines whether the current draft matches the specified user and date.
    /// </summary>
    /// <param name="usuarioId">The unique identifier of the user.</param>
    /// <param name="fecha">The date to compare against.</param>
    /// <returns><c>true</c> if the draft matches; otherwise, <c>false</c>.</returns>
    public bool EsMismoMenu(Guid usuarioId, DateTime fecha)
    {
        return MenuActual is not null
            && MenuActual.UsuarioId == usuarioId
            && MenuActual.Fecha.Date == fecha.Date;
    }

    /// <summary>
    /// Clears the current draft menu.
    /// </summary>
    public void Limpiar()
    {
        MenuActual = null;
    }
}