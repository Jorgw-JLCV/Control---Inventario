using ProyectoInso;
using System;
using System.Windows.Forms;



namespace prueba2
{
    public partial class Salida_Producto : Form
    {
        private MovimientoSalida movimientoSalida;
        public Salida_Producto()
        {
            InitializeComponent();
        }

        private void res_stock_prod_TextChanged(object sender, EventArgs e)
        {
            res_stock_prod.TextChanged -= res_stock_prod_TextChanged;
            if (!float.TryParse(res_stock_prod.Text, out float cantidad) || cantidad < -1)
            {
                res_stock_prod.Text = "";

                MessageBox.Show("Por favor, ingrese un valor válido para la cantidad a retirar.");
            }
            res_stock_prod.TextChanged += res_stock_prod_TextChanged;
        }

        private void res_stock_btm_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProducto = "NombreDelProducto";
                if (!float.TryParse(res_stock_prod.Text, out float cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para la cantidad a agregar.");
                    return;
                }
                Producto producto = new Producto(nombreProducto);
                movimientoSalida = new MovimientoSalida(producto, cantidad);
                movimientoSalida.RegistrarSalida();

                MessageBox.Show("Salida de producto registrada con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string ObtenerNombreProducto()
        {
            return res_stock_prod.Text.Trim();
        }

        private float ObtenerCantidadSalida()
        {
            float.TryParse(res_stock_prod.Text, out float cantidad);
            return cantidad;
        }


        private void Cancel_btm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
