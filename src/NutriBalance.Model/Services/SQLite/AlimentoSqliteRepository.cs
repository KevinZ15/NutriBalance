using Microsoft.Data.Sqlite;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services.SQLite;

/// <summary>
/// SQLite implementation of the food item repository.
/// </summary>
public class AlimentoSqliteRepository(string rutaBaseDatos) : IAlimentoRepository
{
    private readonly string _connectionString = $"Data Source={rutaBaseDatos}";

    /// <summary>
    /// Gets all food items ordered by name.
    /// </summary>
    /// <returns>A list of all food items.</returns>
    public List<Alimento> ObtenerTodos()
    {
        List<Alimento> alimentos = [];

        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = "SELECT * FROM Alimentos ORDER BY Nombre";
        using SqliteCommand command = new(sql, connection);
        using SqliteDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            alimentos.Add(new Alimento
            {
                Id = Guid.Parse(reader["Id"].ToString()!),
                Nombre = reader["Nombre"].ToString() ?? string.Empty,
                Porcion = Convert.ToDecimal(reader["Porcion"]),
                Calorias = Convert.ToDecimal(reader["Calorias"]),
                Proteinas = Convert.ToDecimal(reader["Proteinas"]),
                Carbohidratos = Convert.ToDecimal(reader["Carbohidratos"]),
                Grasas = Convert.ToDecimal(reader["Grasas"]),
                EsKeto = Convert.ToInt32(reader["EsKeto"]) == 1,
                EsVegetariano = Convert.ToInt32(reader["EsVegetariano"]) == 1,
                EsEstandar = Convert.ToInt32(reader["EsEstandar"]) == 1
            });
        }

        return alimentos;
    }

    /// <summary>
    /// Gets a food item by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the food item.</param>
    /// <returns>The matching food item, or <c>null</c> if not found.</returns>
    public Alimento? ObtenerPorId(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = "SELECT * FROM Alimentos WHERE Id = @Id";
        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Id", id.ToString());

        using SqliteDataReader reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        return new Alimento
        {
            Id = Guid.Parse(reader["Id"].ToString()!),
            Nombre = reader["Nombre"].ToString() ?? string.Empty,
            Porcion = Convert.ToDecimal(reader["Porcion"]),
            Calorias = Convert.ToDecimal(reader["Calorias"]),
            Proteinas = Convert.ToDecimal(reader["Proteinas"]),
            Carbohidratos = Convert.ToDecimal(reader["Carbohidratos"]),
            Grasas = Convert.ToDecimal(reader["Grasas"]),
            EsKeto = Convert.ToInt32(reader["EsKeto"]) == 1,
            EsVegetariano = Convert.ToInt32(reader["EsVegetariano"]) == 1,
            EsEstandar = Convert.ToInt32(reader["EsEstandar"]) == 1
        };
    }

    /// <summary>
    /// Adds a new food item.
    /// </summary>
    /// <param name="alimento">The food item to add.</param>
    public void Agregar(Alimento alimento)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = @"
INSERT INTO Alimentos
(Id, Nombre, Porcion, Calorias, Proteinas, Carbohidratos, Grasas, EsKeto, EsVegetariano, EsEstandar)
VALUES
(@Id, @Nombre, @Porcion, @Calorias, @Proteinas, @Carbohidratos, @Grasas, @EsKeto, @EsVegetariano, @EsEstandar)";

        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Id", alimento.Id.ToString());
        command.Parameters.AddWithValue("@Nombre", alimento.Nombre);
        command.Parameters.AddWithValue("@Porcion", alimento.Porcion);
        command.Parameters.AddWithValue("@Calorias", alimento.Calorias);
        command.Parameters.AddWithValue("@Proteinas", alimento.Proteinas);
        command.Parameters.AddWithValue("@Carbohidratos", alimento.Carbohidratos);
        command.Parameters.AddWithValue("@Grasas", alimento.Grasas);
        command.Parameters.AddWithValue("@EsKeto", alimento.EsKeto ? 1 : 0);
        command.Parameters.AddWithValue("@EsVegetariano", alimento.EsVegetariano ? 1 : 0);
        command.Parameters.AddWithValue("@EsEstandar", alimento.EsEstandar ? 1 : 0);

        command.ExecuteNonQuery();
    }

    /// <summary>
    /// Updates an existing food item.
    /// </summary>
    /// <param name="alimento">The food item with updated values.</param>
    public void Actualizar(Alimento alimento)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = @"
UPDATE Alimentos
SET Nombre = @Nombre,
    Porcion = @Porcion,
    Calorias = @Calorias,
    Proteinas = @Proteinas,
    Carbohidratos = @Carbohidratos,
    Grasas = @Grasas,
    EsKeto = @EsKeto,
    EsVegetariano = @EsVegetariano,
    EsEstandar = @EsEstandar
WHERE Id = @Id";

        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Id", alimento.Id.ToString());
        command.Parameters.AddWithValue("@Nombre", alimento.Nombre);
        command.Parameters.AddWithValue("@Porcion", alimento.Porcion);
        command.Parameters.AddWithValue("@Calorias", alimento.Calorias);
        command.Parameters.AddWithValue("@Proteinas", alimento.Proteinas);
        command.Parameters.AddWithValue("@Carbohidratos", alimento.Carbohidratos);
        command.Parameters.AddWithValue("@Grasas", alimento.Grasas);
        command.Parameters.AddWithValue("@EsKeto", alimento.EsKeto ? 1 : 0);
        command.Parameters.AddWithValue("@EsVegetariano", alimento.EsVegetariano ? 1 : 0);
        command.Parameters.AddWithValue("@EsEstandar", alimento.EsEstandar ? 1 : 0);

        command.ExecuteNonQuery();
    }

    /// <summary>
    /// Deletes a food item by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the food item to delete.</param>
    public void Eliminar(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = "DELETE FROM Alimentos WHERE Id = @Id";
        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Id", id.ToString());

        command.ExecuteNonQuery();
    }
}