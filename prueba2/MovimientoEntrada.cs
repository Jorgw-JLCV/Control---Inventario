using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ProyectoInso
{
    public class MovimientoEntrada
    {
        public Producto Producto { get; private set; }
        public float Cantidad { get; private set; }

        public MovimientoEntrada(Producto producto, float cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public void RegistrarEntrada()
        {
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    // Paso 1: Obtener el stock actual del producto
                    var consultaStock = "SELECT Stock_Actual FROM Producto WHERE Nombre = @Nombre";
                    MySqlCommand comandoStock = new MySqlCommand(consultaStock, conexion);
                    comandoStock.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    float stockActual = Convert.ToSingle(comandoStock.ExecuteScalar());

                    // Paso 2: Sumar la cantidad al stock actual
                    float nuevoStock = stockActual + Cantidad;
                    var consultaActualizar = "UPDATE Producto SET Stock_Actual = @NuevoStock WHERE Nombre = @Nombre";
                    MySqlCommand comandoActualizar = new MySqlCommand(consultaActualizar, conexion);
                    comandoActualizar.Parameters.AddWithValue("@NuevoStock", nuevoStock);
                    comandoActualizar.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    comandoActualizar.ExecuteNonQuery();

                    // Paso 3: Registrar la entrada en un historial de movimientos (opcional)
                    var consultaMovimiento = "INSERT INTO MovimientosEntrada (ProductoNombre, Stock, Fecha) VALUES (@Nombre, @Cantidad, NOW())";
                    MySqlCommand comandoMovimiento = new MySqlCommand(consultaMovimiento, conexion);
                    comandoMovimiento.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                    comandoMovimiento.Parameters.AddWithValue("@Cantidad", Cantidad);
                    comandoMovimiento.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception("Error al registrar la entrada del producto", ex);
            }
        }
    }
}

