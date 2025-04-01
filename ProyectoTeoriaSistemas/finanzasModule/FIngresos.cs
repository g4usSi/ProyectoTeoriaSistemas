using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas.finanzasModule
{
    public partial class FIngresos : Form
    {
        private Tienda _tienda = null;
        public FIngresos(Tienda tienda)
        {
            _tienda = tienda;
            InitializeComponent();
        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            NIngreso nIngreso = new NIngreso();
            nIngreso.Show();
        }

        private void FIngresos_Load(object sender, EventArgs e)
        {

        }

        private void btnFlujoEfectivo_Click(object sender, EventArgs e)
        {

        }
    }
}
