using ProyectoTeoriaSistemas;
using ProyectoTeoriaSistemas.CodigoFuente;
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
            AgregarProductoDB();
        }

        private void AgregarProductoDB()
        {
            Producto objeto = new Producto()
            {//ID *en el video no lo coloco porque es para eliminar y editar * en este caso no se usa porque es autoincrementable
                Nombre = textNombre.Text,
                Marca = textMarca.Text,
                Stock = int.Parse(textCantidad.Text),
                Precio = int.Parse(textPrecio.Text),
                PrecioVenta = int.Parse(textPrecioVenta.Text)
            };
            //devuelve una respuesta
            bool respuesta = ProductoLogica.Instancia.Guardar(objeto);

            if (respuesta)
            {
                //ESTA COSA ES LA QUE MEUSTRA LA TABLA 
                mostrar_Articulo();
            }

        }

        public void mostrar_Articulo()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ProductoLogica.Instancia.Listar();
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
            //dataGridView1.Columns["PrecioVenta"].Visible = false;
            //dataGridView1.Columns["Cantidad"].Visible = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

    }

