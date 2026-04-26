using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Interfaces;

/// <summary>
/// Defines the contract for user data persistence operations.
/// </summary>
public interface IUsuarioRepository
{
    /// <summary>
    /// Gets all registered users.
    /// </summary>
    /// <returns>A list of all users.</returns>
    List<Usuario> ObtenerTodos();

    /// <summary>
    /// Gets a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <returns>The matching user, or <c>null</c> if not found.</returns>
    Usuario? ObtenerPorId(Guid id);

    /// <summary>
    /// Gets a user by their credentials.
    /// </summary>
    /// <param name="nombreUsuario">The username.</param>
    /// <param name="contrasena">The password.</param>
    /// <returns>The matching user, or <c>null</c> if credentials are invalid.</returns>
    Usuario? ObtenerPorCredenciales(string nombreUsuario, string contrasena);

    /// <summary>
    /// Gets a user by their username.
    /// </summary>
    /// <param name="nombreUsuario">The username to search for.</param>
    /// <returns>The matching user, or <c>null</c> if not found.</returns>
    Usuario? ObtenerPorNombreUsuario(string nombreUsuario);

    /// <summary>
    /// Adds a new user.
    /// </summary>
    /// <param name="usuario">The user to add.</param>
    void Agregar(Usuario usuario);

    /// <summary>
    /// Updates an existing user.
    /// </summary>
    /// <param name="usuario">The user with updated values.</param>
    void Actualizar(Usuario usuario);

    /// <summary>
    /// Deletes a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user to delete.</param>
    void Eliminar(Guid id);

    /// <summary>
    /// Deactivates a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user to deactivate.</param>
    void DesactivarUsuario(Guid id);

    /// <summary>
    /// Resets the password for the specified user.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <param name="nuevaContrasena">The new password to set.</param>
    void ResetearContrasena(Guid id, string nuevaContrasena);
}