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
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void printSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        Form_Venta fVenta;
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fVenta == null)
            {
                fVenta = new Form_Venta();
                fVenta.MdiParent = this;
                // Display the new form.
                fVenta.Show();
            }
            else {
                fVenta.Activate();
            }

        }

        private void Principal_Load(object sender, EventArgs e)
        {

          
        }

        Form_AgregarCliente fAgregarCliente;
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fAgregarCliente == null)
            {
                fAgregarCliente = new Form_AgregarCliente();
                fAgregarCliente.MdiParent = this;
                // Display the new form.
                fAgregarCliente.Show();
            }
            else
            {
                fAgregarCliente.Activate();
            }
        }
        Form_Clientes fClientes;
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fClientes == null)
            {
                fClientes = new Form_Clientes();
                fClientes.MdiParent = this;
                // Display the new form.
                fClientes.Show();
            }
            else
            {
                fClientes.Activate();
            }
        }
        Form_Articulos fArticulos;
        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fArticulos == null)
            {
                fArticulos = new Form_Articulos();
                fArticulos.MdiParent = this;
                // Display the new form.
                fArticulos.Show();
            }
            else
            {
                fArticulos.Activate();
            }
        }
        Form_VistaPreviaReporteVentas fVistaPrevia;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fVistaPrevia == null)
            {
                fVistaPrevia = new Form_VistaPreviaReporteVentas();
                fVistaPrevia.MdiParent = this;
                // Display the new form.
                fVistaPrevia.Show();
            }
            else
            {
                fVistaPrevia.Activate();
            }
        }
    }
}
