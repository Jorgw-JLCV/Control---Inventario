using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using prueba2;
using ProyectoInso;

namespace prueba2
{
    public partial class Crear_Producto : Form
    {
        public Crear_Producto()
        {
            
            InitializeComponent();
        }

        private void name_prod_TextChanged(object sender, EventArgs e)
        {
        }

        private void stock_min_add_TextChanged(object sender, EventArgs e)
        {
        }

        private void precio_add_TextChanged(object sender, EventArgs e)
        {
        }

        private void add_prod_btm_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = name_prod.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Por favor, ingrese un nombre válido.");
                    return;
                }

                if (!float.TryParse(stock_min_add.Text, out float stockMinimo) || stockMinimo < -0)
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para Stock mínimo.");
                    return;
                }

                if (!float.TryParse(precio_add.Text, out float precio) || precio < -0)
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para Precio.");
                    return;
                }
                DateTime ultimaActualizacion = DateTime.Now;
                float stockActual = 0;
                int pos = 0;
                Producto nuevoProducto = new Producto(nombre, stockMinimo, precio, ultimaActualizacion, stockActual, pos);
                Producto.CrearProducto(nuevoProducto);
                MessageBox.Show("Producto creado con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el producto: " + ex.Message);
            }
        }

        private void cancel_btm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
