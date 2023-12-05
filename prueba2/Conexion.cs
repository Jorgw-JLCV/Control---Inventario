using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;


namespace ProyectoInso
{
    public static class Conexion
    {
        private static string servidor = "viaduct.proxy.rlwy.net";
        private static string baseDatos = "railway";
        private static string usuario = "root";
        private static string contraseña = "H3Fga2aDafA-DH2-5eaEd5egDFCagceH";
        private static int puerto = 13384;

        public static MySqlConnection ObtenerConexion()
        {
            string cadenaConexion = $"Server={servidor};Port={puerto};Database={baseDatos};Uid={usuario};Pwd={contraseña};";
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}
