using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoTeoriaSistemas;
using ProyectoTeoriaSistemas.CodigoFuente;
using ProyectoTeoriaSistemas.ventasModule;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTeoriaSistemas
{
    public partial class FVentas : Form
    {
        private Factura factura;
        private static int FacturaContador = 1000;
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private List<DetalleFactura> detallesTemporal = new List<DetalleFactura>();

        public FVentas()
        {
            //Aun hay que corregir Facturas
            this.factura = new Factura();

            InitializeComponent();
            CargarProductos();
            //MostrarFacturaEnTabla();
            InicializarFecha();
            InicializarCampos();
            this.factura = new Factura();
            //Muestra el combobox de productos
            mostrarComboBox();


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
            //g.DrawString($"Cliente: {txtCliente.Text}", font, Brushes.Black, x, y);
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
            cmbProductos.Items.Clear();
        }
        /*
        private void MostrarFacturaEnTabla()
        {
            dataFacturaTabla.Rows.Clear();
            foreach (var detalle in factura.Detalles)
            {
                dataFacturaTabla.Rows.Add(detalle.Cantidad, detalle.Producto.ID, detalle.Producto.Nombre, $"Q{detalle.Producto.Precio:F2}", $"Q{detalle.Subtotal:F2}");
            }
            lblTotal.Text = $"Total: Q{factura.Total:F2}";
        }
        */
        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí podrías editar un producto en la factura.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto.", "Advertencia");
                return;
            }

            int cantidad = (int)NumericUpDown.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.", "Error");
                return;
            }

            string seleccion = cmbProductos.SelectedItem.ToString();
            int idProducto = int.Parse(seleccion.Split('-')[0].Trim());

            Producto producto = FacturaLogica.Instancia.ObtenerProductoPorID(idProducto);

            if (producto.Stock < cantidad)
            {
                MessageBox.Show("No hay suficiente stock.", "Error");
                return;
            }
            /*
            int nuevoStock = producto.Stock - cantidad;

            bool actualizado = FacturaLogica.Instancia.ActualizarStock(producto.ID, nuevoStock);
            
            if (!actualizado)
            {
                MessageBox.Show("Error al actualizar el stock en la base de datos.", "Error");
                return;
            }
            */
            //producto.Stock = nuevoStock;

            var detalle = new DetalleFactura
            {
                Producto = producto,
                Cantidad = cantidad,
            };

            detallesTemporal.Add(detalle);
            ActualizarTablaVisual();
        }
        private void ActualizarTablaVisual()
        {
            dataFacturaTabla.Rows.Clear();

            foreach (var det in detallesTemporal)
            {
                dataFacturaTabla.Rows.Add(det.Cantidad, det.Producto.ID, det.Producto.Nombre, $"Q{det.Producto.PrecioVenta:F2}", $"Q{det.Subtotal:F2}");
            }

            lblTotal.Text = $"Total: Q{detallesTemporal.Sum(d => d.Subtotal):F2}";
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            if (detallesTemporal.Count == 0)
            {
                MessageBox.Show("Agrega productos primero.");
                return;
            }

            this.factura.Cliente = txtCliente.Text;
            this.factura.NIT = txtNIT.Text;
            this.factura.Fecha = DateTime.Now;
            this.factura.Detalles = detallesTemporal;

            bool exito = FacturaLogica.Instancia.GuardarConDetalles(this.factura);

            if (exito)
            {
                MessageBox.Show("Venta registrada correctamente.");
                detallesTemporal.Clear();
                ActualizarTablaVisual();
                InicializarCampos();
            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }
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
        //A PARTIR DE ACA ES LO QUE FUNCIONA CON LA BASE DE DATOS 

        private void AgregarFacturaDB()
        {
            Factura objeto = new Factura()
            {//ID *en el video no lo coloco porque es para eliminar y editar * en este caso no se usa porque es autoincrementable
                Cliente = txtCliente.Text,
                NIT = txtNIT.Text,
                Fecha = DateTime.Now

                //metes los atributos al objeto y luego el objeto a la lista

            };
            //devuelve una respuesta
            bool respuesta = FacturaLogica.Instancia.Guardar(objeto);

            if (respuesta)
            {
                //ESTA COSA ES LA QUE MEUSTRA LA TABLA 
                mostrar_Articulo();
            }

        }
        public void mostrar_Articulo()
        {
            dataFacturaTabla.DataSource = null;
            dataFacturaTabla.DataSource = FacturaLogica.Instancia.Listar();
        }

        public void mostrarComboBox()
        {
            List<string> Articulos = FacturaLogica.Instancia.MostrarArticulosCombo();

            cmbProductos.Items.Clear();
            cmbProductos.Items.AddRange(Articulos.ToArray());
        }

        //metodo de DE DETALLES este es el que agrega 
    }
}