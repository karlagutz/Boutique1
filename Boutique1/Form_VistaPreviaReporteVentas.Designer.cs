namespace Boutique1
{
    partial class Form_VistaPreviaReporteVentas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RVistaPrevia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RVistaPrevia
            // 
            this.RVistaPrevia.AutoScroll = true;
            this.RVistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            this.RVistaPrevia.LocalReport.DataSources.Add(reportDataSource2);
            this.RVistaPrevia.Location = new System.Drawing.Point(0, 0);
            this.RVistaPrevia.Name = "RVistaPrevia";
            this.RVistaPrevia.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.RVistaPrevia.Size = new System.Drawing.Size(694, 547);
            this.RVistaPrevia.TabIndex = 0;
            // 
            // Form_VistaPreviaReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 547);
            this.Controls.Add(this.RVistaPrevia);
            this.Name = "Form_VistaPreviaReporteVentas";
            this.Text = "Vista Previa";
            this.Load += new System.EventHandler(this.Form_VistaPreviaReporteVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVistaPrevia;
    }
}