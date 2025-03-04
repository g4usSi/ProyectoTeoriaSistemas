namespace ProyectoTeoriaSistemas.CodigoFuente
{
    partial class FPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPlanilla));
            this.cmBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.lblTotalDescuento = new System.Windows.Forms.Label();
            this.lblDevengado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.numHorasExtra = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBonificaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIGSS = new System.Windows.Forms.TextBox();
            this.txtComisiones = new System.Windows.Forms.TextBox();
            this.txtPrestamos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataPlanilla = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSueldosNetos = new System.Windows.Forms.Label();
            this.lblDescuentosGeneral = new System.Windows.Forms.Label();
            this.lblDevengadoGeneral = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlanilla)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmBoxEmpleados
            // 
            this.cmBoxEmpleados.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmBoxEmpleados.FormattingEnabled = true;
            this.cmBoxEmpleados.Location = new System.Drawing.Point(25, 93);
            this.cmBoxEmpleados.Name = "cmBoxEmpleados";
            this.cmBoxEmpleados.Size = new System.Drawing.Size(260, 28);
            this.cmBoxEmpleados.TabIndex = 30;
            this.cmBoxEmpleados.Text = "Seleccione Empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnAgregarEmpleado);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.numHorasExtra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBonificaciones);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmBoxEmpleados);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIGSS);
            this.groupBox1.Controls.Add(this.txtComisiones);
            this.groupBox1.Controls.Add(this.txtPrestamos);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 613);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblSueldoNeto);
            this.panel1.Controls.Add(this.lblTotalDescuento);
            this.panel1.Controls.Add(this.lblDevengado);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(24, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 156);
            this.panel1.TabIndex = 41;
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoNeto.Location = new System.Drawing.Point(269, 105);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(188, 27);
            this.lblSueldoNeto.TabIndex = 42;
            this.lblSueldoNeto.Text = "Q100.00";
            this.lblSueldoNeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalDescuento
            // 
            this.lblTotalDescuento.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDescuento.Location = new System.Drawing.Point(269, 62);
            this.lblTotalDescuento.Name = "lblTotalDescuento";
            this.lblTotalDescuento.Size = new System.Drawing.Size(188, 27);
            this.lblTotalDescuento.TabIndex = 41;
            this.lblTotalDescuento.Text = "Q100.00";
            this.lblTotalDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDevengado
            // 
            this.lblDevengado.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevengado.Location = new System.Drawing.Point(269, 22);
            this.lblDevengado.Name = "lblDevengado";
            this.lblDevengado.Size = new System.Drawing.Size(188, 27);
            this.lblDevengado.TabIndex = 40;
            this.lblDevengado.Text = "Q100.00";
            this.lblDevengado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(30, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 23);
            this.label8.TabIndex = 37;
            this.label8.Text = "Total Devengado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(30, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Total Descuentos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(30, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 23);
            this.label10.TabIndex = 39;
            this.label10.Text = "Sueldo Neto:.......................";
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(210)))), ((int)(((byte)(131)))));
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(344, 86);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(197, 41);
            this.btnAgregarEmpleado.TabIndex = 40;
            this.btnAgregarEmpleado.Text = "Nuevo Empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.Location = new System.Drawing.Point(344, 354);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 41);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCalcular.Location = new System.Drawing.Point(110, 354);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(140, 41);
            this.btnCalcular.TabIndex = 35;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // numHorasExtra
            // 
            this.numHorasExtra.BackColor = System.Drawing.Color.Lavender;
            this.numHorasExtra.Location = new System.Drawing.Point(185, 223);
            this.numHorasExtra.Name = "numHorasExtra";
            this.numHorasExtra.Size = new System.Drawing.Size(352, 26);
            this.numHorasExtra.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(288, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 27);
            this.label7.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(21, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "IGSS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(147, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Calculo de Sueldo";
            // 
            // txtBonificaciones
            // 
            this.txtBonificaciones.BackColor = System.Drawing.Color.Lavender;
            this.txtBonificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBonificaciones.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonificaciones.Location = new System.Drawing.Point(185, 146);
            this.txtBonificaciones.Name = "txtBonificaciones";
            this.txtBonificaciones.Size = new System.Drawing.Size(352, 20);
            this.txtBonificaciones.TabIndex = 10;
            this.txtBonificaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(20, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horas Extra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(21, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comisiones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(20, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bonificaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(20, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prestamos:";
            // 
            // txtIGSS
            // 
            this.txtIGSS.BackColor = System.Drawing.Color.Lavender;
            this.txtIGSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIGSS.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGSS.Location = new System.Drawing.Point(185, 299);
            this.txtIGSS.Name = "txtIGSS";
            this.txtIGSS.Size = new System.Drawing.Size(352, 20);
            this.txtIGSS.TabIndex = 13;
            this.txtIGSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComisiones
            // 
            this.txtComisiones.BackColor = System.Drawing.Color.Lavender;
            this.txtComisiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComisiones.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComisiones.Location = new System.Drawing.Point(185, 185);
            this.txtComisiones.Name = "txtComisiones";
            this.txtComisiones.Size = new System.Drawing.Size(352, 20);
            this.txtComisiones.TabIndex = 11;
            this.txtComisiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrestamos
            // 
            this.txtPrestamos.BackColor = System.Drawing.Color.Lavender;
            this.txtPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrestamos.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrestamos.Location = new System.Drawing.Point(185, 262);
            this.txtPrestamos.Name = "txtPrestamos";
            this.txtPrestamos.Size = new System.Drawing.Size(352, 20);
            this.txtPrestamos.TabIndex = 12;
            this.txtPrestamos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(818, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(350, 49);
            this.label11.TabIndex = 32;
            this.label11.Text = "Planilla General";
            // 
            // dataPlanilla
            // 
            this.dataPlanilla.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPlanilla.Location = new System.Drawing.Point(616, 145);
            this.dataPlanilla.Name = "dataPlanilla";
            this.dataPlanilla.RowHeadersWidth = 51;
            this.dataPlanilla.RowTemplate.Height = 24;
            this.dataPlanilla.Size = new System.Drawing.Size(737, 319);
            this.dataPlanilla.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label12.Location = new System.Drawing.Point(22, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(301, 27);
            this.label12.TabIndex = 38;
            this.label12.Text = "Total Devengado General";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(24, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(299, 27);
            this.label13.TabIndex = 39;
            this.label13.Text = "Total Descuentos General";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label14.Location = new System.Drawing.Point(24, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(228, 27);
            this.label14.TabIndex = 40;
            this.label14.Text = "Total Sueldos Netos";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblSueldosNetos);
            this.panel2.Controls.Add(this.lblDescuentosGeneral);
            this.panel2.Controls.Add(this.lblDevengadoGeneral);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(634, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 144);
            this.panel2.TabIndex = 41;
            // 
            // lblSueldosNetos
            // 
            this.lblSueldosNetos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldosNetos.Location = new System.Drawing.Point(485, 97);
            this.lblSueldosNetos.Name = "lblSueldosNetos";
            this.lblSueldosNetos.Size = new System.Drawing.Size(188, 27);
            this.lblSueldosNetos.TabIndex = 43;
            this.lblSueldosNetos.Text = "Q100.00";
            this.lblSueldosNetos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescuentosGeneral
            // 
            this.lblDescuentosGeneral.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentosGeneral.Location = new System.Drawing.Point(485, 57);
            this.lblDescuentosGeneral.Name = "lblDescuentosGeneral";
            this.lblDescuentosGeneral.Size = new System.Drawing.Size(188, 27);
            this.lblDescuentosGeneral.TabIndex = 42;
            this.lblDescuentosGeneral.Text = "Q100.00";
            this.lblDescuentosGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDevengadoGeneral
            // 
            this.lblDevengadoGeneral.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevengadoGeneral.Location = new System.Drawing.Point(485, 14);
            this.lblDevengadoGeneral.Name = "lblDevengadoGeneral";
            this.lblDevengadoGeneral.Size = new System.Drawing.Size(188, 27);
            this.lblDevengadoGeneral.TabIndex = 41;
            this.lblDevengadoGeneral.Text = "Q100.00";
            this.lblDevengadoGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1378, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataPlanilla);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FPlanilla";
            this.Text = "FPlanilla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlanilla)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmBoxEmpleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBonificaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIGSS;
        private System.Windows.Forms.TextBox txtComisiones;
        private System.Windows.Forms.TextBox txtPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numHorasExtra;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataPlanilla;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.Label lblTotalDescuento;
        private System.Windows.Forms.Label lblDevengado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSueldosNetos;
        private System.Windows.Forms.Label lblDescuentosGeneral;
        private System.Windows.Forms.Label lblDevengadoGeneral;
    }
}