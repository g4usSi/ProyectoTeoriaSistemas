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
            CargarProveedoresEnComboBox();

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
                PrecioVenta = int.Parse(textPrecioVenta.Text),
                IDProveedor = int.Parse(comboBox1.SelectedItem.ToString().Split(' ')[0])
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

        private void CargarProveedoresEnComboBox()
        {
            List<string> proveedores = ProductoLogica.Instancia.MostrarProveedores();

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(proveedores.ToArray());
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

