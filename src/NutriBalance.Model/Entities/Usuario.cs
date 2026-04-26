using NutriBalance.Model.Enums;

namespace NutriBalance.Model.Entities;

/// <summary>
/// Represents a user in the system.
/// </summary>
public class Usuario
{
    /// <summary>
    /// Gets or sets the unique identifier of the user.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Gets or sets the username.
    /// </summary>
    public string NombreUsuario { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    public string Contrasena { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the full name of the user.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the weight of the user in kilograms.
    /// </summary>
    public decimal Peso { get; set; }

    /// <summary>
    /// Gets or sets the height of the user in meters.
    /// </summary>
    public decimal Estatura { get; set; }

    /// <summary>
    /// Gets or sets the physical activity level of the user.
    /// </summary>
    public NivelActividad NivelActividad { get; set; }

    /// <summary>
    /// Gets or sets the nutritional goal of the user.
    /// </summary>
    public ObjetivoUsuario Objetivo { get; set; }

    /// <summary>
    /// Gets or sets the diet type assigned to the user.
    /// </summary>
    public TipoDieta TipoDieta { get; set; }

    /// <summary>
    /// Gets or sets the role of the user.
    /// </summary>
    public RolUsuario Rol { get; set; } = RolUsuario.Usuario;

    /// <summary>
    /// Gets or sets a value indicating whether the user account is active.
    /// </summary>
    public bool Activo { get; set; } = true;
}