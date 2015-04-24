namespace Boutique1
{
    partial class Form_Apartados
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
            this.dgApartados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.bAbonar = new System.Windows.Forms.Button();
            this.bEditarCliente = new System.Windows.Forms.Button();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaUltimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgApartados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgApartados
            // 
            this.dgApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApartados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.Fecha,
            this.Importe,
            this.Credito,
            this.FechaUltimo});
            this.dgApartados.Location = new System.Drawing.Point(12, 52);
            this.dgApartados.Name = "dgApartados";
            this.dgApartados.Size = new System.Drawing.Size(724, 333);
            this.dgApartados.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(140, 12);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(403, 20);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(57, 12);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(77, 20);
            this.txtIDCliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Saldo Disponible:";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldo.Location = new System.Drawing.Point(107, 406);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(68, 16);
            this.lbSaldo.TabIndex = 9;
            this.lbSaldo.Text = "$0000.00";
            // 
            // bAbonar
            // 
            this.bAbonar.Location = new System.Drawing.Point(622, 396);
            this.bAbonar.Name = "bAbonar";
            this.bAbonar.Size = new System.Drawing.Size(114, 39);
            this.bAbonar.TabIndex = 10;
            this.bAbonar.Text = "Abonar";
            this.bAbonar.UseVisualStyleBackColor = true;
            this.bAbonar.Click += new System.EventHandler(this.bAbonar_Click);
            // 
            // bEditarCliente
            // 
            this.bEditarCliente.Location = new System.Drawing.Point(181, 396);
            this.bEditarCliente.Name = "bEditarCliente";
            this.bEditarCliente.Size = new System.Drawing.Size(114, 39);
            this.bEditarCliente.TabIndex = 11;
            this.bEditarCliente.Text = "Editar Cliente";
            this.bEditarCliente.UseVisualStyleBackColor = true;
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Credito
            // 
            this.Credito.HeaderText = "Credito";
            this.Credito.Name = "Credito";
            this.Credito.ReadOnly = true;
            // 
            // FechaUltimo
            // 
            this.FechaUltimo.HeaderText = "Fecha Ultimo Pago";
            this.FechaUltimo.Name = "FechaUltimo";
            this.FechaUltimo.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad a Pagar:";
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(507, 406);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(100, 20);
            this.txtAbono.TabIndex = 13;
            this.txtAbono.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form_Apartados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 445);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bEditarCliente);
            this.Controls.Add(this.bAbonar);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.dgApartados);
            this.MaximizeBox = false;
            this.Name = "Form_Apartados";
            this.Text = "Apartados";
            this.Load += new System.EventHandler(this.Form_Apartados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgApartados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgApartados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaUltimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Button bAbonar;
        private System.Windows.Forms.Button bEditarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAbono;
    }
}