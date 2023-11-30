using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Test cnTest = new CN_Test();
        CN_Insumos cnInsumos = new CN_Insumos();
        CN_Productos cnProductos = new CN_Productos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestConexion_Click(object sender, EventArgs e)
        {
            cnTest.TestDB();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            TraerDgvInsumos();
        }
        private void btnLimpiarDgv_Click(object sender, EventArgs e)
        {
            LimpiarDgv();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            TraerDgvProductos();
        }

        private void TraerDgvProductos()
        {
            DgvPan.DataSource = cnProductos.MostrarProductos();
        }
        private void TraerDgvInsumos()
        {
            DgvPan.DataSource = cnInsumos.MostrarInsumos();
        }
        private void LimpiarDgv()
        {
            DgvPan.DataSource = null;
            DgvPan.Columns.Clear();
        }

    }
}
