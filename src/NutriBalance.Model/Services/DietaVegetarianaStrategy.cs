using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

public class DietaVegetarianaStrategy : IDietaStrategy
{
    public string NombreDieta => "Vegetariana";

    public decimal CalcularProteinas(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.20m) / 4, 1);
    }

    public decimal CalcularGrasas(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.30m) / 9, 1);
    }

    public decimal CalcularCarbohidratos(decimal caloriasObjetivo)
    {
        return Math.Round((caloriasObjetivo * 0.50m) / 4, 1);
    }
}