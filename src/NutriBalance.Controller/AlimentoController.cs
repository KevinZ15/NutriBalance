using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.Controller;

/// <summary>
/// Handles food item operations using the specified repository.
/// </summary>
public class AlimentoController(IAlimentoRepository alimentoRepository)
{
    private readonly IAlimentoRepository _alimentoRepository = alimentoRepository;

    /// <summary>
    /// Registers a new food item after calculating its calories and validating it.
    /// </summary>
    /// <param name="alimento">The food item to register.</param>
    /// <returns>A tuple indicating success and a result message.</returns>
    public (bool Exito, string Mensaje) RegistrarAlimento(Alimento alimento)
    {
        alimento.Calorias = AlimentoCalculator.CalcularCalorias(
            alimento.Proteinas,
            alimento.Carbohidratos,
            alimento.Grasas
        );

        List<string> errores = AlimentoValidator.Validar(alimento);

        if (errores.Count > 0)
        {
            return (false, string.Join(Environment.NewLine, errores));
        }

        _alimentoRepository.Agregar(alimento);
        return (true, "Alimento registrado correctamente.");
    }

    /// <summary>
    /// Gets all registered food items.
    /// </summary>
    /// <returns>A list of all food items.</returns>
    public List<Alimento> ObtenerTodos()
    {
        return _alimentoRepository.ObtenerTodos();
    }

    /// <summary>
    /// Gets a food item by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the food item.</param>
    /// <returns>The matching food item, or <c>null</c> if not found.</returns>
    public Alimento? ObtenerPorId(Guid id)
    {
        return _alimentoRepository.ObtenerPorId(id);
    }

    /// <summary>
    /// Updates an existing food item after recalculating its calories and validating it.
    /// </summary>
    /// <param name="alimento">The food item with updated values.</param>
    /// <returns>A tuple indicating success and a result message.</returns>
    public (bool Exito, string Mensaje) ActualizarAlimento(Alimento alimento)
    {
        alimento.Calorias = AlimentoCalculator.CalcularCalorias(
            alimento.Proteinas,
            alimento.Carbohidratos,
            alimento.Grasas
        );

        List<string> errores = AlimentoValidator.Validar(alimento);

        if (errores.Count > 0)
        {
            return (false, string.Join(Environment.NewLine, errores));
        }

        _alimentoRepository.Actualizar(alimento);
        return (true, "Alimento actualizado correctamente.");
    }

    /// <summary>
    /// Deletes a food item by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the food item to delete.</param>
    /// <returns>A tuple indicating success and a result message.</returns>
    public (bool Exito, string Mensaje) EliminarAlimento(Guid id)
    {
        Alimento? alimento = _alimentoRepository.ObtenerPorId(id);

        if (alimento is null)
        {
            return (false, "El alimento no existe.");
        }

        _alimentoRepository.Eliminar(id);
        return (true, "Alimento eliminado correctamente.");
    }
}