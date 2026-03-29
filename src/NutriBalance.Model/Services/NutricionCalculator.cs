using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

public static class NutricionCalculator
{
    public static decimal CalcularIMC(decimal pesoKg, decimal estaturaCm)
    {
        decimal estaturaM = estaturaCm / 100m;
        return Math.Round(pesoKg / (estaturaM * estaturaM), 2);
    }

    public static string ClasificarIMC(decimal imc)
    {
        if (imc < 18.5m) return "Bajo peso";
        if (imc < 25.0m) return "Peso normal";
        if (imc < 30.0m) return "Sobrepeso";
        return "Obesidad";
    }

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