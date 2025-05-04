using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas.finanzasModule
{
    public partial class FImpuestos : Form
    {
        public FImpuestos()
        {
            InitializeComponent();
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
            cmbMes.Items.AddRange(new string[] {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            });
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

                // Lógica eliminada

                MessageBox.Show("Simulación de filtro completada.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Simulación visual
                dataGridView1.DataSource = null;
                totalImpuesto.Text = "Q 0.00";
                sumaVentas.Text = "Q 0.00";
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

        private void FImpuestos_Load(object sender, EventArgs e)
        {

        }
    }
}
