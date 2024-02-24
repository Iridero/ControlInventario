using ClasesInventario;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

public class ArticuloDbContext
{
    private const string ConnectionString = "Data Source=articulos.db";

    public ArticuloDbContext()
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Articulos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Descripcion TEXT NOT NULL,
                    Precio DECIMAL NOT NULL,
                    Existencia INTEGER NOT NULL
                );
            ";

            command.ExecuteNonQuery();
        }
    }

    public void AgregarArticulo(Articulo articulo)
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Articulos (Descripcion, Precio, Existencia)
                VALUES ($descripcion, $precio, $existencia);
            ";
            command.Parameters.AddWithValue("$descripcion", articulo.Descripcion);
            command.Parameters.AddWithValue("$precio", articulo.Precio);
            command.Parameters.AddWithValue("$existencia", articulo.Existencia);

            command.ExecuteNonQuery();
        }
    }

    public List<Articulo> ObtenerArticulos()
    {
        var articulos = new List<Articulo>();

        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Descripcion, Precio, Existencia FROM Articulos;";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    articulos.Add(new Articulo
                    {
                        Id = reader.GetInt32(0),
                        Descripcion = reader.GetString(1),
                        Precio = reader.GetDecimal(2),
                        Existencia = reader.GetInt32(3)
                    });
                }
            }
        }

        return articulos;
    }

    public void ActualizarArticulo(Articulo articulo)
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                UPDATE Articulos
                SET Descripcion = $descripcion, Precio = $precio, Existencia = $existencia
                WHERE Id = $id;
            ";
            command.Parameters.AddWithValue("$descripcion", articulo.Descripcion);
            command.Parameters.AddWithValue("$precio", articulo.Precio);
            command.Parameters.AddWithValue("$existencia", articulo.Existencia);
            command.Parameters.AddWithValue("$id", articulo.Id);

            command.ExecuteNonQuery();
        }
    }

    public void EliminarArticulo(int id)
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Articulos WHERE Id = $id;";
            command.Parameters.AddWithValue("$id", id);

            command.ExecuteNonQuery();
        }
    }
}

