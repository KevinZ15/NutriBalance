using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;

namespace NutriBalance.Web.Services;

/// <summary>
/// Manages the authenticated user session in memory.
/// </summary>
public class UserSessionService
{
    /// <summary>
    /// Gets the currently authenticated user, or <c>null</c> if no session is active.
    /// </summary>
    public Usuario? UsuarioAutenticado { get; private set; }

    /// <summary>
    /// Determines whether a user session is currently active.
    /// </summary>
    /// <returns><c>true</c> if a session is active; otherwise, <c>false</c>.</returns>
    public bool HaySesionActiva() => UsuarioAutenticado is not null;

    /// <summary>
    /// Determines whether the authenticated user has the admin role.
    /// </summary>
    /// <returns><c>true</c> if the user is an admin; otherwise, <c>false</c>.</returns>
    public bool EsAdmin() =>
        UsuarioAutenticado?.Rol == RolUsuario.Admin;

    /// <summary>
    /// Starts a session for the specified user.
    /// </summary>
    /// <param name="usuario">The user to authenticate.</param>
    public void IniciarSesion(Usuario usuario)
    {
        UsuarioAutenticado = usuario;
    }

    /// <summary>
    /// Updates the authenticated user with new data.
    /// </summary>
    /// <param name="usuario">The updated user data.</param>
    public void ActualizarUsuario(Usuario usuario)
    {
        UsuarioAutenticado = usuario;
    }

    /// <summary>
    /// Ends the current user session.
    /// </summary>
    public void CerrarSesion()
    {
        UsuarioAutenticado = null;
    }
}