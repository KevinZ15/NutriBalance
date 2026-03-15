using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Services;

public static class UsuarioValidator
{
    public static List<string> Validar(Usuario usuario)
    {
        List<string> errores = new();

        if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
        {
            errores.Add("El nombre de usuario es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(usuario.Contrasena))
        {
            errores.Add("La contraseña es obligatoria.");
        }

        if (string.IsNullOrWhiteSpace(usuario.Nombre))
        {
            errores.Add("El nombre es obligatorio.");
        }

        if (usuario.Peso <= 0)
        {
            errores.Add("El peso debe ser mayor a cero.");
        }

        if (usuario.Estatura <= 0)
        {
            errores.Add("La estatura debe ser mayor a cero.");
        }

        return errores;
    }
}