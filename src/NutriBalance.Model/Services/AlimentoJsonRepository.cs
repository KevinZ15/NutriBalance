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
        _jsonOptions = new JsonSerializerOptions { WriteIndented = true };
        InicializarArchivo();
    }

    public static void InicializarCatalogoUsuario(string rutaGlobal, string rutaUsuario)
    {
        if (File.Exists(rutaUsuario))
        {
            return;
        }

        if (File.Exists(rutaGlobal))
        {
            File.Copy(rutaGlobal, rutaUsuario);
        }
        else
        {
            File.WriteAllText(rutaUsuario, "[]");
        }
    }

    public List<Alimento> ObtenerTodos()
    {
        string contenido = File.ReadAllText(_rutaArchivo);
        List<Alimento>? alimentos = JsonSerializer.Deserialize<List<Alimento>>(contenido, _jsonOptions);
        return alimentos ?? new List<Alimento>();
    }

    public Alimento? ObtenerPorId(Guid id)
    {
        return ObtenerTodos().FirstOrDefault(a => a.Id == id);
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
        Alimento? existente = alimentos.FirstOrDefault(a => a.Id == alimentoActualizado.Id);

        if (existente is null)
        {
            throw new InvalidOperationException("El alimento no existe en el archivo JSON.");
        }

        existente.Nombre = alimentoActualizado.Nombre;
        existente.Porcion = alimentoActualizado.Porcion;
        existente.Calorias = alimentoActualizado.Calorias;
        existente.Proteinas = alimentoActualizado.Proteinas;
        existente.Carbohidratos = alimentoActualizado.Carbohidratos;
        existente.Grasas = alimentoActualizado.Grasas;
        existente.EsKeto = alimentoActualizado.EsKeto;
        existente.EsVegetariano = alimentoActualizado.EsVegetariano;
        existente.EsEstandar = alimentoActualizado.EsEstandar;

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