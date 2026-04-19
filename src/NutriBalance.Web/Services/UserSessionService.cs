using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;

namespace NutriBalance.Web.Services;

public class UserSessionService
{
    public Usuario? UsuarioAutenticado { get; private set; }

    public bool HaySesionActiva() => UsuarioAutenticado is not null;

    public bool EsAdmin() =>
        UsuarioAutenticado?.Rol == RolUsuario.Admin;

    public void IniciarSesion(Usuario usuario)
    {
        UsuarioAutenticado = usuario;
    }

    public void ActualizarUsuario(Usuario usuario)
    {
        UsuarioAutenticado = usuario;
    }

    public void CerrarSesion()
    {
        UsuarioAutenticado = null;
    }
}