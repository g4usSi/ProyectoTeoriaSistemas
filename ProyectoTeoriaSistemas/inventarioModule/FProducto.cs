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
        public FProducto()
        {
            InitializeComponent();
            CargarProductosEnGrid();

        }

        private void FProducto_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //AgregarProducto();
            AgregarProductoDB();
        }
        //wea nueva , esto es lo que yo hice **atentamente el zaid**
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductoLogica.Instancia.Listar();
        }
        //wea nueva 
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
            {
                if (string.IsNullOrWhiteSpace(campo.Text))
                    errores.Add($"⚠ El campo {nombre} es obligatorio.");
            }

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

            // Aquí podrías guardar en base de datos si deseas aprovechar el código viejo
            Producto nuevoProducto = new Producto()
            {
                ID = id, // Asegúrate de que el constructor lo permita o que no sea autoincremental
                Nombre = textNombre.Text,
                Marca = textMarca.Text,
                Stock = cantidad,
                Precio = (float)precio,
                PrecioVenta = 0 // podrías permitir ingresarlo también si deseas
            };

            bool guardado = ProductoLogica.Instancia.Guardar(nuevoProducto);

            if (guardado)
            {
                MessageBox.Show("✅ Producto agregado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrar_Articulo();
            }
            else
            {
                MessageBox.Show("❌ No se pudo guardar el producto.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CargarProductosEnGrid()
        {
            /* if (tienda == null || tienda.listaProductos == null)
             {
                 MessageBox.Show("⚠ No hay productos para mostrar.", "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
             }*/

            
            //dataGridView1.DataSource = tienda.listaProductos.ToList(); 'DataGrid Funcional'
            //dataGridView1.Columns["PrecioVenta"].Visible = false;
            //dataGridView1.Columns["Cantidad"].Visible = false;
            

        }

    }

    }

