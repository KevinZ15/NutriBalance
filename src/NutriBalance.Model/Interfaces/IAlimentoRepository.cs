using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Interfaces;

public interface IAlimentoRepository
{
    List<Alimento> ObtenerTodos();
    Alimento? ObtenerPorId(Guid id);
    void Agregar(Alimento alimento);
    void Actualizar(Alimento alimento);
    void Eliminar(Guid id);
}