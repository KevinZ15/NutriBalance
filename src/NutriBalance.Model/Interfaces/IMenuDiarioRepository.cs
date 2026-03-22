using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Interfaces;

public interface IMenuDiarioRepository
{
    List<MenuDiario> ObtenerTodos();
    MenuDiario? ObtenerPorId(Guid id);
    MenuDiario? ObtenerPorUsuarioYFecha(Guid usuarioId, DateTime fecha);
    void Agregar(MenuDiario menu);
    void Actualizar(MenuDiario menu);
    void Eliminar(Guid id);
}