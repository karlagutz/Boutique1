using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class Form_Clientes : Form
    {
        DataTable dtGrid;
        SQLConnector sq = SQLConnector.getInstance();
        Form_Venta form;


        public Form_Clientes()
        {
            InitializeComponent();
            actualizarGrid();
            contextMenuStrip1.Items["enviarToolStripMenuItem"].Visible = false;
        }

        public Form_Clientes(Form_Venta form)
        {
            InitializeComponent();
            actualizarGrid();
            contextMenuStrip1.Items["enviarToolStripMenuItem"].Visible = true;
            this.form = form;
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Forms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = (Form)sender;
            //MessageBox.Show(f.Name);
            switch (f.Name)
            {
               
            }
        }

        Form_AgregarCliente ac;
        private void bAgregar_Click(object sender, EventArgs e)
        {
            
            if (!this.MdiParent.Contains(ac))
            {
                ac = new Form_AgregarCliente(this);
                ac.MdiParent = this.MdiParent;
                ac.Show();
            }
            else
            {
                ac.Activate();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string texto = textBox1.Text;
            string cadena = "nombre like '%" + texto + "%' or direccion like '%" + texto
                            + "%' or correo like '%" + texto + "%' or telefono like '%" + texto + "%'";
            Debug.WriteLine(cadena);
            DataView res = new DataView(dtGrid);
            res.RowFilter = cadena;
            dgClientes.DataSource = res;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection dgcc = dgClientes.SelectedRows[0].Cells;

            ac = new Form_AgregarCliente(Convert.ToInt32(dgcc[0].Value),Convert.ToString(dgcc[1].Value), 
                                        Convert.ToString(dgcc[2].Value), Convert.ToString(dgcc[3].Value),
                                        Convert.ToString(dgcc[4].Value),Convert.ToString(dgcc[5].Value),this);

            ac.MdiParent = this.MdiParent;
            ac.Show();
            
        }

        private void dgClientes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgClientes.HitTest(e.X, e.Y);
                dgClientes.ClearSelection();
                if (hti.RowIndex >= 0)
                {
                    dgClientes.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        public void actualizarGrid() {
            DataSet ds = sq.ejecutarProcedimiento("dbo.listaDeClientes");
            dtGrid = ds.Tables[0];
            dgClientes.DataSource = dtGrid;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void enviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection dgcc = dgClientes.SelectedRows[0].Cells;
            
            if (form != null)
            {
                form.getIdCliente().Text = Convert.ToString(dgcc[0].Value);
                form.getNombreCliente().Text = Convert.ToString(dgcc[1].Value);
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para editar un cliente debe dar click derecho\n" +
                                    "en el articulo que desee editar y de click en editar.","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlGuardar = new SaveFileDialog();
            dlGuardar.Filter = "Fichero CSV (*.csv)|*.csv";
            dlGuardar.FileName = "Clientes";
            dlGuardar.Title = "Exportar a CSV";
            if (dlGuardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                //para los títulos de las columnas, encabezado
                for (int i = 0; i < dgClientes.Columns.Count; i++)
                {
                    if (i == dgClientes.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("\"{0}\"",
                            dgClientes.Columns[i].HeaderText));
                    }
                    else
                    {
                        csvMemoria.Append(String.Format("\"{0}\";",
                            dgClientes.Columns[i].HeaderText));
                    }
                }
                csvMemoria.AppendLine();


                for (int m = 0; m < dgClientes.Rows.Count; m++)
                {
                    for (int n = 0; n < dgClientes.Columns.Count; n++)
                    {
                        //si es la última columna no poner el ;
                        if (n == dgClientes.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format("\"{0}\"",
                                 dgClientes.Rows[m].Cells[n].Value));
                        }
                        else
                        {
                            csvMemoria.Append(String.Format("\"{0}\";",
                                dgClientes.Rows[m].Cells[n].Value));
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

        private void tipNuevo_Popup(object sender, PopupEventArgs e)
        {

        }

    }
}
