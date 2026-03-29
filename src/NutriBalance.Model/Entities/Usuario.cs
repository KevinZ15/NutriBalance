using NutriBalance.Model.Enums;

namespace NutriBalance.Model.Entities;

public class Usuario
{
    /// <summary>
    /// Unique identifier of the user.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Username used for authentication.
    /// </summary>
    public string NombreUsuario { get; set; } = string.Empty;

    /// <summary>
    /// User password.
    /// </summary>
    public string Contrasena { get; set; } = string.Empty;

    /// <summary>
    /// Full name of the user.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    /// User weight (typically in kilograms).
    /// </summary>
    public decimal Peso { get; set; }

    /// <summary>
    /// User height (typically in meters).
    /// </summary>
    public decimal Estatura { get; set; }

    /// <summary>
    /// Level of physical activity of the user.
    /// </summary>
    public NivelActividad NivelActividad { get; set; }

    /// <summary>
    /// User's goal (e.g., maintain, lose fat, gain mass).
    /// </summary>
    public ObjetivoUsuario Objetivo { get; set; }

    /// <summary>
    /// Type of diet selected by the user.
    /// </summary>
    public TipoDieta TipoDieta { get; set; }
}