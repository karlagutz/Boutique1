using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique1
{
    public partial class Form_Articulos : Form
    {
        SQLConnector sql = SQLConnector.getInstance();
        DataSet ds;
        DataTable dtGrid;
        Form_Venta form;
        public Form_Articulos()
        {
            InitializeComponent();
            actualizarGrid();
            contextMenuStrip1.Items["enviarToolStripMenuItem"].Visible = false;
        }

        public Form_Articulos(Form_Venta form)
        {
            InitializeComponent();
            actualizarGrid();
            contextMenuStrip1.Items["enviarToolStripMenuItem"].Visible = true;
            this.form = form;
        }


        private void bEditar_Click(object sender, EventArgs e)
        {

        }



        public void actualizarGrid()
        {
            ds = sql.ejecutarProcedimiento("dbo.listaDeArticulos");
            dtGrid = ds.Tables[0];
            dgArticulos.DataSource = dtGrid;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string cadena = "descripcion like '%" + texto + "%'";
            Debug.WriteLine(cadena);
            DataView res = new DataView(dtGrid);
            res.RowFilter = cadena;
            dgArticulos.DataSource = res;
        }


        Form_AgregarArticulos ac;
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgArticulos.SelectedRows.Count!=0)
            {
                DataGridViewCellCollection dgcc = dgArticulos.SelectedRows[0].Cells;

                ac = new Form_AgregarArticulos(Convert.ToInt32(dgcc[0].Value), Convert.ToString(dgcc[1].Value),
                                            Convert.ToString(dgcc[2].Value), Convert.ToString(dgcc[3].Value),
                                            Convert.ToString(dgcc[4].Value), this);

                ac.MdiParent = this.MdiParent;
                ac.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un articulo.");
            }
            
          
        }



        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (!this.MdiParent.Contains(ac))
            {
                ac = new Form_AgregarArticulos(this);
                ac.MdiParent = this.MdiParent;
                ac.Show();
            }
            else
            {
                ac.Activate();
            }
        }

        private void dgArticulos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgArticulos.HitTest(e.X, e.Y);
                dgArticulos.ClearSelection();
                if (hti.RowIndex >= 0)
                {
                    dgArticulos.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void enviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection dgcc = dgArticulos.SelectedRows[0].Cells;
            string cantidad = "";
            int cantidadInt = 0;
            int cantidadStock = 0;
            if (form != null)
            {
                if (Utilerias.InputBox("Ingrese Cantidad", "Cantidad: ", ref cantidad) == DialogResult.OK)
                {
                    cantidadInt = Convert.ToInt32(cantidad);
                    cantidadStock = Convert.ToInt32(dgcc[4].Value);
                    if (cantidadInt > cantidadStock)
                    {
                        MessageBox.Show("No existen suficientes elementos.");
                    }
                    else
                    {
                        string precio = Convert.ToString(dgcc[2].Value);
                        int precioint = Convert.ToInt32(dgcc[2].Value);
                        form.getGrid().Rows.Add(dgcc[0].Value,dgcc[1].Value, cantidad, precio, cantidadInt * precioint, cantidadStock);
                    }
                }
            }
        }

        private void Form_Articulos_Load(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para editar o eliminar un articulo debe dar click derecho\n"+
                                    "en el articulo que desee editar.","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog();
            dlGuardar.Filter = "Fichero CSV (*.csv)|*.csv";
            dlGuardar.FileName = "Articulos";
            dlGuardar.Title = "Exportar a CSV";
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                //para los títulos de las columnas, encabezado
                for (int i = 0; i < dgArticulos.Columns.Count; i++)
                {
                    if (i == dgArticulos.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("\"{0}\"",
                            dgArticulos.Columns[i].HeaderText));
                    }
                    else
                    {
                        csvMemoria.Append(String.Format("\"{0}\";",
                            dgArticulos.Columns[i].HeaderText));
                    }
                }
                csvMemoria.AppendLine();


                for (int m = 0; m < dgArticulos.Rows.Count; m++)
                {
                    for (int n = 0; n < dgArticulos.Columns.Count; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == dgArticulos.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format("\"{0}\"",
                                 dgArticulos.Rows[m].Cells[n].Value));
                        }
                        else
                        {
                            csvMemoria.Append(String.Format("\"{0}\";",
                                dgArticulos.Rows[m].Cells[n].Value));
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
