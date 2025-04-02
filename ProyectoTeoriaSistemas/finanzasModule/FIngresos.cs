using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProyectoTeoriaSistemas.CodigoFuente;

namespace ProyectoTeoriaSistemas.finanzasModule
{
    public partial class FIngresos : Form
    {
        private Tienda _tienda = null;

        public FIngresos(Tienda tienda)
        {
            _tienda = tienda;
            InitializeComponent();
        }

        // Al cargar el formulario, vamos a cargar todos los ingresos en el DataGridView
        private void FIngresos_Load(object sender, EventArgs e)
        {
            // Cargar las ventas de la tienda (historial de ventas)
            CargarVentasEnDataGrid();
            // Llenar ComboBox de Año y Mes (opcional si ya lo tienes preconfigurado)
            LlenarComboBoxAno();
        }

        // Método para cargar las ventas en el DataGridView
        private void CargarVentasEnDataGrid()
        {
            var ventas = _tienda.ObtenerVentas();
            var ventasFiltradas = ventas.Select(v => new
            {
                Fecha = v.Fecha.ToString("yyyy-MM-dd"),
                Cliente = v.Cliente,
                TotalVenta = v.TotalVenta
            }).ToList();

            // Asignar la lista de ventas al DataGridView
            dataGridIngresos.DataSource = ventasFiltradas;
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

            var ventasFiltradas = _tienda.ObtenerIngresosPorFecha(anoSeleccionado, mesSeleccionado)
                .Select(v => new
                {
                    Fecha = v.Fecha.ToString("yyyy-MM-dd"),
                    Cliente = v.Cliente,
                    TotalVenta = v.TotalVenta
                })
                .ToList();

            dataGridIngresos.DataSource = ventasFiltradas;
        }



        // Método que se ejecutará cuando se haga clic en el botón de agregar un nuevo ingreso (venta)
        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            NIngreso nIngreso = new NIngreso(_tienda);
            nIngreso.Show();
        }

        // Método para llenar el ComboBox de Mes con los meses del año
        private void LlenarComboBoxAno()
        {
            cmbBoxAno.Items.Clear();

            var years = _tienda.ObtenerVentas()
                               .Select(v => v.Fecha.Year)
                               .Distinct()
                               .OrderByDescending(y => y)
                               .ToList();

            if (!years.Any())
            {
                years.Add(DateTime.Now.Year);
            }

            foreach (int year in years)
            {
                cmbBoxAno.Items.Add(year);
            }
        }


        private void btnFlujoEfectivo_Click(object sender, EventArgs e)
        {
            //btn para mostrar graficos de comportamiento, de acuerdo a los filtros de los combobox
        }

    }
}


