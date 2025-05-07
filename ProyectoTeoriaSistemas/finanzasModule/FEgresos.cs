using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProyectoTeoriaSistemas;
using ProyectoTeoriaSistemas.financieroModule;
using ProyectoTeoriaSistemas.ventasModule;  // Asegúrate de que este namespace incluya a Tienda y ResumenPlanilla

namespace ProyectoTeoriaSistemas.finanzasModule
{
    public partial class FEgresos : Form
    {

        public FEgresos()
        {
            InitializeComponent();
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

            //hacer la consulta al SQL

            MostrarEgresos(añoSeleccionado, mesSeleccionado);
            MostrarTotalEnLabel(añoSeleccionado, mesSeleccionado);


        }
        public void mostrar_Articulo()
        {
            dataGridEgresos.DataSource = null;
            dataGridEgresos.DataSource = DetallesDeFacturaLogica.Instancia.Listar();
        }

        /// <summary>
        /// Placeholder para agregar nuevo egreso o planilla.
        /// </summary>
        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            NIngreso nIngreso = new NIngreso();
            nIngreso.Show();
        }
        public void MostrarEgresos(int año, int mes)
        {
            var productos = IngresoLogica.Instancia.ListarPorFecha(año, mes);

            // Crear una lista anónima solo con las propiedades deseadas
            var productosFiltrados = productos.Select(p => new
            {
                p.ID,
                p.Nombre,
                p.Stock,
                p.Fecha
            }).ToList();

            dataGridEgresos.DataSource = null;
            dataGridEgresos.DataSource = productosFiltrados;
        }

        public void MostrarTotalEnLabel(int año, int mes)
        {
            decimal total = IngresoLogica.Instancia.ObtenerEgresoTotalPorMes(año, mes);
            label2.Text = $"Q {total:N2}";
        }


    }
}

