using System;
using System.Linq;
using System.Windows.Forms;
using ProyectoTeoriaSistemas;
using ProyectoTeoriaSistemas.CodigoFuente;

namespace ProyectoTeoriaSistemas.Forms
{
    public class FormFactura : Form
    {
        private Tienda tienda;
        private Factura factura;

        private ComboBox comboProductos;
        private NumericUpDown numCantidad;
        private Button btnAgregar;
        private DataGridView dgvFactura;
        private Label lblTotal;

        public FormFactura(Tienda tienda)
        {
            this.tienda = tienda;
            this.factura = new Factura(1);  // Se crea una nueva factura con ID 1

            InicializarComponentes();
            CargarProductos();
        }

        private void InicializarComponentes()
        {
            this.Text = "Factura de Compra";
            this.Size = new System.Drawing.Size(500, 400);

            // ComboBox para seleccionar productos
            comboProductos = new ComboBox() { Left = 20, Top = 20, Width = 200 };
            this.Controls.Add(comboProductos);

            // NumericUpDown para seleccionar la cantidad
            numCantidad = new NumericUpDown() { Left = 230, Top = 20, Width = 80, Minimum = 1, Maximum = 100 };
            this.Controls.Add(numCantidad);

            // Botón para agregar productos a la factura
            btnAgregar = new Button() { Left = 320, Top = 20, Width = 100, Text = "Agregar" };
            btnAgregar.Click += BtnAgregar_Click;
            this.Controls.Add(btnAgregar);

            // DataGridView para mostrar los productos en la factura
            dgvFactura = new DataGridView()
            {
                Left = 20,
                Top = 60,
                Width = 440,
                Height = 200,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true
            };
            this.Controls.Add(dgvFactura);

            // Label para mostrar el total
            lblTotal = new Label() { Left = 20, Top = 280, Width = 400, Text = "Total: Q0.00" };
            this.Controls.Add(lblTotal);

            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvFactura.Columns.Add("Producto", "Producto");
            dgvFactura.Columns.Add("Cantidad", "Cantidad");
            dgvFactura.Columns.Add("Precio", "Precio");
            dgvFactura.Columns.Add("Subtotal", "Subtotal");
        }

        private void CargarProductos()
        {
            comboProductos.Items.Clear();
            foreach (var producto in tienda.listaProductos)
            {
                comboProductos.Items.Add($"{producto.ID} - {producto.Nombre} (Q{producto.Precio})");
            }
            if (comboProductos.Items.Count > 0)
                comboProductos.SelectedIndex = 0;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (comboProductos.SelectedIndex == -1) return;

            string seleccion = comboProductos.SelectedItem.ToString();
            int idProducto = int.Parse(seleccion.Split('-')[0].Trim());
            int cantidad = (int)numCantidad.Value;

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

        private void ActualizarFactura()
        {
            dgvFactura.Rows.Clear();
            foreach (var detalle in factura.Detalles)
            {
                dgvFactura.Rows.Add(detalle.Producto.Nombre, detalle.Cantidad, detalle.Producto.Precio, detalle.Subtotal);
            }

            lblTotal.Text = $"Total: Q{factura.Total:F2}";
        }
    }
}
