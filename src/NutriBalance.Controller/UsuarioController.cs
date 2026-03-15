using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.Controller;

public class UsuarioController
{
    private readonly IUsuarioRepository _usuarioRepository;

    public Usuario? UsuarioAutenticado { get; private set; }

    public UsuarioController(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

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