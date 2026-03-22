using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.Controller;

public class AlimentoController
{
    private readonly IAlimentoRepository _alimentoRepository;

    public AlimentoController(IAlimentoRepository alimentoRepository)
    {
        _alimentoRepository = alimentoRepository;
    }

    public (bool Exito, string Mensaje) RegistrarAlimento(Alimento alimento)
    {
        List<string> errores = AlimentoValidator.Validar(alimento);

        if (errores.Count > 0)
        {
            return (false, string.Join(Environment.NewLine, errores));
        }

        _alimentoRepository.Agregar(alimento);
        return (true, "Alimento registrado correctamente.");
    }

    public List<Alimento> ObtenerTodos()
    {
        return _alimentoRepository.ObtenerTodos();
    }

    public Alimento? ObtenerPorId(Guid id)
    {
        return _alimentoRepository.ObtenerPorId(id);
    }

    public (bool Exito, string Mensaje) ActualizarAlimento(Alimento alimento)
    {
        List<string> errores = AlimentoValidator.Validar(alimento);

        if (errores.Count > 0)
        {
            return (false, string.Join(Environment.NewLine, errores));
        }

        _alimentoRepository.Actualizar(alimento);
        return (true, "Alimento actualizado correctamente.");
    }

    public (bool Exito, string Mensaje) EliminarAlimento(Guid id)
    {
        Alimento? alimento = _alimentoRepository.ObtenerPorId(id);

        if (alimento is null)
        {
            return (false, "El alimento no existe.");
        }

        _alimentoRepository.Eliminar(id);
        return (true, "Alimento eliminado correctamente.");
    }
}