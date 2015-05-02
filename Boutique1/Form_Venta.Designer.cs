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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cbModoPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.lbCambio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio:";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(98, 10);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.ReadOnly = true;
            this.txtIdVenta.Size = new System.Drawing.Size(160, 20);
            this.txtIdVenta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(181, 36);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(403, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(98, 36);
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
            this.dgVenta.Location = new System.Drawing.Point(24, 102);
            this.dgVenta.Name = "dgVenta";
            this.dgVenta.Size = new System.Drawing.Size(544, 262);
            this.dgVenta.TabIndex = 5;
            this.dgVenta.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgVenta_UserAddedRow);
            this.dgVenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgVenta_MouseDown);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(96, 382);
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
            this.bNuevo.Location = new System.Drawing.Point(574, 102);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 44);
            this.bNuevo.TabIndex = 12;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bCancelarArticulo
            // 
            this.bCancelarArticulo.Location = new System.Drawing.Point(574, 148);
            this.bCancelarArticulo.Name = "bCancelarArticulo";
            this.bCancelarArticulo.Size = new System.Drawing.Size(75, 44);
            this.bCancelarArticulo.TabIndex = 13;
            this.bCancelarArticulo.Text = "Cancelar Articulo";
            this.bCancelarArticulo.UseVisualStyleBackColor = true;
            this.bCancelarArticulo.Click += new System.EventHandler(this.bCancelarArticulo_Click);
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Location = new System.Drawing.Point(574, 194);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(75, 44);
            this.bBuscarCliente.TabIndex = 14;
            this.bBuscarCliente.Text = "Buscar Cliente";
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            this.bBuscarCliente.Click += new System.EventHandler(this.bBuscarCliente_Click);
            // 
            // bEnviar
            // 
            this.bEnviar.Location = new System.Drawing.Point(523, 382);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(126, 53);
            this.bEnviar.TabIndex = 15;
            this.bEnviar.Text = "Pagar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // bBuscarArticulo
            // 
            this.bBuscarArticulo.Location = new System.Drawing.Point(574, 240);
            this.bBuscarArticulo.Name = "bBuscarArticulo";
            this.bBuscarArticulo.Size = new System.Drawing.Size(75, 44);
            this.bBuscarArticulo.TabIndex = 16;
            this.bBuscarArticulo.Text = "Buscar Articulo";
            this.bBuscarArticulo.UseVisualStyleBackColor = true;
            this.bBuscarArticulo.Click += new System.EventHandler(this.bBuscarArticulo_Click);
            // 
            // bDescuento
            // 
            this.bDescuento.Location = new System.Drawing.Point(574, 286);
            this.bDescuento.Name = "bDescuento";
            this.bDescuento.Size = new System.Drawing.Size(75, 44);
            this.bDescuento.TabIndex = 17;
            this.bDescuento.Text = "% Descuento";
            this.bDescuento.UseVisualStyleBackColor = true;
            this.bDescuento.Click += new System.EventHandler(this.bDescuento_Click);
            // 
            // bReimprimir
            // 
            this.bReimprimir.Location = new System.Drawing.Point(574, 332);
            this.bReimprimir.Name = "bReimprimir";
            this.bReimprimir.Size = new System.Drawing.Size(75, 44);
            this.bReimprimir.TabIndex = 18;
            this.bReimprimir.Text = "Reimprimir";
            this.bReimprimir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(98, 415);
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
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbCambio);
            this.panel1.Controls.Add(this.txtPago);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbModoPago);
            this.panel1.Controls.Add(this.label3);
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
            // cbModoPago
            // 
            this.cbModoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModoPago.FormattingEnabled = true;
            this.cbModoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito/Debito",
            "Credito de cliente"});
            this.cbModoPago.Location = new System.Drawing.Point(98, 62);
            this.cbModoPago.Name = "cbModoPago";
            this.cbModoPago.Size = new System.Drawing.Size(297, 21);
            this.cbModoPago.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Modo de Pago:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cambio:";
            // 
            // txtPago
            // 
            this.txtPago.Enabled = false;
            this.txtPago.Location = new System.Drawing.Point(347, 415);
            this.txtPago.MaxLength = 11;
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 20);
            this.txtPago.TabIndex = 25;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.ForeColor = System.Drawing.Color.Red;
            this.lbCambio.Location = new System.Drawing.Point(355, 453);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(13, 13);
            this.lbCambio.TabIndex = 26;
            this.lbCambio.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(344, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "$";
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
        private System.Windows.Forms.ComboBox cbModoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCambio;
    }
}