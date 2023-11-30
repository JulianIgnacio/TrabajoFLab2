using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_Productos : Form
    {
        private string nombreProducto;
        private float precioProducto;
        private int cantidadProducto;

        CN_Productos cnProductos = new CN_Productos();
        public Frm_Productos()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {


            nombreProducto = txtNombProd.Text;
            precioProducto = float.Parse(txtPrecioProd.Text);
            cantidadProducto = int.Parse(txtCantidadProd.Text);

            cnProductos.InsertarDatos(nombreProducto, precioProducto, cantidadProducto);

            MessageBox.Show("Los Datos se agregaron exitosamente");

            txtNombProd.Text = "";

            txtPrecioProd.Text = "";

            txtCantidadProd.Text = "";
        }
    }
}
