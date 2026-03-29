using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.Controller;

public class AlimentoController(IAlimentoRepository alimentoRepository)
{
    private readonly IAlimentoRepository _alimentoRepository = alimentoRepository;

    /// <summary>
    /// Registers a new food item after validating its data.
    /// </summary>
    /// <param name="alimento">The food entity to be registered.</param>
    /// <returns>
    /// A tuple indicating whether the operation was successful and a message describing the result.
    /// </returns>
    public (bool Exito, string Mensaje) RegistrarAlimento(Alimento alimento)
    {
        List<string> errores = AlimentoValidator.Validar(alimento);

        if (errores.Count > 0)
        {
            return (false, string.Join(Environment.NewLine, errores));
        }

        _alimentoRepository.Agregar(alimento);
        return (true, "Alimento registrado correctamente.");
    }

    /// <summary>
    /// Retrieves all registered food items.
    /// </summary>
    /// <returns>A list of all food entities.</returns>
    public List<Alimento> ObtenerTodos()
    {
        return _alimentoRepository.ObtenerTodos();
    }

    /// <summary>
    /// Retrieves a food item by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the food.</param>
    /// <returns>The food entity if found; otherwise, null.</returns>
    public Alimento? ObtenerPorId(Guid id)
    {
        return _alimentoRepository.ObtenerPorId(id);
    }

    /// <summary>
    /// Updates an existing food item after validating its data.
    /// </summary>
    /// <param name="alimento">The food entity with updated information.</param>
    /// <returns>
    /// A tuple indicating whether the update was successful and a message describing the result.
    /// </returns>
    public (bool Exito, string Mensaje) ActualizarAlimento(Alimento alimento)
    {
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
    /// <param name="id">The unique identifier of the food to delete.</param>
    /// <returns>
    /// A tuple indicating whether the deletion was successful and a message describing the result.
    /// </returns>
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