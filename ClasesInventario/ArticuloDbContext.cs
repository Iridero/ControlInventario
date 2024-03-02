using ClasesInventario;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

public class ArticuloDbContext
{
    private const string ConnectionString = "Data Source=articulos.db";
    public event EventHandler<ArticuloEventArgs> ArticuloEventHandler;
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

    private void AlCambiarArticulo(Articulo articulo)
    {
        ArticuloEventArgs e = new ArticuloEventArgs(articulo);
        EventHandler<ArticuloEventArgs> handler =
            ArticuloEventHandler;
        handler?.Invoke(this, e);
    }
    public async Task AgregarArticulo(Articulo articulo)
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

            await command.ExecuteNonQueryAsync();
            AlCambiarArticulo(articulo);
        }
    }

    public async Task< List<Articulo> > ObtenerArticulos()
    {
        var articulos = new List<Articulo>();

        using (var connection = new SqliteConnection(ConnectionString))
        {
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Descripcion, Precio, Existencia FROM Articulos;";

            using (var reader =await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
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

    public async Task ActualizarArticulo(Articulo articulo)
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            await connection.OpenAsync();

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

            await command.ExecuteNonQueryAsync();
        }
    }

    public async Task EliminarArticulo(int id)
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Articulos WHERE Id = $id;";
            command.Parameters.AddWithValue("$id", id);

            await command.ExecuteNonQueryAsync();
        }
    }
}

