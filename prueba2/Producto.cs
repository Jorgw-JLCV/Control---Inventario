using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using prueba2;

namespace ProyectoInso
{
    public class Producto
    {
        internal object Stock_Minimo;
        internal object Ultima_Actualizacion;
        internal object Stock_Actual;

        public string Nombre { get; private set; }
        public float StockMinimo { get; private set; }
        public float Precio { get; private set; }
        public DateTime UltimaActualizacion { get; private set; }
        public float StockActual { get; private set; }
        public int pos { get; private set; }

        public Producto(string nombre, float stockMinimo, float precio, DateTime ultimaActualizacion, float stockActual, int pos)
        {
            Nombre = nombre;
            StockMinimo = stockMinimo;
            Precio = precio;
            UltimaActualizacion = ultimaActualizacion;
            StockActual = stockActual;
            this.pos = pos;
        }
        public Producto(string nombre)
        {
            Nombre = nombre;
        }

        public static void CrearProducto(Producto producto)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                var consulta = "INSERT INTO Producto (Nombre, Stock_Minimo, Precio, Fecha_Actualizacion) " +
                               "VALUES (@nombre, @stock_Minimo, @precio, @fechaActualizacion)"+
                               "WHERE NOT EXISTS (SELECT 1 FROM Producto WHERE Nombre = @nombre)";
                using (var comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@stock_Minimo", producto.StockMinimo);
                    comando.Parameters.AddWithValue("@precio", producto.Precio);
                    comando.Parameters.AddWithValue("@fechaActualizacion", producto.UltimaActualizacion);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static List<Producto> ListarProductos()
        {
            var productos = new List<Producto>();
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                var consulta = "SELECT Nombre, Stock_Minimo, Precio, Ultima_Actualizacion, Stock_Actual FROM Producto ORDER BY Nombre";

                using (var comando = new MySqlCommand(consulta, conexion))
                using (var reader = comando.ExecuteReader())
                {
                    int pos = 1; // Inicializar posición
                    while (reader.Read())
                    {
                        var producto = new Producto(
                            reader["Nombre"].ToString(),
                            Convert.ToSingle(reader["Stock_Minimo"]),
                            Convert.ToSingle(reader["Precio"]),
                            Convert.ToDateTime(reader["Ultima_Actualizacion"]),
                            Convert.ToSingle(reader["Stock_Actual"]),
                            pos
                        );
                        productos.Add(producto);
                        pos++;
                    }
                }
            }
            return productos;
        }
    }
}
