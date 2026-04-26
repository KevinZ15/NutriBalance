using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Interfaces;

/// <summary>
/// Defines the contract for daily menu data persistence operations.
/// </summary>
public interface IMenuDiarioRepository
{
    /// <summary>
    /// Gets all daily menus.
    /// </summary>
    /// <returns>A list of all daily menus.</returns>
    List<MenuDiario> ObtenerTodos();

    /// <summary>
    /// Gets a daily menu by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the daily menu.</param>
    /// <returns>The matching daily menu, or <c>null</c> if not found.</returns>
    MenuDiario? ObtenerPorId(Guid id);

    /// <summary>
    /// Gets a daily menu for a specific user and date.
    /// </summary>
    /// <param name="usuarioId">The unique identifier of the user.</param>
    /// <param name="fecha">The date of the menu.</param>
    /// <returns>The matching daily menu, or <c>null</c> if not found.</returns>
    MenuDiario? ObtenerPorUsuarioYFecha(Guid usuarioId, DateTime fecha);

    /// <summary>
    /// Adds a new daily menu.
    /// </summary>
    /// <param name="menu">The daily menu to add.</param>
    void Agregar(MenuDiario menu);

    /// <summary>
    /// Updates an existing daily menu.
    /// </summary>
    /// <param name="menu">The daily menu with updated values.</param>
    void Actualizar(MenuDiario menu);

    /// <summary>
    /// Deletes a daily menu by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the daily menu to delete.</param>
    void Eliminar(Guid id);
}