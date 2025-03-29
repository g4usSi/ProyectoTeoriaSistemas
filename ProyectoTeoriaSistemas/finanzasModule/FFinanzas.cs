using System;
using System.Windows.Forms;
using ProyectoTeoriaSistemas.finanzasModule;

namespace ProyectoTeoriaSistemas
{
    public partial class FFinanzas : Form
    {
        private Form activeForm = null;

        public FFinanzas()
        {
            InitializeComponent();
        }

        //No tocar :V este metodo es para abrir los formularios dentro del panel
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            openChildForm(new FIngresos());
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            openChildForm(new FEgresos());
        }

        private void btnImpuestos_Click(object sender, EventArgs e)
        {
            openChildForm(new FImpuestos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            openChildForm(new FReportes());
        }
    }
}
