using Microsoft.Data.Sqlite;

namespace NutriBalance.Model.Services.SQLite;

public static class SqliteDatabaseInitializer
{
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

        // IMPORTANTE: habilitar foreign keys en SQLite
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
    TipoDieta INTEGER NOT NULL
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

        using SqliteCommand command = new(sql, connection);
        command.ExecuteNonQuery();
    }
}