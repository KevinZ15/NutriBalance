using System.Text.Json;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

public class AlimentoJsonRepository : IAlimentoRepository
{
    private readonly string _rutaArchivo;
    private readonly JsonSerializerOptions _jsonOptions;

    public AlimentoJsonRepository(string rutaArchivo)
    {
        _rutaArchivo = rutaArchivo;
        _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        InicializarArchivo();
    }

    public List<Alimento> ObtenerTodos()
    {
        string contenido = File.ReadAllText(_rutaArchivo);
        List<Alimento>? alimentos = JsonSerializer.Deserialize<List<Alimento>>(contenido, _jsonOptions);
        return alimentos ?? new List<Alimento>();
    }

    public Alimento? ObtenerPorId(Guid id)
    {
        return ObtenerTodos().FirstOrDefault(alimento => alimento.Id == id);
    }

    public void Agregar(Alimento alimento)
    {
        List<Alimento> alimentos = ObtenerTodos();
        alimentos.Add(alimento);
        GuardarTodos(alimentos);
    }

    public void Actualizar(Alimento alimentoActualizado)
    {
        List<Alimento> alimentos = ObtenerTodos();

        Alimento? alimentoExistente = alimentos.FirstOrDefault(a => a.Id == alimentoActualizado.Id);

        if (alimentoExistente is null)
        {
            throw new InvalidOperationException("El alimento no existe en el archivo JSON.");
        }

        alimentoExistente.Nombre = alimentoActualizado.Nombre;
        alimentoExistente.Porcion = alimentoActualizado.Porcion;
        alimentoExistente.Calorias = alimentoActualizado.Calorias;
        alimentoExistente.Proteinas = alimentoActualizado.Proteinas;
        alimentoExistente.Carbohidratos = alimentoActualizado.Carbohidratos;
        alimentoExistente.Grasas = alimentoActualizado.Grasas;

        GuardarTodos(alimentos);
    }

    public void Eliminar(Guid id)
    {
        List<Alimento> alimentos = ObtenerTodos();

        Alimento? alimento = alimentos.FirstOrDefault(a => a.Id == id);

        if (alimento is not null)
        {
            alimentos.Remove(alimento);
            GuardarTodos(alimentos);
        }
    }

    private void InicializarArchivo()
    {
        string? directorio = Path.GetDirectoryName(_rutaArchivo);

        if (!string.IsNullOrWhiteSpace(directorio) && !Directory.Exists(directorio))
        {
            Directory.CreateDirectory(directorio);
        }

        if (!File.Exists(_rutaArchivo))
        {
            File.WriteAllText(_rutaArchivo, "[]");
        }
    }

    private void GuardarTodos(List<Alimento> alimentos)
    {
        string json = JsonSerializer.Serialize(alimentos, _jsonOptions);
        File.WriteAllText(_rutaArchivo, json);
    }
}