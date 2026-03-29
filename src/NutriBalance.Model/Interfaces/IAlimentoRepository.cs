using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Interfaces;

/// <summary>
/// Defines the contract for food data persistence operations.
/// </summary>
public interface IAlimentoRepository
{
    List<Alimento> ObtenerTodos();
    Alimento? ObtenerPorId(Guid id);
    void Agregar(Alimento alimento);
    void Actualizar(Alimento alimento);
    void Eliminar(Guid id);
}