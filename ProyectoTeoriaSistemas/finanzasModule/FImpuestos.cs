using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoTeoriaSistemas.finanzasModule
{
    public partial class FImpuestos : Form
    {
        private Tienda tienda;
        public FImpuestos(Tienda tienda)
        {

            InitializeComponent();
            this.tienda = tienda;
            RoundedTextBoxHelper.RoundTextBox(textCuadro, 10);
            RoundedTextBoxHelper.RoundTextBox(porcentaje, 10);
            RoundedTextBoxHelper.RoundTextBox(totalImpuesto, 10);
            Tiempo();
        }

        public void Tiempo()
        {
            int currentYear = DateTime.Now.Year;
            for (int year = 2020; year <= currentYear; year++)
            {
                cmbYear.Items.Add(year.ToString());
            }
            cmbMes.Items.AddRange(new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
        }

       
        private void filtrar_Click_1(object sender, EventArgs e)
        {
            if (cmbMes.SelectedItem == null || cmbYear.SelectedItem == null)
    {
        MessageBox.Show("Por favor, llena todos los campos.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
            try
            {
                string mesSeleccionado = cmbMes.SelectedItem.ToString();
                int numeroMes = DateTime.ParseExact(mesSeleccionado, "MMMM", System.Globalization.CultureInfo.CurrentCulture).Month;
                int añoSeleccionado = int.Parse(cmbYear.SelectedItem.ToString());

                int mesActual = DateTime.Now.Month;
                int añoActual = DateTime.Now.Year;

                if (añoSeleccionado > añoActual || (añoSeleccionado == añoActual && numeroMes > mesActual))
                {
                    MessageBox.Show("Fecha inválida. No puedes seleccionar meses o años futuros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener las ventas filtradas
                var ventasDelMes = tienda.ObtenerVentas()
                    .Where(v => v.Fecha.Year == añoSeleccionado && v.Fecha.Month == numeroMes)
                    .ToList();

                // Verificar si hay ventas para ese mes
                if (ventasDelMes.Count == 0)
                {
                    MessageBox.Show("No hay ventas registradas para este mes y año.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null; // Limpiar el DataGridView si no hay datos
                    return;
                }

                // Mostrar las ventas en el DataGridView
                dataGridView1.DataSource = ventasDelMes;

                // Calcular el total de ventas
                double totalVentas = ventasDelMes.Sum(v => v.TotalVenta);



                // Calcular el impuesto
                double impuesto = totalVentas * 0.05;


                // Mostrar los resultados
                totalImpuesto.Text = $"Q {impuesto:F2}";
                sumaVentas.Text = $" Q {totalVentas:F2}";
                porcentaje.Text = "5";
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }

        private void textCuadro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
