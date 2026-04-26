using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Services;

/// <summary>
/// Provides validation rules for user entities.
/// </summary>
public static class UsuarioValidator
{
    /// <summary>
    /// Validates a user entity and returns a list of validation errors.
    /// </summary>
    /// <param name="usuario">The user entity to validate.</param>
    /// <returns>A list of validation error messages. Empty if valid.</returns>
    public static List<string> Validar(Usuario usuario)
    {
        List<string> errores = [];

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