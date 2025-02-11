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
    public partial class FVentas : Form
    {
        List<Producto> productos = new List<Producto>();
        public FVentas()
        {
            InitializeComponent();
        }
        public void LimpiarDataGrid()
        {
            dataFacturaTabla.Rows.Clear();
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            FArticulo fArticulo = new FArticulo();
            fArticulo.Show();
            foreach (var l in productos)
            {
                int rowIndex = dataFacturaTabla.Rows.Add();
                DataGridViewRow row = dataFacturaTabla.Rows[rowIndex];
                //row.Cells[0].Value = l.;
                //row.Cells[1].Value = l.;
                //row.Cells[2].Value = l.;
            }
        }
       
        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
