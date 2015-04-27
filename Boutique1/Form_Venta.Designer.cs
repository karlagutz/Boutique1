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
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
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
            this.txtIdVenta.ReadOnly = true;
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
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(403, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(69, 42);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(77, 20);
            this.txtIDCliente.TabIndex = 4;
            // 
            // dgVenta
            // 
            this.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Importe,
            this.Almacen});
            this.dgVenta.Location = new System.Drawing.Point(24, 74);
            this.dgVenta.Name = "dgVenta";
            this.dgVenta.Size = new System.Drawing.Size(544, 262);
            this.dgVenta.TabIndex = 5;
            this.dgVenta.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgVenta_UserAddedRow);
            this.dgVenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgVenta_MouseDown);
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
            this.bCancelarArticulo.Click += new System.EventHandler(this.bCancelarArticulo_Click);
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Location = new System.Drawing.Point(574, 166);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(75, 44);
            this.bBuscarCliente.TabIndex = 14;
            this.bBuscarCliente.Text = "Buscar Cliente";
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            this.bBuscarCliente.Click += new System.EventHandler(this.bBuscarCliente_Click);
            // 
            // bEnviar
            // 
            this.bEnviar.Location = new System.Drawing.Point(516, 369);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(126, 53);
            this.bEnviar.TabIndex = 15;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // bBuscarArticulo
            // 
            this.bBuscarArticulo.Location = new System.Drawing.Point(574, 212);
            this.bBuscarArticulo.Name = "bBuscarArticulo";
            this.bBuscarArticulo.Size = new System.Drawing.Size(75, 44);
            this.bBuscarArticulo.TabIndex = 16;
            this.bBuscarArticulo.Text = "Buscar Articulo";
            this.bBuscarArticulo.UseVisualStyleBackColor = true;
            this.bBuscarArticulo.Click += new System.EventHandler(this.bBuscarArticulo_Click);
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
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Id_Articulo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Almacen
            // 
            this.Almacen.HeaderText = "Almacen";
            this.Almacen.Name = "Almacen";
            this.Almacen.ReadOnly = true;
            // 
            // Form_Venta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(686, 495);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Venta";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
    }
}