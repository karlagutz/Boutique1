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
    public partial class Form_Usuarios : Form
    {
        SQLConnector sql = SQLConnector.getInstance();
        //DataSet ds;
        DataTable dtGrid;
        public Form_Usuarios()
        {
            InitializeComponent();
            actualizarGrid();
            
        }

        private void dgArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void actualizarGrid()
        {
            
            dtGrid = sql.consultar("SELECT * FROM Usuarios");
            
            dgUsuarios.DataSource = dtGrid;
           
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text;
            string cadena = "nombre like '%" + texto + "%'";
                            
            Debug.WriteLine(cadena);
            DataView res = new DataView(dtGrid);
            res.RowFilter = cadena;
            dgUsuarios.DataSource = res;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para editar o eliminar un usuario debe dar click derecho\n" +
                                    "en el usuario que desee realizar la operación \ny seleccionar una opción.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarGrid();
        }
        
        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (!this.MdiParent.Contains(ac))
            {
                ac = new Form_AgregarUsuario(this);
                ac.MdiParent = this.MdiParent;
                ac.Show();
            }
            else
            {
                ac.Activate();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        Form_AgregarUsuario ac;
        private void editartoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count != 0)
            {
                DataGridViewCellCollection dgcc = dgUsuarios.SelectedRows[0].Cells;

                ac = new Form_AgregarUsuario(Convert.ToInt32(dgcc[0].Value), Convert.ToString(dgcc[1].Value),
                                            Convert.ToString(dgcc[2].Value), Convert.ToInt32(dgcc[3].Value), this);

                ac.MdiParent = this.MdiParent;
                ac.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario.");
            }
            
        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            

        }

        private void dgUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgUsuarios.HitTest(e.X, e.Y);
                dgUsuarios.ClearSelection();
                if (hti.RowIndex >= 0)
                {
                    dgUsuarios.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count!=0)
            {
                 DataGridViewCellCollection dgcc = dgUsuarios.SelectedRows[0].Cells;
                 int id = Convert.ToInt32(dgcc[0].Value);
                 sql.modificar("DELETE FROM Usuarios WHERE id_usuario='" + id + "'");
                 MessageBox.Show("Usuario eliminado.");
                 actualizarGrid();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario.");
            }
        }
    }
}
