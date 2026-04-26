using NutriBalance.Model.Entities;

namespace NutriBalance.Model.Services;

/// <summary>
/// Provides validation rules for food entities.
/// </summary>
public static class AlimentoValidator
{
    /// <summary>
    /// Validates a food entity and returns a list of validation errors.
    /// </summary>
    /// <param name="alimento">The food entity to validate.</param>
    /// <returns>A list of validation error messages. Empty if valid.</returns>
    public static List<string> Validar(Alimento alimento)
    {
        List<string> errores = [];

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