using Microsoft.Data.Sqlite;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services.SQLite;

public class UsuarioSqliteRepository(string rutaBaseDatos) : IUsuarioRepository
{
    private readonly string _connectionString = $"Data Source={rutaBaseDatos}";

    public List<Usuario> ObtenerTodos()
    {
        List<Usuario> usuarios = [];

        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = "SELECT * FROM Usuarios ORDER BY NombreUsuario";
        using SqliteCommand command = new(sql, connection);
        using SqliteDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            usuarios.Add(new Usuario
            {
                Id = Guid.Parse(reader["Id"].ToString()!),
                NombreUsuario = reader["NombreUsuario"].ToString() ?? string.Empty,
                Contrasena = reader["Contrasena"].ToString() ?? string.Empty,
                Nombre = reader["Nombre"].ToString() ?? string.Empty,
                Peso = Convert.ToDecimal(reader["Peso"]),
                Estatura = Convert.ToDecimal(reader["Estatura"]),
                NivelActividad = (NivelActividad)Convert.ToInt32(reader["NivelActividad"]),
                Objetivo = (ObjetivoUsuario)Convert.ToInt32(reader["Objetivo"]),
                TipoDieta = (TipoDieta)Convert.ToInt32(reader["TipoDieta"])
            });
        }

        return usuarios;
    }

    public Usuario? ObtenerPorId(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = "SELECT * FROM Usuarios WHERE Id = @Id";
        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Id", id.ToString());

        using SqliteDataReader reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        return new Usuario
        {
            Id = Guid.Parse(reader["Id"].ToString()!),
            NombreUsuario = reader["NombreUsuario"].ToString() ?? string.Empty,
            Contrasena = reader["Contrasena"].ToString() ?? string.Empty,
            Nombre = reader["Nombre"].ToString() ?? string.Empty,
            Peso = Convert.ToDecimal(reader["Peso"]),
            Estatura = Convert.ToDecimal(reader["Estatura"]),
            NivelActividad = (NivelActividad)Convert.ToInt32(reader["NivelActividad"]),
            Objetivo = (ObjetivoUsuario)Convert.ToInt32(reader["Objetivo"]),
            TipoDieta = (TipoDieta)Convert.ToInt32(reader["TipoDieta"])
        };
    }

    public Usuario? ObtenerPorCredenciales(string nombreUsuario, string contrasena)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = @"
SELECT * 
FROM Usuarios 
WHERE lower(NombreUsuario) = lower(@NombreUsuario) 
AND Contrasena = @Contrasena";

        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
        command.Parameters.AddWithValue("@Contrasena", contrasena);

        using SqliteDataReader reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        return new Usuario
        {
            Id = Guid.Parse(reader["Id"].ToString()!),
            NombreUsuario = reader["NombreUsuario"].ToString() ?? string.Empty,
            Contrasena = reader["Contrasena"].ToString() ?? string.Empty,
            Nombre = reader["Nombre"].ToString() ?? string.Empty,
            Peso = Convert.ToDecimal(reader["Peso"]),
            Estatura = Convert.ToDecimal(reader["Estatura"]),
            NivelActividad = (NivelActividad)Convert.ToInt32(reader["NivelActividad"]),
            Objetivo = (ObjetivoUsuario)Convert.ToInt32(reader["Objetivo"]),
            TipoDieta = (TipoDieta)Convert.ToInt32(reader["TipoDieta"])
        };
    }

    public Usuario? ObtenerPorNombreUsuario(string nombreUsuario)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = "SELECT * FROM Usuarios WHERE lower(NombreUsuario) = lower(@NombreUsuario)";
        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

        using SqliteDataReader reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        return new Usuario
        {
            Id = Guid.Parse(reader["Id"].ToString()!),
            NombreUsuario = reader["NombreUsuario"].ToString() ?? string.Empty,
            Contrasena = reader["Contrasena"].ToString() ?? string.Empty,
            Nombre = reader["Nombre"].ToString() ?? string.Empty,
            Peso = Convert.ToDecimal(reader["Peso"]),
            Estatura = Convert.ToDecimal(reader["Estatura"]),
            NivelActividad = (NivelActividad)Convert.ToInt32(reader["NivelActividad"]),
            Objetivo = (ObjetivoUsuario)Convert.ToInt32(reader["Objetivo"]),
            TipoDieta = (TipoDieta)Convert.ToInt32(reader["TipoDieta"])
        };
    }

    public void Agregar(Usuario usuario)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = @"
INSERT INTO Usuarios
(Id, NombreUsuario, Contrasena, Nombre, Peso, Estatura, NivelActividad, Objetivo, TipoDieta)
VALUES
(@Id, @NombreUsuario, @Contrasena, @Nombre, @Peso, @Estatura, @NivelActividad, @Objetivo, @TipoDieta)";

        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Id", usuario.Id.ToString());
        command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
        command.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
        command.Parameters.AddWithValue("@Peso", usuario.Peso);
        command.Parameters.AddWithValue("@Estatura", usuario.Estatura);
        command.Parameters.AddWithValue("@NivelActividad", (int)usuario.NivelActividad);
        command.Parameters.AddWithValue("@Objetivo", (int)usuario.Objetivo);
        command.Parameters.AddWithValue("@TipoDieta", (int)usuario.TipoDieta);

        command.ExecuteNonQuery();
    }

    public void Actualizar(Usuario usuario)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = @"
UPDATE Usuarios
SET NombreUsuario = @NombreUsuario,
    Contrasena = @Contrasena,
    Nombre = @Nombre,
    Peso = @Peso,
    Estatura = @Estatura,
    NivelActividad = @NivelActividad,
    Objetivo = @Objetivo,
    TipoDieta = @TipoDieta
WHERE Id = @Id";

        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Id", usuario.Id.ToString());
        command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
        command.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
        command.Parameters.AddWithValue("@Peso", usuario.Peso);
        command.Parameters.AddWithValue("@Estatura", usuario.Estatura);
        command.Parameters.AddWithValue("@NivelActividad", (int)usuario.NivelActividad);
        command.Parameters.AddWithValue("@Objetivo", (int)usuario.Objetivo);
        command.Parameters.AddWithValue("@TipoDieta", (int)usuario.TipoDieta);

        command.ExecuteNonQuery();
    }
}