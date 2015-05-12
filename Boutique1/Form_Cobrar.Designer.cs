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
            this.label1 = new System.Windows.Forms.Label();
            this.cbModoPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbRestante = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.RichTextBox();
            this.lbCambio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgPagos = new System.Windows.Forms.DataGridView();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bImprimir = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bPagar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
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
            this.cbModoPago.Location = new System.Drawing.Point(125, 19);
            this.cbModoPago.Name = "cbModoPago";
            this.cbModoPago.Size = new System.Drawing.Size(297, 21);
            this.cbModoPago.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Restante:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(107, 238);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(143, 33);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "$0000.00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRestante
            // 
            this.lbRestante.AutoSize = true;
            this.lbRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRestante.ForeColor = System.Drawing.Color.Red;
            this.lbRestante.Location = new System.Drawing.Point(108, 276);
            this.lbRestante.Name = "lbRestante";
            this.lbRestante.Size = new System.Drawing.Size(102, 25);
            this.lbRestante.TabIndex = 8;
            this.lbRestante.Text = "$0000.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pago:";
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(332, 238);
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
            this.lbCambio.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbCambio.Location = new System.Drawing.Point(337, 283);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(160, 37);
            this.lbCambio.TabIndex = 12;
            this.lbCambio.Text = "$0000.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cambio:";
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
            this.dgPagos.Location = new System.Drawing.Point(12, 46);
            this.dgPagos.Name = "dgPagos";
            this.dgPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgPagos.Size = new System.Drawing.Size(422, 169);
            this.dgPagos.TabIndex = 4;
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
            // Modo
            // 
            this.Modo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Modo.HeaderText = "Modo de Pago";
            this.Modo.MinimumWidth = 15;
            this.Modo.Name = "Modo";
            this.Modo.ReadOnly = true;
            this.Modo.Width = 102;
            // 
            // bImprimir
            // 
            this.bImprimir.Image = global::Boutique1.Properties.Resources.receive;
            this.bImprimir.Location = new System.Drawing.Point(440, 106);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(75, 45);
            this.bImprimir.TabIndex = 1;
            this.bImprimir.UseVisualStyleBackColor = true;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Image = global::Boutique1.Properties.Resources.delete85__1_;
            this.bCancelar.Location = new System.Drawing.Point(440, 46);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 45);
            this.bCancelar.TabIndex = 0;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bPagar
            // 
            this.bPagar.Image = global::Boutique1.Properties.Resources.dollar178;
            this.bPagar.Location = new System.Drawing.Point(440, 166);
            this.bPagar.Name = "bPagar";
            this.bPagar.Size = new System.Drawing.Size(75, 45);
            this.bPagar.TabIndex = 14;
            this.bPagar.UseVisualStyleBackColor = true;
            this.bPagar.Click += new System.EventHandler(this.bPagar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(19, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 102);
            this.panel1.TabIndex = 15;
            // 
            // Form_Cobrar
            // 
            this.AcceptButton = this.bImprimir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Boutique1.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(523, 335);
            this.ControlBox = false;
            this.Controls.Add(this.bPagar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.lbCambio);
            this.Controls.Add(this.dgPagos);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbRestante);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbModoPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_Cobrar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Recibir Pago";
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbRestante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtPago;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bPagar;
        private System.Windows.Forms.Panel panel1;
    }
}