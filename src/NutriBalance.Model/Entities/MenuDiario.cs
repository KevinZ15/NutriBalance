namespace NutriBalance.Model.Entities;

public class MenuDiario
{
    /// <summary>
    /// Unique identifier of the daily menu.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Identifier of the user associated with this menu.
    /// </summary>
    public Guid UsuarioId { get; set; }

    /// <summary>
    /// Date of the menu.
    /// </summary>
    public DateTime Fecha { get; set; }

    /// <summary>
    /// Collection of food items included in the daily menu.
    /// </summary>
    public List<MenuDiarioDetalle> Detalles { get; set; } = new();
}