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
        public FImpuestos()
        {
            InitializeComponent();
            RoundedTextBoxHelper.RoundTextBox(textCuadro, 10);
            RoundedTextBoxHelper.RoundTextBox(textBox2, 10);
            RoundedTextBoxHelper.RoundTextBox(textBox3, 10);
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

        private void filtrar_Click(object sender, EventArgs e)
        {
            if (cmbMes.SelectedItem == null || cmbYear.SelectedItem == null)
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si el mes no está seleccionado
            }
            try
            {
                string mesSeleccionado = cmbMes.SelectedItem.ToString();
                int numeroMes = DateTime.ParseExact(mesSeleccionado, "MMMM", System.Globalization.CultureInfo.CurrentCulture).Month;
                int añoSeleccionado = int.Parse(cmbYear.SelectedItem.ToString()); // Se usa el año seleccionado

                // Obtiene el mes y año actuales
                int mesActual = DateTime.Now.Month;
                int añoActual = DateTime.Now.Year;

                // Verifica si el año seleccionado es mayor al actual
                if (añoSeleccionado > añoActual)
                {
                    MessageBox.Show("El año seleccionado es inválido.", "Año futuro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del método sin filtrar
                }

                // Si el año es el actual, se compara el mes seleccionado con el mes actual
                if (añoSeleccionado == añoActual && numeroMes > mesActual)
                {
                    MessageBox.Show("El mes seleccionado es inválido.", "Mes futuro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del método sin filtrar
                }

                // Aquí debes agregar tu lógica de filtrado.
                // Ejemplo: Si tus datos están en un DataTable llamado "datos", puedes filtrarlos así:
                // datos.DefaultView.RowFilter = $"MONTH(fecha) = {numeroMes} AND YEAR(fecha) = {añoSeleccionado}";
                // Donde "fecha" es el nombre de la columna de fecha en tu DataTable.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
