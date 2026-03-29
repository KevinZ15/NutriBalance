namespace NutriBalance.Model.Entities;

public class Alimento
{
    /// <summary>
    /// Unique identifier of the food item.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Name of the food item.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    /// Portion size of the food (e.g., grams or units).
    /// </summary>
    public decimal Porcion { get; set; }

    /// <summary>
    /// Total calories for the specified portion.
    /// </summary>
    public decimal Calorias { get; set; }

    /// <summary>
    /// Protein content for the specified portion.
    /// </summary>
    public decimal Proteinas { get; set; }

    /// <summary>
    /// Carbohydrate content for the specified portion.
    /// </summary>
    public decimal Carbohidratos { get; set; }

    /// <summary>
    /// Fat content for the specified portion.
    /// </summary>
    public decimal Grasas { get; set; }

    /// <summary>
    /// Indicates whether the food is suitable for a keto diet.
    /// </summary>
    public bool EsKeto { get; set; }

    /// <summary>
    /// Indicates whether the food is suitable for a vegetarian diet.
    /// </summary>
    public bool EsVegetariano { get; set; }

    /// <summary>
    /// Indicates whether the food is suitable for a standard diet.
    /// </summary>
    public bool EsEstandar { get; set; }
}