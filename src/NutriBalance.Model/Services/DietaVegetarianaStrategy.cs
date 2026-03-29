using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

/// <summary>
/// Vegetarian diet strategy for macronutrient calculation.
/// </summary>
public class DietaVegetarianaStrategy : IDietaStrategy
{
    /// <summary>
    /// Gets the name of the diet.
    /// </summary>
    public string NombreDieta => "Vegetariana";

    /// <summary>
    /// Calculates the protein intake based on the calorie goal.
    /// </summary>
    /// <param name="caloriasObjetivo">The target daily calories.</param>
    /// <returns>The amount of protein in grams.</returns>
    public decimal CalcularProteinas(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.20m) / 4, 1);
    }

    /// <summary>
    /// Calculates the fat intake based on the calorie goal.
    /// </summary>
    /// <param name="caloriasObjetivo">The target daily calories.</param>
    /// <returns>The amount of fat in grams.</returns>
    public decimal CalcularGrasas(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.30m) / 9, 1);
    }

    /// <summary>
    /// Calculates the carbohydrate intake based on the calorie goal.
    /// </summary>
    /// <param name="caloriasObjetivo">The target daily calories.</param>
    /// <returns>The amount of carbohydrates in grams.</returns>
    public decimal CalcularCarbohidratos(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.50m) / 4, 1);
    }
}