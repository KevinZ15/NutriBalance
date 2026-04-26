using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Interfaces;

/// <summary>
/// Defines the contract for food data persistence operations.
/// </summary>
public interface IAlimentoRepository
{
    /// <summary>
    /// Gets all food items.
    /// </summary>
    /// <returns>A list of all food items.</returns>
    List<Alimento> ObtenerTodos();

    /// <summary>
    /// Gets a food item by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the food item.</param>
    /// <returns>The matching food item, or <c>null</c> if not found.</returns>
    Alimento? ObtenerPorId(Guid id);

    /// <summary>
    /// Adds a new food item.
    /// </summary>
    /// <param name="alimento">The food item to add.</param>
    void Agregar(Alimento alimento);

    /// <summary>
    /// Updates an existing food item.
    /// </summary>
    /// <param name="alimento">The food item with updated values.</param>
    void Actualizar(Alimento alimento);

    /// <summary>
    /// Deletes a food item by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the food item to delete.</param>
    void Eliminar(Guid id);
}