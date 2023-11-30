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


        private void mostrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraerDgvInsumos();
        }
        private void limpiarDataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarDgv();
        }
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnTest.TestDB();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarDgv();
        }
        private void mostrarDatosToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void insertarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Insumos frmInsertar = new Frm_Insumos();
            AddOwnedForm(frmInsertar);
            frmInsertar.ShowDialog();
        }

        private void insertarDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Productos frmInsertar = new Frm_Productos();
            AddOwnedForm(frmInsertar);
            frmInsertar.ShowDialog();
        }
    }
}
