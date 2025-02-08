using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FInventario fInventario = new FInventario();
            fInventario.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        //Ventas
        private void button2_Click(object sender, EventArgs e)
        {
            FVentas frmVenta = new FVentas();
            frmVenta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
