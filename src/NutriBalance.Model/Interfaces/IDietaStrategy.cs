namespace NutriBalance.Model.Interfaces;

/// <summary>
/// Defines the contract for diet strategies used to calculate macronutrient distribution.
/// </summary>
public interface IDietaStrategy
{
    string NombreDieta { get; }
    decimal CalcularProteinas(decimal caloriasObjetivo);
    decimal CalcularGrasas(decimal caloriasObjetivo);
    decimal CalcularCarbohidratos(decimal caloriasObjetivo);
}