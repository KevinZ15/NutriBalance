using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

public class DietaEstandarStrategy : IDietaStrategy
{
    public string NombreDieta => "Estándar";

    public decimal CalcularProteinas(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.30m) / 4, 1);
    }

    public decimal CalcularGrasas(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.25m) / 9, 1);
    }

    public decimal CalcularCarbohidratos(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.45m) / 4, 1);
    }
}