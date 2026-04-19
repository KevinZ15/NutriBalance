using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.Controller;

public class UsuarioController(IUsuarioRepository usuarioRepository)
{
    private readonly IUsuarioRepository _usuarioRepository = usuarioRepository;

    public Usuario? UsuarioAutenticado { get; private set; }

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

    public List<Usuario> ObtenerTodosLosUsuarios() =>
        _usuarioRepository.ObtenerTodos();

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