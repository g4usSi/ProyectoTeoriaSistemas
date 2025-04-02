using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProyectoTeoriaSistemas;  // Asegúrate de que este namespace incluya a Tienda y ResumenPlanilla

namespace ProyectoTeoriaSistemas.finanzasModule
{
    public partial class FEgresos : Form
    {
        private Tienda _tienda = null;

        public FEgresos(Tienda tienda)
        {
            InitializeComponent();
            _tienda = tienda;
            LlenarComboBoxAno();
            LlenarComboBoxMes();
            CargarResumenPlanillaInicial();
        }

        /// <summary>
        /// Llena el ComboBox de año.  
        /// Se puede extender para obtener años de manera dinámica, pero, por el momento, se agregan valores predeterminados.
        /// </summary>
        private void LlenarComboBoxAno()
        {
            cmbBoxAno.Items.Clear();
            // Se agregan manualmente los años de los ejemplos predeterminados.
            cmbBoxAno.Items.Add("2025");
            cmbBoxAno.Items.Add("2024");
            // Se selecciona el primer item por defecto.
            cmbBoxAno.SelectedIndex = 0;
        }

        /// <summary>
        /// Llena el ComboBox de mes con los nombres de los meses.
        /// </summary>
        private void LlenarComboBoxMes()
        {
            cmbBoxMes.Items.Clear();
            string[] meses =
            {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            };
            cmbBoxMes.Items.AddRange(meses);
            cmbBoxMes.SelectedIndex = 0;
        }

        /// <summary>
        /// Carga el resumen de la planilla inicial basado en la selección predeterminada.
        /// </summary>
        private void CargarResumenPlanillaInicial()
        {
            btnAplicarFiltro_Click(null, null);
        }

        /// <summary>
        /// Al hacer clic en el botón, se obtiene el total de la planilla para el año y mes seleccionados.
        /// Luego se crea un objeto ResumenPlanilla con la fecha (primer día del mes), el total y la descripción "Planilla".
        /// Este objeto se muestra en el dataGrid.
        /// </summary>
        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            if (cmbBoxAno.SelectedItem == null || cmbBoxMes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un año y un mes.");
                return;
            }

            int añoSeleccionado = int.Parse(cmbBoxAno.SelectedItem.ToString());
            int mesSeleccionado = cmbBoxMes.SelectedIndex + 1;

            // Llama al método estático en ResumenPlanilla para calcular el total.
            decimal totalPlanilla = ResumenPlanilla.CalcularTotalPlanillasPorFecha(
                _tienda.PlanillaEmpresa.PlanillasEmpleados,
                añoSeleccionado,
                mesSeleccionado
            );

            // Crea el objeto resumen
            ResumenPlanilla resumen = new ResumenPlanilla
            {
                Fecha = new DateTime(añoSeleccionado, mesSeleccionado, 1),
                Total = totalPlanilla,
                Descripcion = "Planilla"
            };

            // Asigna el resumen al DataGrid
            dataGridEgresos.DataSource = new List<ResumenPlanilla> { resumen };
        }


        /// <summary>
        /// Placeholder para agregar nuevo egreso o planilla.
        /// </summary>
        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            // Aquí se puede abrir un formulario para agregar un nuevo egreso o planilla.
            // Por ejemplo:
            // NIngreso nIngreso = new NIngreso(_tienda);
            // nIngreso.Show();
        }
    }
}

