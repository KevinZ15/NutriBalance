namespace NutriBalance.Model.Entities;

public class MenuDiarioDetalle
{
    /// <summary>
    /// Unique identifier of the menu detail item.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Identifier of the associated food item.
    /// </summary>
    public Guid AlimentoId { get; set; }

    /// <summary>
    /// Name of the food item.
    /// </summary>
    public string NombreAlimento { get; set; } = string.Empty;

    /// <summary>
    /// Number of units consumed.
    /// </summary>
    public decimal CantidadUnidades { get; set; }

    /// <summary>
    /// Grams per unit of the food item.
    /// </summary>
    public decimal GramosPorUnidad { get; set; }

    /// <summary>
    /// Total quantity in grams (units multiplied by grams per unit).
    /// </summary>
    public decimal Cantidad { get; set; }

    /// <summary>
    /// Total protein content for the consumed quantity.
    /// </summary>
    public decimal Proteinas { get; set; }

    /// <summary>
    /// Total fat content for the consumed quantity.
    /// </summary>
    public decimal Grasas { get; set; }

    /// <summary>
    /// Total carbohydrate content for the consumed quantity.
    /// </summary>
    public decimal Carbohidratos { get; set; }

    /// <summary>
    /// Total calorie content for the consumed quantity.
    /// </summary>
    public decimal Calorias { get; set; }
}