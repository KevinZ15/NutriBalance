namespace NutriBalance.Web.Services;

/// <summary>
/// Holds shared state across the multi-step user registration flow.
/// </summary>
public class RegistroUsuarioState
{
    /// <summary>
    /// Gets or sets the username entered in step 1.
    /// </summary>
    public string NombreUsuario { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the full name entered in step 1.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password entered in step 1.
    /// </summary>
    public string Contrasena { get; set; } = string.Empty;

    /// <summary>
    /// Determines whether all required step 1 fields have been filled.
    /// </summary>
    /// <returns><c>true</c> if step 1 data is complete; otherwise, <c>false</c>.</returns>
    public bool HayDatosPaso1()
    {
        return !string.IsNullOrWhiteSpace(NombreUsuario)
            && !string.IsNullOrWhiteSpace(Nombre)
            && !string.IsNullOrWhiteSpace(Contrasena);
    }

    /// <summary>
    /// Clears all registration state data.
    /// </summary>
    public void Limpiar()
    {
        NombreUsuario = string.Empty;
        Nombre = string.Empty;
        Contrasena = string.Empty;
    }
}