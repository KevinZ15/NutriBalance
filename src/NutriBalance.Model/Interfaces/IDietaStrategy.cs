namespace NutriBalance.Model.Interfaces;

/// <summary>
/// Defines the contract for diet strategies used to calculate macronutrient distribution.
/// </summary>
public interface IDietaStrategy
{
    /// <summary>
    /// Gets the name of the diet strategy.
    /// </summary>
    string NombreDieta { get; }

    /// <summary>
    /// Calculates the daily protein intake based on the target calories.
    /// </summary>
    /// <param name="caloriasObjetivo">The target daily calories.</param>
    /// <returns>The recommended protein intake in grams.</returns>
    decimal CalcularProteinas(decimal caloriasObjetivo);

    /// <summary>
    /// Calculates the daily fat intake based on the target calories.
    /// </summary>
    /// <param name="caloriasObjetivo">The target daily calories.</param>
    /// <returns>The recommended fat intake in grams.</returns>
    decimal CalcularGrasas(decimal caloriasObjetivo);

    /// <summary>
    /// Calculates the daily carbohydrate intake based on the target calories.
    /// </summary>
    /// <param name="caloriasObjetivo">The target daily calories.</param>
    /// <returns>The recommended carbohydrate intake in grams.</returns>
    decimal CalcularCarbohidratos(decimal caloriasObjetivo);
}