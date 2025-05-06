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
using ProyectoTeoriaSistemas.inventarioModule;

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

        

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProveedorDB();
        }
         
        private void AgregarProveedorDB()
        {
           Proveedor objeto = new Proveedor()
           {//ID *en el video no lo coloco porque es para eliminar y editar * en este caso no se usa porque es autoincrementable
               //textBox2.Text, creo que no se va a usar
               Nombre = textBox10.Text,
               NIT = textBox9.Text,
               Telefono = int.Parse(textBox8.Text),
               Contacto = textBox7.Text,
               Direccion = textBox6.Text,
               Correo = textBox5.Text

               //aca solo le mandas los parametros que sea, desde cualquier formulario, esque 
               //lo hice para probar nomas

           };
   
           bool respuesta = ProveedorLogica.Instancia.Guardar(objeto);

           if (respuesta)
           {
               //ESTA COSA ES LA QUE MUESTRA LA TABLA 
               mostrar_Proveedor();
           }

        }

        public void mostrar_Proveedor()
        {
           dataGridView1.DataSource = null;
           dataGridView1.DataSource = ProveedorLogica.Instancia.Listar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void FGestionProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
