namespace ProyectoTeoriaSistemas
{
    partial class FVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVentas));
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboDatos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTipoCompr = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataFacturaTabla = new System.Windows.Forms.DataGridView();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturaTabla)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNotificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNotificacion.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.lblNotificacion.Location = new System.Drawing.Point(0, 0);
            this.lblNotificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(1168, 65);
            this.lblNotificacion.TabIndex = 26;
            this.lblNotificacion.Text = "Ventas";
            this.lblNotificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNIT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NumericUpDown);
            this.groupBox1.Controls.Add(this.comboDatos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txtNumeroFactura);
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboTipoCompr);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1105, 201);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(448, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Cant:.";
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(520, 136);
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(62, 26);
            this.NumericUpDown.TabIndex = 33;
            // 
            // comboDatos
            // 
            this.comboDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDatos.FormattingEnabled = true;
            this.comboDatos.Items.AddRange(new object[] {
            "Factura",
            "Recibo"});
            this.comboDatos.Location = new System.Drawing.Point(176, 134);
            this.comboDatos.Name = "comboDatos";
            this.comboDatos.Size = new System.Drawing.Size(259, 28);
            this.comboDatos.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(35, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Producto (*):";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(764, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 64);
            this.panel2.TabIndex = 29;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(89, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(188, 27);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Q100.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BackColor = System.Drawing.Color.Lavender;
            this.txtNumeroFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(772, 93);
            this.txtNumeroFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(292, 20);
            this.txtNumeroFactura.TabIndex = 25;
            this.txtNumeroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.SkyBlue;
            this.Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.ForeColor = System.Drawing.Color.White;
            this.Agregar.Location = new System.Drawing.Point(590, 128);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(160, 40);
            this.Agregar.TabIndex = 22;
            this.Agregar.Text = "Agregar Articulo";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(649, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Numero(*):";
            // 
            // comboTipoCompr
            // 
            this.comboTipoCompr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoCompr.FormattingEnabled = true;
            this.comboTipoCompr.Items.AddRange(new object[] {
            "Factura",
            "Ticket"});
            this.comboTipoCompr.Location = new System.Drawing.Point(253, 90);
            this.comboTipoCompr.Name = "comboTipoCompr";
            this.comboTipoCompr.Size = new System.Drawing.Size(388, 28);
            this.comboTipoCompr.TabIndex = 23;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.Lavender;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(154, 50);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(445, 20);
            this.txtCliente.TabIndex = 10;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente(*):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(843, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(35, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo Comprobate(*):";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.Lavender;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(942, 51);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(122, 20);
            this.txtFecha.TabIndex = 11;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(10, 233);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 50);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(10, 14);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 50);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataFacturaTabla
            // 
            this.dataFacturaTabla.AllowUserToDeleteRows = false;
            this.dataFacturaTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFacturaTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataFacturaTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataFacturaTabla.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataFacturaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFacturaTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Precio,
            this.ID,
            this.Producto,
            this.marca,
            this.SubTotal});
            this.dataFacturaTabla.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataFacturaTabla.Location = new System.Drawing.Point(52, 291);
            this.dataFacturaTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dataFacturaTabla.MultiSelect = false;
            this.dataFacturaTabla.Name = "dataFacturaTabla";
            this.dataFacturaTabla.RowHeadersWidth = 51;
            this.dataFacturaTabla.RowTemplate.Height = 24;
            this.dataFacturaTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFacturaTabla.Size = new System.Drawing.Size(839, 354);
            this.dataFacturaTabla.TabIndex = 21;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Cantidad";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 121;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 57;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 116;
            // 
            // marca
            // 
            this.marca.HeaderText = "Precio";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            this.marca.Width = 90;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 115;
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRealizarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRealizarVenta.Location = new System.Drawing.Point(10, 291);
            this.btnRealizarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(180, 50);
            this.btnRealizarVenta.TabIndex = 27;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRealizarVenta);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(919, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 354);
            this.panel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 154);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtNIT
            // 
            this.txtNIT.BackColor = System.Drawing.Color.Lavender;
            this.txtNIT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIT.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIT.Location = new System.Drawing.Point(672, 50);
            this.txtNIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(143, 20);
            this.txtNIT.TabIndex = 35;
            this.txtNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(619, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "NIT:";
            // 
            // FVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNotificacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataFacturaTabla);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FVentas";
            this.Text = "FVentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturaTabla)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNotificacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.DataGridView dataFacturaTabla;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTipoCompr;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.ComboBox comboDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNIT;
    }
}