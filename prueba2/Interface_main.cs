using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using prueba2;
using ProyectoInso;

namespace ProyectoInso
{
    public partial class Interface_main : Form
    {
        public Interface_main()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            CargarProductos();
        }

        private void CargarProductos()
        {
                List<Producto> productos = Producto.ListarProductos();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Nombre", typeof(string));
                dataTable.Columns.Add("Stock_Minimo", typeof(float));
                dataTable.Columns.Add("Precio", typeof(float));
                dataTable.Columns.Add("Ultima_Actualizacion", typeof(DateTime));
                dataTable.Columns.Add("Stock_Actual", typeof(float));
                dataTable.Columns.Add("pos", typeof(int));
                foreach (var producto in productos)
                {
                    dataTable.Rows.Add(
                        producto.Nombre,
                        producto.Stock_Minimo,
                        producto.Precio,
                        producto.Ultima_Actualizacion,
                        producto.Stock_Actual,
                        producto.pos
                    );
                }
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["pos"].Visible = false;
                dataGridView1.Columns["Ingreso"].DisplayIndex = 6;
                dataGridView1.Columns["Retiro"].DisplayIndex = 7;
                ActualizarPos(dataTable);
        }


        private void ActualizarPos(DataTable dataTable)
        {

            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                foreach (DataRow fila in dataTable.Rows)
                {
                    string nombreProducto = fila["Nombre"].ToString();
                    int nuevaPosicion = Convert.ToInt32(fila["pos"]);
                    string actualizarPosQuery = $"UPDATE Producto SET pos = {nuevaPosicion} WHERE Nombre = '{nombreProducto}'";
                    using (MySqlCommand cmd = new MySqlCommand(actualizarPosQuery, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void add_prod_Click_1(object sender, EventArgs e)
        {
            Crear_Producto f = new Crear_Producto();
            CargarProductos();
        }

    }
}
