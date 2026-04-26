using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NutriBalance.Controller;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.ControllerTest;

[TestClass]
public class AlimentoControllerTest
{
    /// <summary>
    /// Tests successful food creation.
    /// </summary>
    [TestMethod]
    public void RegistrarAlimento_ShouldSave_WhenValid()
    {
        var mockRepo = new Mock<IAlimentoRepository>();
        var controller = new AlimentoController(mockRepo.Object);

        var alimento = new Alimento
        {
            Nombre = "Pollo",
            Porcion = 100,
            Proteinas = 30,
            Grasas = 5,
            Carbohidratos = 0,
            EsEstandar = true
        };

        var (Exito, Mensaje) = controller.RegistrarAlimento(alimento);

        Assert.IsTrue(Exito);

        // Verify repository was called
        mockRepo.Verify(x => x.Agregar(It.IsAny<Alimento>()), Times.Once);
    }

    /// <summary>
    /// Tests invalid food should not be saved.
    /// </summary>
    [TestMethod]
    public void RegistrarAlimento_ShouldFail_WhenInvalid()
    {
        var mockRepo = new Mock<IAlimentoRepository>();
        var controller = new AlimentoController(mockRepo.Object);

        var alimento = new Alimento(); // invalid

        var (Exito, Mensaje) = controller.RegistrarAlimento(alimento);

        Assert.IsFalse(Exito);

        // Verify repository was NOT called
        mockRepo.Verify(x => x.Agregar(It.IsAny<Alimento>()), Times.Never);
    }
}