namespace Boutique1
{
    partial class Form_Venta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.dgVenta = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigoArt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bCancelarArticulo = new System.Windows.Forms.Button();
            this.bBuscarCliente = new System.Windows.Forms.Button();
            this.bEnviar = new System.Windows.Forms.Button();
            this.bBuscarArticulo = new System.Windows.Forms.Button();
            this.bDescuento = new System.Windows.Forms.Button();
            this.bReimprimir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio:";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(69, 16);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(160, 20);
            this.txtIdVenta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(152, 42);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(403, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(69, 42);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(77, 20);
            this.txtIDCliente.TabIndex = 4;
            // 
            // dgVenta
            // 
            this.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Importe,
            this.Almacen});
            this.dgVenta.Location = new System.Drawing.Point(23, 80);
            this.dgVenta.Name = "dgVenta";
            this.dgVenta.Size = new System.Drawing.Size(544, 262);
            this.dgVenta.TabIndex = 5;
            this.dgVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Almacen
            // 
            this.Almacen.HeaderText = "Almacen";
            this.Almacen.Name = "Almacen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtCodigoArt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(64, 51);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(77, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtCodigoArt
            // 
            this.txtCodigoArt.Location = new System.Drawing.Point(64, 16);
            this.txtCodigoArt.Name = "txtCodigoArt";
            this.txtCodigoArt.Size = new System.Drawing.Size(77, 20);
            this.txtCodigoArt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(283, 364);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(112, 13);
            this.lbFecha.TabIndex = 10;
            this.lbFecha.Text = "13/11/2015  12:14pm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(574, 74);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 44);
            this.bNuevo.TabIndex = 12;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            // 
            // bCancelarArticulo
            // 
            this.bCancelarArticulo.Location = new System.Drawing.Point(574, 120);
            this.bCancelarArticulo.Name = "bCancelarArticulo";
            this.bCancelarArticulo.Size = new System.Drawing.Size(75, 44);
            this.bCancelarArticulo.TabIndex = 13;
            this.bCancelarArticulo.Text = "Cancelar Articulo";
            this.bCancelarArticulo.UseVisualStyleBackColor = true;
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Location = new System.Drawing.Point(574, 166);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(75, 44);
            this.bBuscarCliente.TabIndex = 14;
            this.bBuscarCliente.Text = "Buscar Cliente";
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // bEnviar
            // 
            this.bEnviar.Location = new System.Drawing.Point(516, 369);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(126, 53);
            this.bEnviar.TabIndex = 15;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            // 
            // bBuscarArticulo
            // 
            this.bBuscarArticulo.Location = new System.Drawing.Point(574, 212);
            this.bBuscarArticulo.Name = "bBuscarArticulo";
            this.bBuscarArticulo.Size = new System.Drawing.Size(75, 44);
            this.bBuscarArticulo.TabIndex = 16;
            this.bBuscarArticulo.Text = "Buscar Articulo";
            this.bBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // bDescuento
            // 
            this.bDescuento.Location = new System.Drawing.Point(574, 258);
            this.bDescuento.Name = "bDescuento";
            this.bDescuento.Size = new System.Drawing.Size(75, 44);
            this.bDescuento.TabIndex = 17;
            this.bDescuento.Text = "% Descuento";
            this.bDescuento.UseVisualStyleBackColor = true;
            this.bDescuento.Click += new System.EventHandler(this.bDescuento_Click);
            // 
            // bReimprimir
            // 
            this.bReimprimir.Location = new System.Drawing.Point(574, 304);
            this.bReimprimir.Name = "bReimprimir";
            this.bReimprimir.Size = new System.Drawing.Size(75, 44);
            this.bReimprimir.TabIndex = 18;
            this.bReimprimir.Text = "Reimprimir";
            this.bReimprimir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(286, 401);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dgVenta);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtIdVenta);
            this.panel1.Controls.Add(this.bReimprimir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bDescuento);
            this.panel1.Controls.Add(this.txtNombreCliente);
            this.panel1.Controls.Add(this.bBuscarArticulo);
            this.panel1.Controls.Add(this.txtIDCliente);
            this.panel1.Controls.Add(this.bEnviar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bBuscarCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bCancelarArticulo);
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.bNuevo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 495);
            this.panel1.TabIndex = 20;
            // 
            // Form_Venta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(686, 495);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Venta";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.DataGridView dgVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCodigoArt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bCancelarArticulo;
        private System.Windows.Forms.Button bBuscarCliente;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Button bBuscarArticulo;
        private System.Windows.Forms.Button bDescuento;
        private System.Windows.Forms.Button bReimprimir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel1;
    }
}