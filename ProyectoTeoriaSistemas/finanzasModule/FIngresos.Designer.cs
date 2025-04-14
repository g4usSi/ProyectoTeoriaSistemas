namespace ProyectoTeoriaSistemas.finanzasModule
{
    partial class FIngresos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxAno = new System.Windows.Forms.ComboBox();
            this.btnFlujoEfectivo = new System.Windows.Forms.Button();
            this.btnAgregarIngreso = new System.Windows.Forms.Button();
            this.dataGridIngresos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxMes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(18, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 49);
            this.label11.TabIndex = 53;
            this.label11.Text = "Ingresos";
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltro.Location = new System.Drawing.Point(782, 412);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(203, 51);
            this.btnAplicarFiltro.TabIndex = 52;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(777, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "Año:";
            // 
            // cmbBoxAno
            // 
            this.cmbBoxAno.FormattingEnabled = true;
            this.cmbBoxAno.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbBoxAno.Location = new System.Drawing.Point(782, 382);
            this.cmbBoxAno.Name = "cmbBoxAno";
            this.cmbBoxAno.Size = new System.Drawing.Size(203, 24);
            this.cmbBoxAno.TabIndex = 50;
            // 
            // btnFlujoEfectivo
            // 
            this.btnFlujoEfectivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlujoEfectivo.Location = new System.Drawing.Point(782, 108);
            this.btnFlujoEfectivo.Name = "btnFlujoEfectivo";
            this.btnFlujoEfectivo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btnFlujoEfectivo.Size = new System.Drawing.Size(203, 154);
            this.btnFlujoEfectivo.TabIndex = 49;
            this.btnFlujoEfectivo.Text = "Flujo de efectivo";
            this.btnFlujoEfectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFlujoEfectivo.UseVisualStyleBackColor = true;
            this.btnFlujoEfectivo.Click += new System.EventHandler(this.btnFlujoEfectivo_Click);
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIngreso.Location = new System.Drawing.Point(782, 492);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(203, 53);
            this.btnAgregarIngreso.TabIndex = 48;
            this.btnAgregarIngreso.Text = "Agregar Ingreso";
            this.btnAgregarIngreso.UseVisualStyleBackColor = true;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarIngreso_Click_1);
            // 
            // dataGridIngresos
            // 
            this.dataGridIngresos.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIngresos.Location = new System.Drawing.Point(21, 108);
            this.dataGridIngresos.Name = "dataGridIngresos";
            this.dataGridIngresos.RowHeadersWidth = 51;
            this.dataGridIngresos.RowTemplate.Height = 24;
            this.dataGridIngresos.Size = new System.Drawing.Size(740, 437);
            this.dataGridIngresos.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(777, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mes:";
            // 
            // cmbBoxMes
            // 
            this.cmbBoxMes.FormattingEnabled = true;
            this.cmbBoxMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbBoxMes.Location = new System.Drawing.Point(782, 325);
            this.cmbBoxMes.Name = "cmbBoxMes";
            this.cmbBoxMes.Size = new System.Drawing.Size(203, 24);
            this.cmbBoxMes.TabIndex = 54;
            // 
            // FIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxMes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBoxAno);
            this.Controls.Add(this.btnFlujoEfectivo);
            this.Controls.Add(this.btnAgregarIngreso);
            this.Controls.Add(this.dataGridIngresos);
            this.Name = "FIngresos";
            this.Text = "childReporte";
            this.Load += new System.EventHandler(this.FIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxAno;
        private System.Windows.Forms.Button btnFlujoEfectivo;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.DataGridView dataGridIngresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxMes;
    }
}