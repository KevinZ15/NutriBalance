using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.Controller;

/// <summary>
/// Handles user account operations using the specified repository.
/// </summary>
public class UsuarioController(IUsuarioRepository usuarioRepository)
{
    private readonly IUsuarioRepository _usuarioRepository = usuarioRepository;

    /// <summary>
    /// Gets the currently authenticated user.
    /// </summary>
    public Usuario? UsuarioAutenticado { get; private set; }

    /// <summary>
    /// Registers a new user after validating their data.
    /// </summary>
    /// <param name="usuario">The user to register.</param>
    /// <returns>A tuple indicating success and a result message.</returns>
    public (bool Exito, string Mensaje) RegistrarUsuario(Usuario usuario)
    {
        List<string> errores = UsuarioValidator.Validar(usuario);
        if (errores.Count > 0)
            return (false, string.Join(Environment.NewLine, errores));

        if (_usuarioRepository.ObtenerPorNombreUsuario(usuario.NombreUsuario) is not null)
            return (false, "El nombre de usuario ya existe.");

        _usuarioRepository.Agregar(usuario);
        return (true, "Usuario registrado correctamente.");
    }

    /// <summary>
    /// Authenticates a user with the provided credentials.
    /// </summary>
    /// <param name="nombreUsuario">The username.</param>
    /// <param name="contrasena">The password.</param>
    /// <returns>A tuple indicating success and a result message.</returns>
    public (bool Exito, string Mensaje) IniciarSesion(string nombreUsuario, string contrasena)
    {
        if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            return (false, "Debe ingresar usuario y contraseña.");

        Usuario? usuario = _usuarioRepository.ObtenerPorCredenciales(nombreUsuario, contrasena);
        if (usuario is null)
            return (false, "Usuario o contraseña incorrectos.");

        UsuarioAutenticado = usuario;
        return (true, "Inicio de sesión correcto.");
    }

    /// <summary>
    /// Updates the profile of an existing user.
    /// </summary>
    /// <param name="usuario">The user with updated values.</param>
    /// <returns>A tuple indicating success and a result message.</returns>
    public (bool Exito, string Mensaje) ActualizarPerfil(Usuario usuario)
    {
        List<string> errores = UsuarioValidator.Validar(usuario);
        if (errores.Count > 0)
            return (false, string.Join(Environment.NewLine, errores));

        var existente = _usuarioRepository.ObtenerPorNombreUsuario(usuario.NombreUsuario);
        if (existente is not null && existente.Id != usuario.Id)
            return (false, "El nombre de usuario ya existe.");

        _usuarioRepository.Actualizar(usuario);

        if (UsuarioAutenticado?.Id == usuario.Id)
            UsuarioAutenticado = usuario;

        return (true, "Perfil actualizado correctamente.");
    }

    /// <summary>
    /// Gets all registered users.
    /// </summary>
    /// <returns>A list of all users.</returns>
    public List<Usuario> ObtenerTodosLosUsuarios() =>
        _usuarioRepository.ObtenerTodos();

    /// <summary>
    /// Resets the password for the specified user.
    /// </summary>
    /// <param name="usuarioId">The unique identifier of the user.</param>
    /// <param name="nuevaContrasena">The new password to set.</param>
    /// <returns>A tuple indicating success and a result message.</returns>
    public (bool Exito, string Mensaje) ResetearContrasena(Guid usuarioId, string nuevaContrasena)
    {
        if (string.IsNullOrWhiteSpace(nuevaContrasena) || nuevaContrasena.Length < 6)
            return (false, "La contraseña debe tener al menos 6 caracteres.");

        var usuario = _usuarioRepository.ObtenerPorId(usuarioId);
        if (usuario is null)
            return (false, "Usuario no encontrado.");

        _usuarioRepository.ResetearContrasena(usuarioId, nuevaContrasena);
        return (true, "Contraseña reseteada correctamente.");
    }

    /// <summary>
    /// Deactivates a non-admin user by their unique identifier.
    /// </summary>
    /// <param name="usuarioId">The unique identifier of the user to deactivate.</param>
    /// <returns>A tuple indicating success and a result message.</returns>
    public (bool Exito, string Mensaje) DesactivarUsuario(Guid usuarioId)
    {
        var usuario = _usuarioRepository.ObtenerPorId(usuarioId);
        if (usuario is null)
            return (false, "Usuario no encontrado.");

        if (usuario.Rol == NutriBalance.Model.Enums.RolUsuario.Admin)
            return (false, "No se puede desactivar a un administrador.");

        _usuarioRepository.DesactivarUsuario(usuarioId);
        return (true, "Usuario desactivado correctamente.");
    }

    /// <summary>
    /// Deletes a non-admin user by their unique identifier.
    /// </summary>
    /// <param name="usuarioId">The unique identifier of the user to delete.</param>
    /// <returns>A tuple indicating success and a result message.</returns>
    public (bool Exito, string Mensaje) EliminarUsuario(Guid usuarioId)
    {
        var usuario = _usuarioRepository.ObtenerPorId(usuarioId);
        if (usuario is null)
            return (false, "Usuario no encontrado.");

        if (usuario.Rol == NutriBalance.Model.Enums.RolUsuario.Admin)
            return (false, "No se puede eliminar a un administrador.");

        _usuarioRepository.Eliminar(usuarioId);
        return (true, "Usuario eliminado correctamente.");
    }
}