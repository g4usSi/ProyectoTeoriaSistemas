using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoTeoriaSistemas;
using ProyectoTeoriaSistemas.CodigoFuente;

namespace ProyectoTeoriaSistemas
{
    public partial class FVentas : Form
    {
        private Factura factura;
        private Tienda tienda;
        private static int FacturaContador = 1000;  // Se inicia en 1000 por ejemplo, puedes poner otro valor
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();


        public FVentas(Tienda tienda)
        {
            this.tienda = tienda;
            this.factura = new Factura(1);

            InitializeComponent();
            CargarProductos();
            MostrarFacturaEnTabla();
            InicializarFecha();
            InicializarCampos();

            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);
            float lineHeight = font.GetHeight() + 2;
            float x = 10;
            float y = 10;

            g.DrawString("Factura de Venta", font, Brushes.Black, x, y);
            y += lineHeight;


            g.DrawString($"Fecha: {txtFecha.Text}", font, Brushes.Black, x, y);
            y += lineHeight;
            g.DrawString($"Cliente: {txtCliente.Text}", font, Brushes.Black, x, y);
            y += lineHeight;
            g.DrawString($"NIT: {txtNIT.Text}", font, Brushes.Black, x, y);
            y += lineHeight;
            g.DrawString($"Factura No: {txtNumeroFactura.Text}", font, Brushes.Black, x, y);
            y += lineHeight;

            g.DrawString("------------------------------", font, Brushes.Black, x, y);
            y += lineHeight;

            foreach (var detalle in factura.Detalles)
            {
                g.DrawString($"{detalle.Producto.Nombre} - Cantidad: {detalle.Cantidad} - Precio: Q{detalle.Producto.Precio:F2} - Subtotal: Q{detalle.Subtotal:F2}", font, Brushes.Black, x, y);
                y += lineHeight;
            }

            g.DrawString("------------------------------", font, Brushes.Black, x, y);
            y += lineHeight;

            g.DrawString($"Total: Q{factura.Total:F2}", font, Brushes.Black, x, y);
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
            dataFacturaTabla.Rows.Clear();

            foreach (var detalle in factura.Detalles)
            {
                int rowIndex = dataFacturaTabla.Rows.Add();
                DataGridViewRow row = dataFacturaTabla.Rows[rowIndex];

                row.Cells[0].Value = detalle.Cantidad; 
                row.Cells[1].Value = detalle.Producto.ID;  
                row.Cells[2].Value = detalle.Producto.Nombre + " - " + detalle.Producto.Marca;
                row.Cells[3].Value = $"Q {detalle.Producto.Precio:F2}";
                row.Cells[4].Value = $"Q {detalle.Subtotal:F2}";
            }

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

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            if (factura.Detalles.Count == 0)
            {
                MessageBox.Show("No hay productos en la factura. Agregue productos antes de realizar la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder resumen = new StringBuilder();
            resumen.AppendLine("Resumen de la Venta:");
            resumen.AppendLine($"Fecha: {txtFecha.Text}");
            resumen.AppendLine($"Cliente: {txtCliente.Text}");
            resumen.AppendLine($"NIT: {txtNIT.Text}");
            resumen.AppendLine($"Factura No: {txtNumeroFactura.Text}");
            resumen.AppendLine("------------------------------");

            foreach (var detalle in factura.Detalles)
            {
                resumen.AppendLine($"{detalle.Producto.Nombre} - Cantidad: {detalle.Cantidad} - Precio: Q{detalle.Producto.Precio:F2} - Subtotal: Q{detalle.Subtotal:F2}");
            }

            resumen.AppendLine("------------------------------");
            resumen.AppendLine($"Total: Q{factura.Total:F2}");

            try
            {
                string rutaArchivo = @"C:\Users\Geovanny Alcon\Desktop\URL 2025\RepoXD\ProyectoTeoriaSistemas" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                System.IO.File.WriteAllText(rutaArchivo, resumen.ToString());

                MessageBox.Show($"Venta guardada exitosamente en: {rutaArchivo}", "Venta Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();

            factura = new Factura(1);
            MostrarFacturaEnTabla();
        }

        private void InicializarCampos()
        {
            txtCliente.Clear();
            txtNIT.Text = "C/F";
            txtNumeroFactura.Text = (FacturaContador++).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarCampos();

        }

    }
}