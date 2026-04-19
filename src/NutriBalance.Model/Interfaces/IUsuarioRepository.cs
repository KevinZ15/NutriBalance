using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Interfaces;

public interface IUsuarioRepository
{
    List<Usuario> ObtenerTodos();
    Usuario? ObtenerPorId(Guid id);
    Usuario? ObtenerPorCredenciales(string nombreUsuario, string contrasena);
    Usuario? ObtenerPorNombreUsuario(string nombreUsuario);
    void Agregar(Usuario usuario);
    void Actualizar(Usuario usuario);
    void Eliminar(Guid id);
    void DesactivarUsuario(Guid id);
    void ResetearContrasena(Guid id, string nuevaContrasena);
}