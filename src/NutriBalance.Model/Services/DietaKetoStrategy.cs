using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

/// <summary>
/// Ketogenic diet strategy for macronutrient calculation.
/// </summary>
public class DietaKetoStrategy : IDietaStrategy
{
    /// <summary>
    /// Gets the name of the diet.
    /// </summary>
    public string NombreDieta => "Keto";

    /// <summary>
    /// Calculates the protein intake based on the calorie goal.
    /// </summary>
    /// <param name="caloriasObjetivo">The target daily calories.</param>
    /// <returns>The amount of protein in grams.</returns>
    public decimal CalcularProteinas(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.25m) / 4, 1);
    }

    /// <summary>
    /// Calculates the fat intake based on the calorie goal.
    /// </summary>
    /// <param name="caloriasObjetivo">The target daily calories.</param>
    /// <returns>The amount of fat in grams.</returns>
    public decimal CalcularGrasas(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.70m) / 9, 1);
    }

    /// <summary>
    /// Calculates the carbohydrate intake based on the calorie goal.
    /// </summary>
    /// <param name="caloriasObjetivo">The target daily calories.</param>
    /// <returns>The amount of carbohydrates in grams.</returns>
    public decimal CalcularCarbohidratos(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.05m) / 4, 1);
    }
}