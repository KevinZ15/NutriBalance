using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

/// <summary>
/// Provides nutritional calculations such as BMI, calorie goals, and diet strategies.
/// </summary>
public static class NutricionCalculator
{
    /// <summary>
    /// Calculates the Body Mass Index (BMI) using weight and height.
    /// </summary>
    /// <param name="pesoKg">Weight in kilograms.</param>
    /// <param name="estaturaCm">Height in centimeters.</param>
    /// <returns>The calculated BMI value.</returns>
    public static decimal CalcularIMC(decimal pesoKg, decimal estaturaCm)
    {
        decimal estaturaM = estaturaCm / 100m;
        return Math.Round(pesoKg / (estaturaM * estaturaM), 2);
    }

    /// <summary>
    /// Classifies a BMI value into a health category.
    /// </summary>
    /// <param name="imc">The BMI value to classify.</param>
    /// <returns>A string representing the BMI classification.</returns>
    public static string ClasificarIMC(decimal imc)
    {
        if (imc < 18.5m) return "Bajo peso";
        if (imc < 25.0m) return "Peso normal";
        if (imc < 30.0m) return "Sobrepeso";
        return "Obesidad";
    }

    /// <summary>
    /// Calculates the target daily calorie intake based on user data.
    /// </summary>
    /// <param name="usuario">The user whose calorie goal will be calculated.</param>
    /// <returns>The target daily calorie value.</returns>
    public static decimal CalcularCaloriasObjetivo(Usuario usuario)
    {
        decimal tmb = (10 * usuario.Peso) + (6.25m * usuario.Estatura) - (5 * 25) + 5;

        decimal factor = usuario.NivelActividad switch
        {
            NivelActividad.Sedentario => 1.2m,
            NivelActividad.Ligero => 1.375m,
            NivelActividad.Moderado => 1.55m,
            NivelActividad.Alto => 1.725m,
            _ => 1.2m
        };

        decimal caloriasMantenimiento = Math.Round(tmb * factor, 0);

        decimal caloriasObjetivo = usuario.Objetivo switch
        {
            ObjetivoUsuario.PerderGrasa => Math.Round(caloriasMantenimiento - 500, 0),
            ObjetivoUsuario.GanarMasa => Math.Round(caloriasMantenimiento + 300, 0),
            _ => caloriasMantenimiento
        };

        return caloriasObjetivo;
    }

    /// <summary>
    /// Returns the diet strategy based on the selected diet type.
    /// </summary>
    /// <param name="tipoDieta">The selected diet type.</param>
    /// <returns>An implementation of the diet strategy.</returns>
    public static IDietaStrategy ObtenerEstrategia(TipoDieta tipoDieta)
    {
        return tipoDieta switch
        {
            TipoDieta.Keto => new DietaKetoStrategy(),
            TipoDieta.Vegetariana => new DietaVegetarianaStrategy(),
            _ => new DietaEstandarStrategy()
        };
    }
}