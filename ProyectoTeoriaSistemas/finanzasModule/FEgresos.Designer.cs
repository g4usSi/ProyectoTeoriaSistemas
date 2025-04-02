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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarIngreso = new System.Windows.Forms.Button();
            this.dataGridEgresos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxMes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxAno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltro.Location = new System.Drawing.Point(776, 419);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(203, 51);
            this.btnAplicarFiltro.TabIndex = 26;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 109);
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
            this.btnAgregarIngreso.Location = new System.Drawing.Point(776, 493);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(203, 53);
            this.btnAgregarIngreso.TabIndex = 22;
            this.btnAgregarIngreso.Text = "Agregar Egreso";
            this.btnAgregarIngreso.UseVisualStyleBackColor = true;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarIngreso_Click);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(12, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 49);
            this.label11.TabIndex = 46;
            this.label11.Text = "Egresos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(771, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 59;
            this.label1.Text = "Mes:";
            // 
            // cmbBoxMes
            // 
            this.cmbBoxMes.FormattingEnabled = true;
            this.cmbBoxMes.Location = new System.Drawing.Point(776, 331);
            this.cmbBoxMes.Name = "cmbBoxMes";
            this.cmbBoxMes.Size = new System.Drawing.Size(203, 24);
            this.cmbBoxMes.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(771, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 27);
            this.label5.TabIndex = 57;
            this.label5.Text = "Año:";
            // 
            // cmbBoxAno
            // 
            this.cmbBoxAno.FormattingEnabled = true;
            this.cmbBoxAno.Location = new System.Drawing.Point(776, 388);
            this.cmbBoxAno.Name = "cmbBoxAno";
            this.cmbBoxAno.Size = new System.Drawing.Size(203, 24);
            this.cmbBoxAno.TabIndex = 56;
            // 
            // FEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxMes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBoxAno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAplicarFiltro);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.DataGridView dataGridEgresos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxMes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxAno;
    }
}