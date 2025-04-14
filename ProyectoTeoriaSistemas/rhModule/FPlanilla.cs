using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public partial class FPlanilla : Form
    {
        private List<EmpleadoDatos> listaEmpleados = new List<EmpleadoDatos>();
        private EmpleadoDatos EmpleadoSeleccionado = new EmpleadoDatos();

        public FPlanilla()
        {
            InitializeComponent();
            CargarEmpleados();
            LimpiarCampos();
            if (EmpleadoData.ListaEmpleados.Count == 0)
            {
                EmpleadoDatos empleadoPredeterminado = new EmpleadoDatos
                {
                    Nombre = "Lagarturo",
                    DPI = "1234567890101",
                    Cargo = "Empresaurio",
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

        }

        //Este boton carga los datos al dataGrid
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar que el usuario ha seleccionado un empleado
            // Verificar que el usuario ha seleccionado un empleado
            if (cmBoxEmpleados.SelectedItem == null || !(cmBoxEmpleados.SelectedItem is EmpleadoDatos))
            {
                MessageBox.Show("Seleccione un empleado antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si pasó la validación, asignamos el empleado seleccionado
            EmpleadoDatos empleadoSeleccionado = (EmpleadoDatos)cmBoxEmpleados.SelectedItem;

            try
            {
                Planilla objeto = new Planilla()
                {
                    SueldoNetoCalculado = empleadoSeleccionado.Sueldo,
                    HorasExtras = (int)numHorasExtra.Value,
                    Comisiones = int.TryParse(txtComisiones.Text, out int comisiones) ? comisiones : 0,
                    Bonificaciones = int.TryParse(txtBonificaciones.Text, out int bonificaciones) ? bonificaciones : 0,
                    IGSS = int.TryParse(txtIGSS.Text, out int igss) ? igss : 0,
                    Prestamos = int.TryParse(txtPrestamos.Text, out int prestamos) ? prestamos : 0,
                    Nombre = empleadoSeleccionado.Nombre,
                    Cargo = empleadoSeleccionado.Cargo
                };

                bool respuesta = PlanillaLogica.Instancia.Guardar(objeto);

                if (respuesta)
                {
                    MostrarPlanilla();
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //verifica si el usuario selecciono un empleado
            if (cmBoxEmpleados.SelectedItem is EmpleadoDatos empleadoSeleccionado)
            {
                //crea un objeto planilla, que ya jala los datos del empleado seleccionado
                Planilla trabajador = new Planilla//aca se crea el objeto
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
            EmpleadoSeleccionado = null;
        }

        public void MostrarPlanilla()
        {
            dataPlanilla.DataSource = null;
            dataPlanilla.DataSource = PlanillaLogica.Instancia.Listar();
        }


        private decimal ConvertirADecimal(string valor)
        {
            return decimal.TryParse(valor, out decimal resultado) ? resultado : 0m;
        }



        //Este boton solo llama, al formulario de Empleado (No tocar :V) 7W7 
        private void button3_Click(object sender, EventArgs e)
        {
            Empleado empleadoForm = new Empleado();
            empleadoForm.OnEmpleadoGuardado += CargarEmpleados;
            empleadoForm.Show();
        }

        private void tbnGuardarPlanilla_Click(object sender, EventArgs e)
        {

        }

        private void cmBoxEmpleados_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmBoxEmpleados.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un empleado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmBoxEmpleados.SelectedItem is EmpleadoDatos empleadoSeleccionado)
            {
                MessageBox.Show($"Empleado seleccionado: {empleadoSeleccionado.Nombre}");
                EmpleadoSeleccionado = empleadoSeleccionado;
            }
        }
    }
}

