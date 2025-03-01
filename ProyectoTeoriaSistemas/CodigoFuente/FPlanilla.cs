using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public partial class FPlanilla : Form
    {
        //Aqui tiene que haber logica para almacenar datos D:

        public FPlanilla()
        {
            InitializeComponent();
        }

        private void textCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Show();
        }
    }
}
