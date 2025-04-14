using ProyectoTeoriaSistemas.CodigoFuente;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas
{
    public partial class Empleado : Form
    {
        public event Action OnEmpleadoGuardado;

        public Empleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que todos los campos obligatorios estén llenos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDPI.Text) ||
                    string.IsNullOrWhiteSpace(txtSueldo.Text) ||
                    string.IsNullOrWhiteSpace(txtCargo.Text)) // Verifica también el cargo
                {
                    MessageBox.Show("Por favor, llena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear y agregar empleado a la lista estática
                EmpleadoDatos nuevoEmpleado = new EmpleadoDatos
                {
                    Nombre = txtNombre.Text,
                    DPI = txtDPI.Text,
                    Cargo = txtCargo.Text, // Asigna el cargo ingresado en el TextBox
                    Sueldo = (decimal)float.Parse(txtSueldo.Text),
                    FechaNacimiento = dtpFechaNacimiento.Value
                };

                EmpleadoData.ListaEmpleados.Add(nuevoEmpleado);

                MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Disparar evento para actualizar FPlanilla
                OnEmpleadoGuardado?.Invoke();

                // Limpiar campos después de guardar
                txtNombre.Clear();
                txtDPI.Clear();
                txtCargo.Clear(); // Limpia el campo del cargo
                txtSueldo.Clear();
                dtpFechaNacimiento.Value = DateTime.Today;

            }
            catch (FormatException)
            {
                MessageBox.Show("Formato incorrecto en los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
