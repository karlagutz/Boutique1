using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique1
{
    public partial class Form_Usuarios : Form
    {
        SQLConnector sql = SQLConnector.getInstance();
        DataSet ds;
        DataTable dtGrid;
        public Form_Usuarios()
        {
            InitializeComponent();
        }

        private void dgArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void actualizarGrid()
        {
           // ds = sql.consultar("select * from usuarios",);
            dtGrid = ds.Tables[0];
            dgUsuarios.DataSource = dtGrid;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para editar un usuario debe dar click derecho\n" +
                                    "en el articulo que desee editar y de click en editar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void bAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        Form_AgregarUsuario ac;
        private void editartoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection dgcc = dgUsuarios.SelectedRows[0].Cells;

            ac = new Form_AgregarUsuario(Convert.ToInt32(dgcc[0].Value), Convert.ToString(dgcc[1].Value),
                                        Convert.ToString(dgcc[2].Value), Convert.ToInt32(dgcc[3].Value),this);

            ac.MdiParent = this.MdiParent;
            ac.Show();
        }
    }
}
