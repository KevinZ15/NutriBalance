using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Services;

public static class AlimentoValidator
{
    public static List<string> Validar(Alimento alimento)
    {
        List<string> errores = new();

        if (string.IsNullOrWhiteSpace(alimento.Nombre))
        {
            errores.Add("El nombre del alimento es obligatorio.");
        }

        if (alimento.Porcion <= 0)
        {
            errores.Add("La porción debe ser mayor a cero.");
        }

        if (alimento.Calorias < 0)
        {
            errores.Add("Las calorías no pueden ser negativas.");
        }

        if (alimento.Proteinas < 0)
        {
            errores.Add("Las proteínas no pueden ser negativas.");
        }

        if (alimento.Carbohidratos < 0)
        {
            errores.Add("Los carbohidratos no pueden ser negativos.");
        }

        if (alimento.Grasas < 0)
        {
            errores.Add("Las grasas no pueden ser negativas.");
        }

        return errores;
    }
}