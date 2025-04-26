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
    public partial class FrmAgregarProveedor : Form
    {
        public List<Proveedor> proveedores = new List<Proveedor>();
        public string filePath = "proveedores.json";
        public FrmAgregarProveedor()
        {
            InitializeComponent();

        }

        private void tnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNIT.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtContacto.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Proveedor nuevoProveedor = new Proveedor
            {
                //TELEFONO ES CON INT NMMZ

                Nombre = txtNombre.Text,
                NIT = txtNIT.Text,
                Direccion = txtDireccion.Text, 
               // Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Contacto = txtContacto.Text,
            };

            proveedores.Add(nuevoProveedor);

            MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


       
    }
}

