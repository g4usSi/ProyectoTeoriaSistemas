namespace ProyectoTeoriaSistemas.finanzasModule
{
    partial class FEgresos
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
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxAno = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarIngreso = new System.Windows.Forms.Button();
            this.dataGridEgresos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltro.Location = new System.Drawing.Point(773, 170);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(203, 51);
            this.btnAplicarFiltro.TabIndex = 26;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(768, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 27);
            this.label5.TabIndex = 25;
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
            this.cmbBoxAno.Location = new System.Drawing.Point(773, 140);
            this.cmbBoxAno.Name = "cmbBoxAno";
            this.cmbBoxAno.Size = new System.Drawing.Size(203, 24);
            this.cmbBoxAno.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(773, 392);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.button1.Size = new System.Drawing.Size(203, 154);
            this.button1.TabIndex = 23;
            this.button1.Text = "Flujo de efectivo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIngreso.Location = new System.Drawing.Point(15, 37);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(222, 53);
            this.btnAgregarIngreso.TabIndex = 22;
            this.btnAgregarIngreso.Text = "Agregar Egreso";
            this.btnAgregarIngreso.UseVisualStyleBackColor = true;
            // 
            // dataGridEgresos
            // 
            this.dataGridEgresos.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEgresos.Location = new System.Drawing.Point(15, 109);
            this.dataGridEgresos.Name = "dataGridEgresos";
            this.dataGridEgresos.RowHeadersWidth = 51;
            this.dataGridEgresos.RowTemplate.Height = 24;
            this.dataGridEgresos.Size = new System.Drawing.Size(740, 437);
            this.dataGridEgresos.TabIndex = 21;
            // 
            // FEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 583);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBoxAno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarIngreso);
            this.Controls.Add(this.dataGridEgresos);
            this.Name = "FEgresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FEgresos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEgresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxAno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.DataGridView dataGridEgresos;
    }
}