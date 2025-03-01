using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public partial class FPlanilla : Form
    {
        public FPlanilla()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            cmBoxEmpleados.Items.Clear();

            foreach (var empleado in EmpleadoData.ListaEmpleados)
            {
                cmBoxEmpleados.Items.Add($"{empleado.Nombre} - Q{empleado.Sueldo}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado empleadoForm = new Empleado();
            empleadoForm.OnEmpleadoGuardado += CargarEmpleados;
            empleadoForm.Show();
        }
    }


}
