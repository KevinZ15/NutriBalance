namespace NutriBalance.Model.Interfaces;

public interface IDietaStrategy
{
    string NombreDieta { get; }
    decimal CalcularProteinas(decimal caloriasObjetivo);
    decimal CalcularGrasas(decimal caloriasObjetivo);
    decimal CalcularCarbohidratos(decimal caloriasObjetivo);
}