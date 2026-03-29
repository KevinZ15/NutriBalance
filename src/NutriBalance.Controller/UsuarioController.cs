using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.Controller;

public class UsuarioController(IUsuarioRepository usuarioRepository)
{
    private readonly IUsuarioRepository _usuarioRepository = usuarioRepository;

    /// <summary>
    /// Gets the currently authenticated user.
    /// </summary>
    public Usuario? UsuarioAutenticado { get; private set; }

    /// <summary>
    /// Registers a new user after validating the input data and ensuring username uniqueness.
    /// </summary>
    /// <param name="usuario">The user entity to be registered.</param>
    /// <returns>
    /// A tuple indicating whether the registration was successful and a message describing the result.
    /// </returns>
    public (bool Exito, string Mensaje) RegistrarUsuario(Usuario usuario)
    {
        List<string> errores = UsuarioValidator.Validar(usuario);

        if (errores.Count > 0)
        {
            return (false, string.Join(Environment.NewLine, errores));
        }

        Usuario? usuarioExistente = _usuarioRepository.ObtenerPorNombreUsuario(usuario.NombreUsuario);

        if (usuarioExistente is not null)
        {
            return (false, "El nombre de usuario ya existe.");
        }

        _usuarioRepository.Agregar(usuario);

        return (true, "Usuario registrado correctamente.");
    }

    /// <summary>
    /// Authenticates a user using the provided username and password.
    /// </summary>
    /// <param name="nombreUsuario">The username.</param>
    /// <param name="contrasena">The password.</param>
    /// <returns>
    /// A tuple indicating whether authentication was successful and a message describing the result.
    /// </returns>
    public (bool Exito, string Mensaje) IniciarSesion(string nombreUsuario, string contrasena)
    {
        if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
        {
            return (false, "Debe ingresar usuario y contraseña.");
        }

        Usuario? usuario = _usuarioRepository.ObtenerPorCredenciales(nombreUsuario, contrasena);

        if (usuario is null)
        {
            return (false, "Usuario o contraseña incorrectos.");
        }

        UsuarioAutenticado = usuario;
        return (true, "Inicio de sesión correcto.");
    }

    /// <summary>
    /// Updates the user's profile after validation and username uniqueness check.
    /// </summary>
    /// <param name="usuario">The user entity with updated information.</param>
    /// <returns>
    /// A tuple indicating whether the update was successful and a message describing the result.
    /// </returns>
    public (bool Exito, string Mensaje) ActualizarPerfil(Usuario usuario)
    {
        List<string> errores = UsuarioValidator.Validar(usuario);

        if (errores.Count > 0)
        {
            return (false, string.Join(Environment.NewLine, errores));
        }

        Usuario? usuarioConMismoNombre = _usuarioRepository.ObtenerPorNombreUsuario(usuario.NombreUsuario);

        if (usuarioConMismoNombre is not null && usuarioConMismoNombre.Id != usuario.Id)
        {
            return (false, "El nombre de usuario ya existe.");
        }

        _usuarioRepository.Actualizar(usuario);

        if (UsuarioAutenticado is not null && UsuarioAutenticado.Id == usuario.Id)
        {
            UsuarioAutenticado = usuario;
        }

        return (true, "Perfil actualizado correctamente.");
    }
}