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
    public partial class FInventario : Form
    { 
        public FInventario()
        {
            InitializeComponent();
            splitContainer1.SplitterWidth = 1;
        }
        private Form formularioActual;
        private void MostrarFormulario(Form nuevoFormulario)
        {
            // Cierra el formulario actual si existe
            if (formularioActual != null)
            {
                formularioActual.Close();
            }

            // Configura el nuevo formulario
            nuevoFormulario.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(nuevoFormulario);
            nuevoFormulario.Location = new Point(3, 83);
            nuevoFormulario.Show();
           
            // Actualiza el formulario actual
            formularioActual = nuevoFormulario;
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            FProducto fProducto = new FProducto();
            MostrarFormulario(fProducto);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
