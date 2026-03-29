using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.Controller;

public static class NutricionController
{
    /// <summary>
    /// Calculates the Body Mass Index (BMI) for a given user.
    /// </summary>
    /// <param name="usuario">The user whose BMI will be calculated.</param>
    /// <returns>The calculated BMI value.</returns>
    public static decimal CalcularIMC(Usuario usuario)
    {
        return NutricionCalculator.CalcularIMC(usuario.Peso, usuario.Estatura);
    }

    /// <summary>
    /// Classifies a BMI value into a health category.
    /// </summary>
    /// <param name="imc">The BMI value to classify.</param>
    /// <returns>A string representing the BMI classification.</returns>
    public static string ClasificarIMC(decimal imc)
    {
        return NutricionCalculator.ClasificarIMC(imc);
    }

    /// <summary>
    /// Calculates the target daily calorie intake for a user.
    /// </summary>
    /// <param name="usuario">The user whose calorie goal will be calculated.</param>
    /// <returns>The target daily calorie value.</returns>
    public static decimal CalcularCaloriasObjetivo(Usuario usuario)
    {
        return NutricionCalculator.CalcularCaloriasObjetivo(usuario);
    }

    /// <summary>
    /// Calculates macronutrient distribution based on the user's diet strategy.
    /// </summary>
    /// <param name="usuario">The user whose macronutrients will be calculated.</param>
    /// <returns>
    /// A tuple containing proteins, fats, carbohydrates, and the name of the diet.
    /// </returns>
    public static (decimal Proteinas, decimal Grasas, decimal Carbohidratos, string NombreDieta) CalcularMacros(Usuario usuario)
    {
        decimal calorias = NutricionCalculator.CalcularCaloriasObjetivo(usuario);
        IDietaStrategy estrategia = NutricionCalculator.ObtenerEstrategia(usuario.TipoDieta);

        return (
            estrategia.CalcularProteinas(calorias),
            estrategia.CalcularGrasas(calorias),
            estrategia.CalcularCarbohidratos(calorias),
            estrategia.NombreDieta
        );
    }
}