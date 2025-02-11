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
        Tienda tienda;
        private Timer timer;
        public MenuPrincipal(Tienda tienda)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.tienda = tienda;

            // Inicializa el Label con la hora actual
            lblTiempo.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");

            // Configurar y empezar el Timer
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"); // Formato: día/mes/año hora:minuto:segundo
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FInventario fInventario = new FInventario(tienda);
            fInventario.Show();
        }

        // Ventas
        private void button2_Click(object sender, EventArgs e)
        {
            FVentas frmVenta = new FVentas();
            frmVenta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Lógica para button3
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Lógica para button4
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Lógica para button5
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
