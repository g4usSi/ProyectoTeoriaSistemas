using ProyectoTeoriaSistemas;
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
    public partial class FProducto : Form
    {
        Tienda tienda;
        public FProducto(Tienda tienda)
        {
            InitializeComponent();
            this.tienda = tienda;
            CargarProductosEnGrid();

        }

        private void FProducto_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void AgregarProducto()
        {
            var errores = new List<string>();
            var campos = new (TextBox, string)[]
            {
        (textId, "ID"),
        (textNombre, "Nombre"),
        (textMarca, "Marca"),
        (textCantidad, "Cantidad"),
        (textPrecio, "Precio")
            };

            
            foreach (var (campo, nombre) in campos)
                if (string.IsNullOrWhiteSpace(campo.Text))
                    errores.Add($"⚠ El campo {nombre} es obligatorio.");

         
            if (!int.TryParse(textId.Text, out int id))
                errores.Add("⚠ El ID debe ser un número válido.");
            if (!int.TryParse(textCantidad.Text, out int cantidad))
                errores.Add("⚠ La cantidad debe ser un número válido.");
            if (!double.TryParse(textPrecio.Text, out double precio))
                errores.Add("⚠ El precio debe ser un número válido.");

           
            if (errores.Any())
            {
                MessageBox.Show(string.Join("\n", errores), "Revisión de Datos ❗",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Asegurar que la instancia de tienda existe
            if (tienda == null)
            {
                MessageBox.Show("⚠ Error: No se encontró la instancia de la tienda.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var nuevoProducto = new Producto(id, textNombre.Text, textMarca.Text, cantidad, precio);
            tienda.listaProductos.AddLast(nuevoProducto);

            MessageBox.Show("✅ Producto agregado exitosamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarProductosEnGrid();
        }


        private void CargarProductosEnGrid()
        {
            /* if (tienda == null || tienda.listaProductos == null)
             {
                 MessageBox.Show("⚠ No hay productos para mostrar.", "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
             }*/

           

            dataGridView1.DataSource = tienda.listaProductos.ToList();
            dataGridView1.Columns["PrecioVenta"].Visible = false;
            dataGridView1.Columns["Cantidad"].Visible = false;

        }

        
    }

    }

