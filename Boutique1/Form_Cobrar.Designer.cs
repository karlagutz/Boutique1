namespace Boutique1
{
    partial class Form_Cobrar
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModoPago = new System.Windows.Forms.ComboBox();
            this.dgPagos = new System.Windows.Forms.DataGridView();
            this.Modo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbRestante = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.RichTextBox();
            this.lbCambio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(439, 63);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 45);
            this.bCancelar.TabIndex = 0;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bImprimir
            // 
            this.bImprimir.Location = new System.Drawing.Point(439, 130);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(75, 49);
            this.bImprimir.TabIndex = 1;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = true;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modo de Pago:";
            // 
            // cbModoPago
            // 
            this.cbModoPago.FormattingEnabled = true;
            this.cbModoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito/Debito",
            "Credito de cliente"});
            this.cbModoPago.Location = new System.Drawing.Point(113, 19);
            this.cbModoPago.Name = "cbModoPago";
            this.cbModoPago.Size = new System.Drawing.Size(297, 21);
            this.cbModoPago.TabIndex = 3;
            // 
            // dgPagos
            // 
            this.dgPagos.AllowUserToDeleteRows = false;
            this.dgPagos.AllowUserToResizeColumns = false;
            this.dgPagos.AllowUserToResizeRows = false;
            this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modo,
            this.Importe});
            this.dgPagos.Location = new System.Drawing.Point(30, 63);
            this.dgPagos.Name = "dgPagos";
            this.dgPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgPagos.Size = new System.Drawing.Size(403, 135);
            this.dgPagos.TabIndex = 4;
            // 
            // Modo
            // 
            this.Modo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Modo.HeaderText = "Modo de Pago";
            this.Modo.MinimumWidth = 15;
            this.Modo.Name = "Modo";
            this.Modo.ReadOnly = true;
            this.Modo.Width = 102;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 15;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Restante:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(24, 229);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(143, 33);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "$0000.00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRestante
            // 
            this.lbRestante.AutoSize = true;
            this.lbRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRestante.ForeColor = System.Drawing.Color.Red;
            this.lbRestante.Location = new System.Drawing.Point(26, 285);
            this.lbRestante.Name = "lbRestante";
            this.lbRestante.Size = new System.Drawing.Size(127, 31);
            this.lbRestante.TabIndex = 8;
            this.lbRestante.Text = "$0000.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pago:";
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(272, 213);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(154, 38);
            this.txtPago.TabIndex = 11;
            this.txtPago.Text = "";
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCambio.ForeColor = System.Drawing.Color.Blue;
            this.lbCambio.Location = new System.Drawing.Point(273, 272);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(160, 37);
            this.lbCambio.TabIndex = 12;
            this.lbCambio.Text = "$0000.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cambio:";
            // 
            // bPagar
            // 
            this.bPagar.Location = new System.Drawing.Point(439, 201);
            this.bPagar.Name = "bPagar";
            this.bPagar.Size = new System.Drawing.Size(75, 49);
            this.bPagar.TabIndex = 14;
            this.bPagar.Text = "Pagar";
            this.bPagar.UseVisualStyleBackColor = true;
            this.bPagar.Click += new System.EventHandler(this.bPagar_Click);
            // 
            // Form_Cobrar
            // 
            this.AcceptButton = this.bImprimir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(522, 329);
            this.ControlBox = false;
            this.Controls.Add(this.bPagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCambio);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbRestante);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgPagos);
            this.Controls.Add(this.cbModoPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.bCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Cobrar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Recibir Pago";
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModoPago;
        private System.Windows.Forms.DataGridView dgPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbRestante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtPago;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bPagar;
    }
}