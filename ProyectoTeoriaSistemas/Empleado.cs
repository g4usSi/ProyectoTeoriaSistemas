using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas
{
    public partial class Empleado : Form
    {
        private List<EmpleadoDatos> empleados = new List<EmpleadoDatos>();

        public Empleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDPI.Text) ||
                    string.IsNullOrWhiteSpace(txtSueldo.Text))
                {
                    MessageBox.Show("Por favor, llena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EmpleadoDatos nuevoEmpleado = new EmpleadoDatos
                {
                    Nombre = txtNombre.Text,
                    DPI = txtDPI.Text,
                    Sueldo = float.Parse(txtSueldo.Text),
                    FechaNacimiento = dtpFechaNacimiento.Value
                };

                empleados.Add(nuevoEmpleado);

                // Mensaje de confirmación
                MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos
                txtNombre.Clear();
                txtDPI.Clear();
                txtSueldo.Clear();
                dtpFechaNacimiento.Value = DateTime.Today; // Restablece la fecha actual
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto en los datos. Verifica que el sueldo sea un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<EmpleadoDatos> ObtenerEmpleados()
        {
            return empleados;
        }
    }

    public class EmpleadoDatos
    {
        public string Nombre { get; set; }
        public string DPI { get; set; }
        public float Sueldo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
