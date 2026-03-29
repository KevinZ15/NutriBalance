using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

public class DietaKetoStrategy : IDietaStrategy
{
    public string NombreDieta => "Keto";

    public decimal CalcularProteinas(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.25m) / 4, 1);
    }

    public decimal CalcularGrasas(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.70m) / 9, 1);
    }

    public decimal CalcularCarbohidratos(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.05m) / 4, 1);
    }
}