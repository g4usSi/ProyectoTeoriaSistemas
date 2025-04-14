using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTeoriaSistemas.CodigoFuente;
using ProyectoTeoriaSistemas.Forms;
using ProyectoTeoriaSistemas.finanzasModule;

namespace ProyectoTeoriaSistemas
{
    public partial class FInventario : Form
    {
        public FInventario(/*Tienda tienda*/)
        {
            InitializeComponent();
            splitContainer1.SplitterWidth = 1;
        }

        private Form formularioActual;

        private void MostrarFormulario(Form nuevoFormulario)
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
            }

            nuevoFormulario.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(nuevoFormulario);
            nuevoFormulario.Location = new Point(3, 83);
            nuevoFormulario.Show();

            formularioActual = nuevoFormulario;
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            // FProducto fProducto = new FProducto(tienda);
            FProducto fProducto = new FProducto();
            MostrarFormulario(fProducto);
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void proveedores_Click(object sender, EventArgs e)
        {
            FGestionProveedores proveedores = new FGestionProveedores();
            MostrarFormulario(proveedores);
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            // FImpuestos factura = new FImpuestos(tienda);
            FImpuestos factura = new FImpuestos();
            MostrarFormulario(factura);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
