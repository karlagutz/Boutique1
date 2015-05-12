using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Boutique1
{
    public partial class Form_DetalleVentas : Form
    {
        DataTable dtGrid;
        SQLConnector sql = SQLConnector.getInstance();
        public Form_DetalleVentas()
        {
            InitializeComponent();
            actualizarGrid();
        }

        private void Form_DetalleVentascs_Load(object sender, EventArgs e)
        {
           

        }
        public void actualizarGrid()
        {
            dtGrid = sql.consultar("SELECT v.id_venta as Folio, c.nombre as Cliente, v.fecha as Fecha,v.modoPago as ModoPago, v.precioTotal as 'Precio Total' FROM Ventas v, Clientes c WHERE v.id_cliente=c.id_cliente ");

            dgDetalleVentas.DataSource = dtGrid;
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string texto = textBox1.Text;
            string cadena = "Cliente like '%" + texto + "%' or ModoPago like '%" + texto + "%'";
            Debug.WriteLine(cadena);
            DataView res = new DataView(dtGrid);
            res.RowFilter = cadena;
            dgDetalleVentas.DataSource = res;
        }
        
        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            //printDocument1.Print();
            //Resize DataGridView to full height.
            int height = dgDetalleVentas.Height;
            dgDetalleVentas.Height = (dgDetalleVentas.RowCount + 1 ) * dgDetalleVentas.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(this.dgDetalleVentas.Width, this.dgDetalleVentas.Height);
            dgDetalleVentas.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dgDetalleVentas.Width, this.dgDetalleVentas.Height));

            //Resize DataGridView back to original height.
            dgDetalleVentas.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
          
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           //PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(10, 10), this.Size));
           // this.InvokePaint(dgDetalleVentas, myPaintArgs);
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog();
            dlGuardar.Filter = "Fichero CSV (*.csv)|*.csv";
            dlGuardar.FileName = "Detalle Ventas";
            dlGuardar.Title = "Exportar a CSV";
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                //para los títulos de las columnas, encabezado
                for (int i = 0; i < dgDetalleVentas.Columns.Count; i++)
                {
                    if (i == dgDetalleVentas.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("\"{0}\"",
                            dgDetalleVentas.Columns[i].HeaderText));
                    }
                    else
                    {
                        csvMemoria.Append(String.Format("\"{0}\";",
                            dgDetalleVentas.Columns[i].HeaderText));
                    }
                }
                csvMemoria.AppendLine();


                for (int m = 0; m < dgDetalleVentas.Rows.Count; m++)
                {
                    for (int n = 0; n < dgDetalleVentas.Columns.Count; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == dgDetalleVentas.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format("\"{0}\"",
                                 dgDetalleVentas.Rows[m].Cells[n].Value));
                        }
                        else
                        {
                            csvMemoria.Append(String.Format("\"{0}\";",
                                dgDetalleVentas.Rows[m].Cells[n].Value));
                        }
                    }
                    csvMemoria.AppendLine();
                }
                System.IO.StreamWriter sw =
                    new System.IO.StreamWriter(dlGuardar.FileName, false,
                       System.Text.Encoding.Default);
                sw.Write(csvMemoria.ToString());
                sw.Close();
            }
        }

    }
}
