using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Test cnTest = new CN_Test();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestConexion_Click(object sender, EventArgs e)
        {
            cnTest.TestDB();
        }
    }
}
