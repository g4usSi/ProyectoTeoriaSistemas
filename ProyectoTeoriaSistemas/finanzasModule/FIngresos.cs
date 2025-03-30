using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas.finanzasModule
{
    public partial class FIngresos : Form
    {
        public FIngresos()
        {
            InitializeComponent();
        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            NIngreso nIngreso = new NIngreso();
            nIngreso.Show();
        }
    }
}
