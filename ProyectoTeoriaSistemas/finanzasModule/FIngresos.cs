using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProyectoTeoriaSistemas.CodigoFuente;
using ProyectoTeoriaSistemas.ventasModule;

namespace ProyectoTeoriaSistemas.finanzasModule
{
    public partial class FIngresos : Form
    {

        public FIngresos()
        {
            InitializeComponent();
        }

        // Al cargar el formulario, vamos a cargar todos los ingresos en el DataGridView
        private void FIngresos_Load(object sender, EventArgs e)
        {
            // Cargar las ventas de la tienda (historial de ventas) desde el SQL
            CargarVentasEnDataGrid();
            // Llenar ComboBox de Año y Mes (opcional si ya lo tienes preconfigurado)
            LlenarComboBoxAno();
        }

        // Método para cargar las ventas en el DataGridView
        private void CargarVentasEnDataGrid()
        {
            /*
             * Aquí se obtienen todas las ventas de la tienda y se asignan al DataGridView.
             * Se puede filtrar por año y mes si se desea.
             */

            /*
             * Cargar las ventas desde la base de datos
             * 
            var ventas = _tienda.ObtenerVentas();
            var ventasFiltradas = ventas.Select(v => new
            {
                Fecha = v.Fecha.ToString("yyyy-MM-dd"),
                Cliente = v.Cliente,
                TotalVenta = v.TotalVenta
            }).ToList();

            // Asignar la lista de ventas al DataGridView
            dataGridIngresos.DataSource = ventasFiltradas;
            */



        }

        // Este botón aplicará los filtros para mostrar solo las ventas del año y mes seleccionados
        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            if (cmbBoxAno.SelectedItem == null || cmbBoxMes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un año y un mes para aplicar el filtro.");
                return;
            }

            int anoSeleccionado = int.Parse(cmbBoxAno.SelectedItem.ToString());
            int mesSeleccionado = cmbBoxMes.SelectedIndex + 1;

            mostrarDetallesVenta(anoSeleccionado, mesSeleccionado);
            MostrarTotalEnLabel(anoSeleccionado, mesSeleccionado);
        }



        // Método que se ejecutará cuando se haga clic en el botón de agregar un nuevo ingreso (venta)
        private void btnAgregarIngreso_Click_1(object sender, EventArgs e)
        {
            NIngreso nIngreso = new NIngreso();
            nIngreso.Show();
        }

        // Método para llenar el ComboBox de Mes con los meses del año
        private void LlenarComboBoxAno()
        {



        }


        private void btnFlujoEfectivo_Click(object sender, EventArgs e)
        {
            //btn para mostrar graficos de comportamiento, de acuerdo a los filtros de los combobox
        }

        public void mostrarDetallesVenta(int año, int mes)
        {
            dataGridIngresos.DataSource = null;
            dataGridIngresos.DataSource = DetallesDeFacturaLogica.Instancia.ListarPorFecha(año, mes);
        }

        public void MostrarTotalEnLabel(int año, int mes)
        {
            decimal total = DetallesDeFacturaLogica.Instancia.ObtenerTotalDeVentasPorMes(año, mes);
            label2.Text = $"Q {total:N2}";
        }

    }
}


