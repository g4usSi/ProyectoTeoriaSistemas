namespace ProyectoTeoriaSistemas.finanzasModule
{
    partial class FImpuestos
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
            this.textCuadro = new System.Windows.Forms.TextBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.filtrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sumaVentas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.porcentaje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalImpuesto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textCuadro
            // 
            this.textCuadro.BackColor = System.Drawing.Color.White;
            this.textCuadro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCuadro.Location = new System.Drawing.Point(30, 71);
            this.textCuadro.Multiline = true;
            this.textCuadro.Name = "textCuadro";
            this.textCuadro.ReadOnly = true;
            this.textCuadro.Size = new System.Drawing.Size(938, 489);
            this.textCuadro.TabIndex = 38;
            this.textCuadro.TextChanged += new System.EventHandler(this.textCuadro_TextChanged);
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(445, 105);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 24);
            this.cmbMes.TabIndex = 39;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(586, 105);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 40;
            // 
            // filtrar
            // 
            this.filtrar.BackColor = System.Drawing.Color.Gold;
            this.filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filtrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrar.Location = new System.Drawing.Point(734, 101);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(113, 30);
            this.filtrar.TabIndex = 41;
            this.filtrar.Text = "Filtrar";
            this.filtrar.UseVisualStyleBackColor = false;
            this.filtrar.Click += new System.EventHandler(this.filtrar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(477, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(621, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Año";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(32, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 49);
            this.label11.TabIndex = 44;
            this.label11.Text = "Impuestos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(54, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Pequeño Contribuyente";
            // 
            // sumaVentas
            // 
            this.sumaVentas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sumaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sumaVentas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumaVentas.Location = new System.Drawing.Point(58, 192);
            this.sumaVentas.Multiline = true;
            this.sumaVentas.Name = "sumaVentas";
            this.sumaVentas.Size = new System.Drawing.Size(292, 52);
            this.sumaVentas.TabIndex = 46;
            this.sumaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(54, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(54, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "% de impuesto";
            // 
            // porcentaje
            // 
            this.porcentaje.BackColor = System.Drawing.Color.Lavender;
            this.porcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.porcentaje.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje.Location = new System.Drawing.Point(58, 287);
            this.porcentaje.Multiline = true;
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(292, 52);
            this.porcentaje.TabIndex = 49;
            this.porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(54, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "Total de impuesto";
            // 
            // totalImpuesto
            // 
            this.totalImpuesto.BackColor = System.Drawing.Color.Lavender;
            this.totalImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalImpuesto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalImpuesto.Location = new System.Drawing.Point(58, 396);
            this.totalImpuesto.Multiline = true;
            this.totalImpuesto.Name = "totalImpuesto";
            this.totalImpuesto.Size = new System.Drawing.Size(292, 52);
            this.totalImpuesto.TabIndex = 51;
            this.totalImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 317);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FImpuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalImpuesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sumaVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filtrar);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.textCuadro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FImpuestos";
            this.Text = "FImpuestos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textCuadro;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button filtrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sumaVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox porcentaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalImpuesto;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}