using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.Controller;

public class NutricionController
{
    public decimal CalcularIMC(Usuario usuario)
    {
        return NutricionCalculator.CalcularIMC(usuario.Peso, usuario.Estatura);
    }

    public string ClasificarIMC(decimal imc)
    {
        return NutricionCalculator.ClasificarIMC(imc);
    }

    public decimal CalcularCaloriasObjetivo(Usuario usuario)
    {
        return NutricionCalculator.CalcularCaloriasObjetivo(usuario);
    }

    public (decimal Proteinas, decimal Grasas, decimal Carbohidratos, string NombreDieta) CalcularMacros(Usuario usuario)
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