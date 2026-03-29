using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Interfaces;

/// <summary>
/// Defines the contract for user data persistence and authentication operations.
/// </summary>
public interface IUsuarioRepository
{
    List<Usuario> ObtenerTodos();
    Usuario? ObtenerPorId(Guid id);
    Usuario? ObtenerPorCredenciales(string nombreUsuario, string contrasena);
    Usuario? ObtenerPorNombreUsuario(string nombreUsuario);
    void Agregar(Usuario usuario);
    void Actualizar(Usuario usuario);
}