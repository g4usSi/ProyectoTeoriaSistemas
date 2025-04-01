using System;
using System.Drawing;
using System.Windows.Forms;
using ProyectoTeoriaSistemas.finanzasModule;

namespace ProyectoTeoriaSistemas
{
    public partial class FFinanzas : Form
    {
        private Tienda _tienda = null;
        private Form activeForm = null;
        private Button activeButton = null;

        private Color defaultColor = Color.FromArgb(30, 53, 90);
        private Color hoverColor = Color.FromArgb(45, 73, 120);
        private Color selectedColor = Color.FromArgb(60, 100, 160);

        public FFinanzas(Tienda tienda)
        {
            InitializeComponent();
            _tienda = tienda;
        }

        // Método para abrir formularios dentro del panel
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
            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnIngresos);
            openChildForm(new FIngresos());

        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnEgresos);
            openChildForm(new FEgresos());
        }

        private void btnImpuestos_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnImpuestos);
            openChildForm(new FImpuestos(this._tienda));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReportes);
            openChildForm(new FReportes());
        }

        private void SetActiveButton(Button btn)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = defaultColor;
                activeButton.ForeColor = Color.White;
                activeButton.FlatAppearance.MouseOverBackColor = hoverColor;
            }
            activeButton = btn;
            activeButton.BackColor = selectedColor;
            activeButton.ForeColor = Color.White;
            activeButton.FlatAppearance.MouseOverBackColor = selectedColor;
        }

        private void FFinanzas_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = defaultColor;
                    btn.ForeColor = Color.White;
                    btn.UseVisualStyleBackColor = false;
                    btn.FlatAppearance.MouseOverBackColor = hoverColor;
                }
            }
        }
    }
}

