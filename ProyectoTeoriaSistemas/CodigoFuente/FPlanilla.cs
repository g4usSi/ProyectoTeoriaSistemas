using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public partial class FPlanilla : Form
    {
        private List<EmpleadoDatos> listaEmpleados = new List<EmpleadoDatos>();

        public FPlanilla()
        {
            InitializeComponent();
            CargarEmpleados();
            LimpiarCampos();
            if (EmpleadoData.ListaEmpleados.Count == 0)
            {
                EmpleadoDatos empleadoPredeterminado = new EmpleadoDatos
                {
                    Nombre = "La PatoFiesta",
                    DPI = "1234567890101",
                    Cargo = "Cariñoso",
                    Sueldo = 5000m,
                    FechaNacimiento = new DateTime(1990, 5, 15)
                };

                EmpleadoData.ListaEmpleados.Add(empleadoPredeterminado);
            }

            // Cargar empleados en el ComboBox después de inicializar la lista
            CargarEmpleados();
        }
        //Se cargan al ComboBox los empleados
        private void CargarEmpleados()
        {
            cmBoxEmpleados.Items.Clear();
            cmBoxEmpleados.DisplayMember = "Nombre"; // Mostrar solo el nombre en el ComboBox
            cmBoxEmpleados.ValueMember = "DPI"; // Puedes usar otro identificador único

            listaEmpleados = EmpleadoData.ListaEmpleados; // Obtener la lista de empleados

            foreach (var empleado in listaEmpleados)
            {
                cmBoxEmpleados.Items.Add(empleado);
            }
        }
        //Evento Click cuando se selecciona un empleado
        private void cmBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBoxEmpleados.SelectedItem is EmpleadoDatos empleadoSeleccionado)
            {
                MessageBox.Show($"Empleado {empleadoSeleccionado.Nombre}");
            }
        }
        //Este boton carga los datos al dataGrid
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //verifica si el usuario selecciono un empleado
            if (cmBoxEmpleados.SelectedItem is EmpleadoDatos empleadoSeleccionado)
            {
                //crea un objeto planilla, que ya jala los datos del empleado seleccionado
                Planilla trabajador = new Planilla
                {
                    Empleado = empleadoSeleccionado,
                    SueldoOrdinario = (decimal)empleadoSeleccionado.Sueldo,
                    HorasExtras = (int)numHorasExtra.Value,
                    Comisiones = ConvertirADecimal(txtComisiones.Text),
                    Bonificaciones = ConvertirADecimal(txtBonificaciones.Text),
                    IGSS = ConvertirADecimal(txtIGSS.Text),
                    Prestamos = ConvertirADecimal(txtPrestamos.Text)
                };

                // Mostrar cálculos en los labels
                lblDevengado.Text = $"Q{trabajador.TotalDevengado:F2}";
                lblTotalDescuento.Text = $"Q{trabajador.TotalDescuentos:F2}";
                lblSueldoNeto.Text = $"Q{trabajador.SueldoNeto:F2}";

                // Guardar en la base de datos, aqui solo llamas al metodo y le pasas el objeto planilla (puedes renonmbralo*)
                PlanillaDB.GuardarPlanillaEnSQL(trabajador);

                MessageBox.Show("Datos guardados correctamente en la base de datos.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado antes de calcular.");
            }
        }


        // Método para limpiar los campos
        private void LimpiarCampos()
        {

            txtBonificaciones.Text = "0";
            txtIGSS.Text = "0";
            txtPrestamos.Text = "0";

            lblDevengado.Text = "Q0.00";
            lblTotalDescuento.Text = "Q0.00";
            lblSueldoNeto.Text = "Q0.00";
        }

        private decimal ConvertirADecimal(string valor)
        {
            return decimal.TryParse(valor, out decimal resultado) ? resultado : 0m;
        }



        //Este boton solo llama, al formulario de Empleado (No tocar :V)
        private void button3_Click(object sender, EventArgs e)
        {
            Empleado empleadoForm = new Empleado();
            empleadoForm.OnEmpleadoGuardado += CargarEmpleados;
            empleadoForm.Show();
        }

    }
}

