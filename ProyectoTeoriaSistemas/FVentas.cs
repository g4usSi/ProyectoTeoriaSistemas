using System;
using System.Linq;
using System.Windows.Forms;
using ProyectoTeoriaSistemas;
using ProyectoTeoriaSistemas.CodigoFuente;

namespace ProyectoTeoriaSistemas
{
    public partial class FVentas : Form
    {
        private Factura factura;
        private Tienda tienda;

        public FVentas(Tienda tienda)
        {
            this.tienda = tienda;
            this.factura = new Factura(1);

            InitializeComponent();
            CargarProductos();
            MostrarFacturaEnTabla();
            InicializarFecha();
        }
        private void InicializarFecha()
        {
            txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void CargarProductos()
        {
            comboDatos.Items.Clear();
            foreach (var producto in tienda.listaProductos)
            {
                comboDatos.Items.Add($"{producto.ID} - {producto.Nombre} (Q{producto.Precio})");
            }
            if (comboDatos.Items.Count > 0)
                comboDatos.SelectedIndex = 0;
        }

        private void MostrarFacturaEnTabla()
        {
            dataFacturaTabla.Rows.Clear();

            foreach (var detalle in factura.Detalles)
            {
                dataFacturaTabla.Rows.Add(detalle.Cantidad, detalle.Producto.ID,
                    detalle.Producto.Nombre, $"Q{detalle.Producto.Precio:F2}", $"Q{detalle.Subtotal:F2}");
            }

            lblTotal.Text = $"Total: Q{factura.Total:F2}";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí podrías editar un producto en la factura.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ActualizarFactura()
        {
            // Limpiar las filas de la tabla antes de actualizarlas
            dataFacturaTabla.Rows.Clear();

            // Agregar los detalles de la factura a la tabla
            foreach (var detalle in factura.Detalles)
            {
                int rowIndex = dataFacturaTabla.Rows.Add();
                DataGridViewRow row = dataFacturaTabla.Rows[rowIndex];

                // Rellenar las celdas de la tabla con la información de la factura
                row.Cells[0].Value = detalle.Cantidad;  // Cantidad
                row.Cells[1].Value = detalle.Producto.ID;  // ID del Producto
                row.Cells[2].Value = detalle.Producto.Nombre + " - " + detalle.Producto.Marca;  // Nombre del Producto
                row.Cells[3].Value = $"Q {detalle.Producto.Precio:F2}";  // Precio Unitario
                row.Cells[4].Value = $"Q {detalle.Subtotal:F2}";  // Subtotal
            }

            // Mostrar el total de la factura
            lblTotal.Text = $"Total: Q {factura.Total:F2}";
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (comboDatos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)NumericUpDown.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string seleccion = comboDatos.SelectedItem.ToString();
            int idProducto = int.Parse(seleccion.Split('-')[0].Trim());

            try
            {
                factura.AgregarProducto(tienda, idProducto, cantidad);
                ActualizarFactura();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}





