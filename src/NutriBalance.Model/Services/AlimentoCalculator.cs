namespace NutriBalance.Model.Services;

/// <summary>
/// Provides calorie calculation utilities for food items.
/// </summary>
public static class AlimentoCalculator
{
    /// <summary>
    /// Calculates the total calories based on macronutrient amounts.
    /// </summary>
    /// <param name="proteinas">The amount of protein in grams.</param>
    /// <param name="carbohidratos">The amount of carbohydrates in grams.</param>
    /// <param name="grasas">The amount of fat in grams.</param>
    /// <returns>The total calculated calories.</returns>
    public static decimal CalcularCalorias(decimal proteinas, decimal carbohidratos, decimal grasas)
    {
        return (proteinas * 4) + (carbohidratos * 4) + (grasas * 9);
    }
}