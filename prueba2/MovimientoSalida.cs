using System;
using MySql.Data.MySqlClient;


namespace ProyectoInso
{
    public class MovimientoSalida
    {
        public Producto Producto { get; private set; }
        public float Cantidad { get; private set; }

        public MovimientoSalida(Producto producto, float cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public void RegistrarSalida()
        {
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();
                    var consultaStock = "SELECT Stock_Actual FROM Producto WHERE Nombre = @Nombre";
                    MySqlCommand comandoStock = new MySqlCommand(consultaStock, conexion);
                    comandoStock.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    float stockActual = Convert.ToSingle(comandoStock.ExecuteScalar());
                    if (Cantidad > stockActual)
                    {
                        throw new InvalidOperationException("No hay suficiente stock para realizar la salida.");
                    }
                    float nuevoStock = stockActual - Cantidad;
                    var consultaActualizar = "UPDATE Producto SET Stock_Actual = @NuevoStock WHERE Nombre = @Nombre";
                    MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                    comandoActualizar.Parameters.AddWithValue("@NuevoStock", nuevoStock);
                    comandoActualizar.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    comandoActualizar.ExecuteNonQuery();
                    var consultaMovimiento = "INSERT INTO MovimientosSalida (ProductoNombre, Stock, Fecha) VALUES (@Nombre, @Cantidad, NOW())";
                    MySqlCommand comandoMovimiento = new MySqlCommand(consultaMovimiento, conexion);
                    comandoMovimiento.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    comandoMovimiento.Parameters.AddWithValue("@Cantidad", Cantidad);
                    comandoMovimiento.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la salida del producto", ex);
            }
        }
    }
}
