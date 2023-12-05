using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ProyectoInso;


namespace prueba2
{
    public partial class Entrada_Producto : Form
    {
        private MovimientoEntrada movimientoEntrada;
        public Entrada_Producto()
        {
            InitializeComponent();
        }

        private void add_stock_prod_TextChanged(object sender, EventArgs e)
        {
            add_stock_prod.TextChanged -= add_stock_prod_TextChanged;
            if (!float.TryParse(add_stock_prod.Text, out float cantidad) || cantidad < -1)
            {
                add_stock_prod.Text = "";
                MessageBox.Show("Por favor, ingrese un valor válido para la cantidad a agregar.");
            }
            add_stock_prod.TextChanged += add_stock_prod_TextChanged;
        }

        private void addstock_btm_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProducto = "NombreDelProducto";
                if (!float.TryParse(add_stock_prod.Text, out float cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para la cantidad a agregar.");
                    return;
                }
                Producto producto = new Producto(nombreProducto); 
                movimientoEntrada = new MovimientoEntrada(producto, cantidad);
                movimientoEntrada.RegistrarEntrada();

                MessageBox.Show("Entrada de producto registrada con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Cancel_btm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


