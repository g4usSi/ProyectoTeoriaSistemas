using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas.finanzasModule
{
    public partial class NEgresos : Form
    {
        public NEgresos()
        {
            InitializeComponent();
            Diseño();
        }
        public void Diseño()
        {
            Fecha.CalendarForeColor = Color.DarkSlateBlue;
            Fecha.CalendarMonthBackground = Color.Beige;
            Fecha.CalendarTitleBackColor = Color.SaddleBrown;
            Fecha.CalendarTitleForeColor = Color.White;
            Fecha.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            Fecha.Format = DateTimePickerFormat.Custom;
            Fecha.CustomFormat = "dd/MM/yyyy";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.sfx_menu1);
            player.Play();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.cancelar);
            player.Play();
        }
    }
}
