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
            try
            {
                string mesSeleccionado = cmbMes.SelectedItem?.ToString();
                string añoSeleccionado = cmbYear.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(mesSeleccionado) || string.IsNullOrEmpty(añoSeleccionado))
                {
                    MessageBox.Show("Debe seleccionar un mes y un año.");
                    return;
                }

                // Diccionario para mapear nombres de meses en español a sus valores numéricos
                Dictionary<string, int> meses = new Dictionary<string, int>()
        {
            { "Enero", 1 },
            { "Febrero", 2 },
            { "Marzo", 3 },
            { "Abril", 4 },
            { "Mayo", 5 },
            { "Junio", 6 },
            { "Julio", 7 },
            { "Agosto", 8 },
            { "Septiembre", 9 },
            { "Octubre", 10 },
            { "Noviembre", 11 },
            { "Diciembre", 12 }
        };

                int numeroMes = meses[mesSeleccionado];
                int año = int.Parse(añoSeleccionado);

                double suma = 0;

                foreach (DataGridViewRow fila in dtaFacturasExt.Rows)
                {
                    if (fila.Cells["FechaVenta"].Value != null && DateTime.TryParse(fila.Cells["FechaVenta"].Value.ToString(), out DateTime fechaVenta))
                    {
                        if (fechaVenta.Month == numeroMes && fechaVenta.Year == año)
                        {
                            // Asegúrate de que la columna se llama "Total"
                            if (fila.Cells["Total"].Value != null && double.TryParse(fila.Cells["Total"].Value.ToString(), out double totalVenta))
                            {
                                suma += totalVenta;
                            }
                        }
                    }
                }

                sumaVentas.Text = suma.ToString("N2"); // Muestra el total con 2 decimales
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
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
