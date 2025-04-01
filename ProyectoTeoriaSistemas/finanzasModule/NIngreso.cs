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
    public partial class NIngreso : Form
    {
        private Tienda _tienda = null;
        public NIngreso(Tienda tienda)
        {
            InitializeComponent();
            _tienda = tienda;
        }
    }
}
