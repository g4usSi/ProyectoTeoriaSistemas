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
            AgregarProveedorDB();
        }
         
        private void AgregarProveedorDB()
        {
           Proveedor objeto = new Proveedor()
           {//ID *en el video no lo coloco porque es para eliminar y editar * en este caso no se usa porque es autoincrementable
               Nombre = textBox2.Text,
               NIT =textBox10.Text,
               Telefono = int.Parse(textBox8.Text),
               Contacto = textBox7.Text,
               Direccion = textBox6.Text,
               Correo = textBox5.Text
           };
   
           bool respuesta = ProveedorLogica.Instancia.Guardar(objeto);

           if (respuesta)
           {
               //ESTA COSA ES LA QUE MEUSTRA LA TABLA 
               mostrar_Proveedor();
           }

        }

        public void mostrar_Proveedor()
        {
           dataGridView1.DataSource = null;
           dataGridView1.DataSource = ProveedorLogica.Instancia.Listar();
        }

    }
}
