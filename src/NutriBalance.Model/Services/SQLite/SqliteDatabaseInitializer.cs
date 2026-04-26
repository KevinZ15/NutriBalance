using Microsoft.Data.Sqlite;

namespace NutriBalance.Model.Services.SQLite;

/// <summary>
/// Provides initialization logic for the SQLite database.
/// </summary>
public static class SqliteDatabaseInitializer
{
    /// <summary>
    /// Initializes the database, creating tables and default data if they do not exist.
    /// </summary>
    /// <param name="rutaBaseDatos">The path to the SQLite database file.</param>
    public static void Inicializar(string rutaBaseDatos)
    {
        string? directorio = Path.GetDirectoryName(rutaBaseDatos);

        if (!string.IsNullOrWhiteSpace(directorio) && !Directory.Exists(directorio))
        {
            Directory.CreateDirectory(directorio);
        }

        string connectionString = $"Data Source={rutaBaseDatos}";

        using SqliteConnection connection = new(connectionString);
        connection.Open();

        using (SqliteCommand pragma = new("PRAGMA foreign_keys = ON;", connection))
        {
            pragma.ExecuteNonQuery();
        }

        string sql = @"
CREATE TABLE IF NOT EXISTS Usuarios (
    Id TEXT PRIMARY KEY,
    NombreUsuario TEXT NOT NULL,
    Contrasena TEXT NOT NULL,
    Nombre TEXT NOT NULL,
    Peso REAL NOT NULL,
    Estatura REAL NOT NULL,
    NivelActividad INTEGER NOT NULL,
    Objetivo INTEGER NOT NULL,
    TipoDieta INTEGER NOT NULL,
    Rol INTEGER NOT NULL DEFAULT 0,
    Activo INTEGER NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS Alimentos (
    Id TEXT PRIMARY KEY,
    Nombre TEXT NOT NULL,
    Porcion REAL NOT NULL,
    Calorias REAL NOT NULL,
    Proteinas REAL NOT NULL,
    Carbohidratos REAL NOT NULL,
    Grasas REAL NOT NULL,
    EsKeto INTEGER NOT NULL,
    EsVegetariano INTEGER NOT NULL,
    EsEstandar INTEGER NOT NULL
);

CREATE TABLE IF NOT EXISTS MenusDiarios (
    Id TEXT PRIMARY KEY,
    UsuarioId TEXT NOT NULL,
    Fecha TEXT NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);

CREATE TABLE IF NOT EXISTS MenuDiarioDetalles (
    Id TEXT PRIMARY KEY,
    MenuDiarioId TEXT NOT NULL,
    AlimentoId TEXT NOT NULL,
    NombreAlimento TEXT NOT NULL,
    CantidadUnidades REAL NOT NULL,
    GramosPorUnidad REAL NOT NULL,
    Cantidad REAL NOT NULL,
    Proteinas REAL NOT NULL,
    Grasas REAL NOT NULL,
    Carbohidratos REAL NOT NULL,
    Calorias REAL NOT NULL,
    FOREIGN KEY (MenuDiarioId) REFERENCES MenusDiarios(Id),
    FOREIGN KEY (AlimentoId) REFERENCES Alimentos(Id)
);
";

        using (SqliteCommand command = new(sql, connection))
        {
            command.ExecuteNonQuery();
        }

        AgregarColumnasSiNoExisten(connection);

        CrearAdminPorDefecto(connection);
    }

    /// <summary>
    /// Adds missing columns to the Usuarios table if they do not exist.
    /// </summary>
    /// <param name="connection">The active database connection.</param>
    private static void AgregarColumnasSiNoExisten(SqliteConnection connection)
    {
        var columnas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        using (var cmd = new SqliteCommand("PRAGMA table_info(Usuarios);", connection))
        using (var reader = cmd.ExecuteReader())
        {
            while (reader.Read())
                columnas.Add(reader["name"].ToString()!);
        }

        if (!columnas.Contains("Rol"))
        {
            using var cmd = new SqliteCommand("ALTER TABLE Usuarios ADD COLUMN Rol INTEGER NOT NULL DEFAULT 0;", connection);
            cmd.ExecuteNonQuery();
        }

        if (!columnas.Contains("Activo"))
        {
            using var cmd = new SqliteCommand("ALTER TABLE Usuarios ADD COLUMN Activo INTEGER NOT NULL DEFAULT 1;", connection);
            cmd.ExecuteNonQuery();
        }
    }

    /// <summary>
    /// Creates a default admin user if no admin exists in the database.
    /// </summary>
    /// <param name="connection">The active database connection.</param>
    private static void CrearAdminPorDefecto(SqliteConnection connection)
    {
        // Only creates the admin if no user with Rol = 1 exists
        using var check = new SqliteCommand("SELECT COUNT(*) FROM Usuarios WHERE Rol = 1;", connection);
        long count = (long)(check.ExecuteScalar() ?? 0L);

        if (count == 0)
        {
            string id = Guid.NewGuid().ToString();
            string sql = @"
INSERT INTO Usuarios (Id, NombreUsuario, Contrasena, Nombre, Peso, Estatura, NivelActividad, Objetivo, TipoDieta, Rol, Activo)
VALUES (@Id, 'admin', '1234', 'Administrador', 70, 1.70, 1, 1, 1, 1, 1);";

            using var cmd = new SqliteCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
    }
}