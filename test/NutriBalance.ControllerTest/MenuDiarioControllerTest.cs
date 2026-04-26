using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutriBalance.Controller;
using NutriBalance.Model.Entities;

namespace NutriBalance.ControllerTest;

[TestClass]
public class MenuDiarioControllerTest
{
    /// <summary>
    /// Tests total macro calculation.
    /// </summary>
    [TestMethod]
    public void CalcularTotales_ShouldReturnCorrectTotals()
    {
        var menu = new MenuDiario
        {
            Detalles =
            [
                new MenuDiarioDetalle { Calorias = 100, Proteinas = 10 },
                new MenuDiarioDetalle { Calorias = 200, Proteinas = 20 }
            ]
        };

        (decimal Calorias, decimal Proteinas, decimal _, decimal _) = MenuDiarioController.CalcularTotales(menu);

        Assert.AreEqual(300, Calorias);
        Assert.AreEqual(30, Proteinas);
    }

    /// <summary>
    /// Tests calorie goal evaluation when the goal is met.
    /// </summary>
    [TestMethod]
    public void EvaluarMetaCalorica_ShouldReturnCumplida()
    {
        var result = MenuDiarioController.EvaluarMetaCalorica(2000, 2000);

        Assert.AreEqual(EstadoMetaDiaria.Cumplida, result);
    }

    /// <summary>
    /// Tests calorie goal evaluation when calories are exceeded.
    /// </summary>
    [TestMethod]
    public void EvaluarMetaCalorica_ShouldReturnExcedida()
    {
        var result = MenuDiarioController.EvaluarMetaCalorica(2600, 2000);

        Assert.AreEqual(EstadoMetaDiaria.Excedida, result);
    }

    /// <summary>
    /// Tests calorie goal evaluation when calories are below the goal.
    /// </summary>
    [TestMethod]
    public void EvaluarMetaCalorica_ShouldReturnPorDebajo()
    {
        var result = MenuDiarioController.EvaluarMetaCalorica(1000, 2000);

        Assert.AreEqual(EstadoMetaDiaria.PorDebajo, result);
    }
}