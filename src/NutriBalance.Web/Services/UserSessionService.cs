using NutriBalance.Model.Entities;

namespace NutriBalance.Web.Services;

public class UserSessionService
{
    public Usuario? UsuarioAutenticado { get; private set; }

    public bool HaySesionActiva()
    {
        return UsuarioAutenticado is not null;
    }

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