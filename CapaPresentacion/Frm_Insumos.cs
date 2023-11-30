using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_Insumos : Form
    {
        private string nombreInsumo;
        private float precioInsumo;
        private int cantidadInsumo;

        CN_Insumos cnInsumos = new CN_Insumos();
        public Frm_Insumos()
        {
            InitializeComponent();
        }

        private void btnAgregarInsum_Click(object sender, EventArgs e)
        {
            nombreInsumo = txtNombInsum.Text;
            precioInsumo = float.Parse(txtPrecioInsum.Text);
            cantidadInsumo = int.Parse(txtCantidadInsum.Text);

            cnInsumos.InsertarDatos(nombreInsumo, precioInsumo, cantidadInsumo);

            MessageBox.Show("Los Datos se agregaron exitosamente");

            txtNombInsum.Text = "";

            txtPrecioInsum.Text = "";

            txtCantidadInsum.Text = "";
        }
    }
}
