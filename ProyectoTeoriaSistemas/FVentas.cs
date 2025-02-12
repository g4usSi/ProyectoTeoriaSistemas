using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProyectoTeoriaSistemas.CodigoFuente;

namespace ProyectoTeoriaSistemas
{
    public partial class FVentas : Form
    {
        private Factura facturaDemo;

        public FVentas()
        {
            InitializeComponent();
            CargarFacturaDemo();
            MostrarFacturaEnTabla();
            InicializarFecha();
        }

        private void InicializarFecha()
        {
            txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd"); // Formato: Año-Mes-Día
        }

        private void CargarFacturaDemo()
        {
            // Crear factura falsa con ID aleatorio
            facturaDemo = new Factura(new Random().Next(1000, 9999));

            // Simulación de productos vendidos
            Producto p1 = new Producto(1, "Gloss", "BeautyCreations", 5, 13);
            Producto p2 = new Producto(2, "Rimel", "MaxFactor", 10, 25);
            Producto p3 = new Producto(3, "Pinta Uñas", "Covergirl", 7, 17);

            // Agregar detalles de factura (ventas ficticias)
            facturaDemo.Detalles.Add(new DetalleFactura(p1, 2)); // 2 Gloss
            facturaDemo.Detalles.Add(new DetalleFactura(p2, 3)); // 3 Rimel
            facturaDemo.Detalles.Add(new DetalleFactura(p3, 1)); // 1 Pinta Uñas
        }

        private void MostrarFacturaEnTabla()
        {
            dataFacturaTabla.Rows.Clear(); // Limpiar tabla antes de cargar datos

            foreach (var detalle in facturaDemo.Detalles)
            {
                int rowIndex = dataFacturaTabla.Rows.Add();
                DataGridViewRow row = dataFacturaTabla.Rows[rowIndex];

                row.Cells[0].Value = detalle.Cantidad;
                row.Cells[1].Value = detalle.Producto.ID;
                row.Cells[2].Value = detalle.Producto.Nombre + " - " + detalle.Producto.Marca;
                row.Cells[3].Value = $"Q {detalle.Producto.Precio:F2}"; // Precio unitario
                row.Cells[4].Value = $"Q {detalle.Subtotal:F2}"; // Subtotal
            }

            // Mostrar el total de la factura
            lblTotal.Text = $"Total: Q {facturaDemo.Total:F2}";
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            FArticulo fArticulo = new FArticulo();
            fArticulo.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí podrías editar un producto en la factura.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

