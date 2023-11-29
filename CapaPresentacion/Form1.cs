using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Test cnTest = new CN_Test();
        CN_Insumos cnInsumos = new CN_Insumos();
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
