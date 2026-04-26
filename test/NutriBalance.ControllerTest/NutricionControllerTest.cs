using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutriBalance.Controller;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;

namespace NutriBalance.ControllerTest;

[TestClass]
public class NutricionControllerTest
{
    /// <summary>
    /// Tests BMI calculation with valid data.
    /// </summary>
    [TestMethod]
    public void CalcularIMC_ShouldReturnCorrectValue()
    {
        var usuario = new Usuario
        {
            Peso = 70,
            Estatura = 175
        };

        var result = NutricionController.CalcularIMC(usuario);

        Assert.AreEqual(22.86m, result);
    }

    /// <summary>
    /// Tests BMI classification for normal weight.
    /// </summary>
    [TestMethod]
    public void ClasificarIMC_ShouldReturnNormalWeight()
    {
        var result = NutricionController.ClasificarIMC(24);

        Assert.AreEqual("Peso normal", result);
    }

    /// <summary>
    /// Tests calorie calculation for maintenance goal.
    /// </summary>
    [TestMethod]
    public void CalcularCaloriasObjetivo_ShouldReturnCorrectValue()
    {
        var usuario = new Usuario
        {
            Peso = 70,
            Estatura = 175,
            NivelActividad = NivelActividad.Moderado,
            Objetivo = ObjetivoUsuario.Mantener
        };

        var result = NutricionController.CalcularCaloriasObjetivo(usuario);

        Assert.IsGreaterThan(0, result);
    }
}