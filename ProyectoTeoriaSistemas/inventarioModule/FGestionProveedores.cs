using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public partial class FGestionProveedores : Form
    {
        public FGestionProveedores()
        {
            InitializeComponent();
           
           
        }

        public void Botones()
        {
            HacerBotonRedondeado(btnAgregar, 20);
            HacerBotonRedondeado(Compras, 20);
            HacerBotonRedondeado(btnEstado, 20);
            HacerBotonRedondeado(btnReportes, 20);
            HacerBotonRedondeado(btnInventario, 20);

        }

        private void Compras_Click(object sender, EventArgs e)
        {

        }
        private void HacerBotonRedondeado(Button boton, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(boton.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(boton.Width - radio, boton.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, boton.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            boton.Region = new Region(path);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /* ESTRUCTURA PARA AGREGAR COSAS, 
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
*/

    }
}
