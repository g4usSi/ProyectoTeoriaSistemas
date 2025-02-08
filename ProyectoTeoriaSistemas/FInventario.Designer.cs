namespace ProyectoTeoriaSistemas
{
    partial class FInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInventario));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.salir = new System.Windows.Forms.Button();
            this.proveedores = new System.Windows.Forms.Button();
            this.Reportes = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Top = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.splitContainer1.Panel1.Controls.Add(this.salir);
            this.splitContainer1.Panel1.Controls.Add(this.proveedores);
            this.splitContainer1.Panel1.Controls.Add(this.Reportes);
            this.splitContainer1.Panel1.Controls.Add(this.Producto);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.Top);
            this.splitContainer1.Size = new System.Drawing.Size(1782, 803);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(0, 753);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(269, 50);
            this.salir.TabIndex = 8;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            // 
            // proveedores
            // 
            this.proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedores.ForeColor = System.Drawing.Color.White;
            this.proveedores.Location = new System.Drawing.Point(27, 347);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(180, 50);
            this.proveedores.TabIndex = 7;
            this.proveedores.Text = "Proveedores";
            this.proveedores.UseVisualStyleBackColor = false;
            // 
            // Reportes
            // 
            this.Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.ForeColor = System.Drawing.Color.White;
            this.Reportes.Location = new System.Drawing.Point(27, 434);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(180, 50);
            this.Reportes.TabIndex = 6;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = false;
            // 
            // Producto
            // 
            this.Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.ForeColor = System.Drawing.Color.White;
            this.Producto.Location = new System.Drawing.Point(27, 254);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(180, 51);
            this.Producto.TabIndex = 5;
            this.Producto.Text = "Producto";
            this.Producto.UseVisualStyleBackColor = false;
            this.Producto.Click += new System.EventHandler(this.Producto_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(210)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(19, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "BizFlow";
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.Top.Controls.Add(this.Titulo);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(1509, 80);
            this.Top.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(1509, 80);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Modulo Inventario";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1782, 803);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FInventario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Inventario";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.Button Reportes;
        private System.Windows.Forms.Button proveedores;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Label Titulo;
        protected System.Windows.Forms.Button salir;
    }
}