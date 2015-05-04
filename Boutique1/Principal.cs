using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique1
{
    public partial class Principal : Form
    {
        //private int childFormNumber = 0;
       // public event FormClosedEventHandler Form_FormClosed;
        int tipo;
        public Principal(int tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            if (tipo==2)
            {
                agregarUsuarioToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
                verVentasToolStripMenuItem.Visible = true;
            }
            else
            {
                agregarUsuarioToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                verVentasToolStripMenuItem.Visible = false;
            }
            
        }

       

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
        private void Forms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = (Form)sender;
            switch (f.Name)
            {
                case "Form_Venta":
                    fVenta = null;
                    break;

                case "Form_AgregarCliente":
                    fAgregarCliente = null;
                    break;
                case "Form_Articulos":
                    fArticulos = null;
                    break;

                case "Form_Clientes":
                    fClientes = null;
                    break;
                case "Form_VistaPreviaReporteVentas":
                    fVistaPrevia = null;
                    break;

                case "Form_AgregarArticulos":
                    farticu = null;
                    break;
                case "Form_AgregarUsuario":
                    FAgreagarUsuario = null;
                    break;
                case "Form_Usuarios":
                    FUsuarios = null;
                    break;
                case "Form_DetalleVentas":
                    fdetalleventas = null;
                    break;

            }
        }
              
        Form_Clientes fClientes;
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fClientes == null)
            {
                fClientes = new Form_Clientes();
                fClientes.MdiParent = this;
                fClientes.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
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
                fArticulos.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
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
                fVistaPrevia.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                // Display the new form.
                fVistaPrevia.Show();
            }
            else
            {
                fVistaPrevia.Activate();
            }
        }



        Form_Venta fVenta;
        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fVenta == null)
            {
                fVenta = new Form_Venta();
                fVenta.MdiParent = this;
                fVenta.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                // Display the new form
                fVenta.Show();
            }
            else
            {
                fVenta.Activate();
            }
        }

        Form_AgregarArticulos farticu;
        private void agregarAriculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (farticu == null)
            {
                farticu = new Form_AgregarArticulos();
                farticu.MdiParent = this;
                farticu.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                // Display the new form
                farticu.Show();
            }
            else
            {
                farticu.Activate();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        Form_AgregarCliente fAgregarCliente;
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fAgregarCliente == null)
            {
                fAgregarCliente = new Form_AgregarCliente();
                fAgregarCliente.MdiParent = this;
                fAgregarCliente.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                // Display the new form.
                fAgregarCliente.Show();
            }
            else
            {
                fAgregarCliente.Activate();
            }
        }
        
        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (farticu == null)
            {
                farticu = new Form_AgregarArticulos();
                farticu.MdiParent = this;
                farticu.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                // Display the new form
                farticu.Show();
            }
            else
            {
                farticu.Activate();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void apartadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        Form_Usuarios FUsuarios;
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FUsuarios == null)
            {
                FUsuarios = new Form_Usuarios();
                FUsuarios.MdiParent = this;
                FUsuarios.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                // Display the new form.
                FUsuarios.Show();
            }
            else
            {
                FUsuarios.Activate();
            }
        }
        Form_AgregarUsuario FAgreagarUsuario;
        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FAgreagarUsuario == null)
            {
                FAgreagarUsuario = new Form_AgregarUsuario();
                FAgreagarUsuario.MdiParent = this;
                FAgreagarUsuario.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                // Display the new form.
                FAgreagarUsuario.Show();
            }
            else
            {
                FAgreagarUsuario.Activate();
            }
        }
        Form_DetalleVentas fdetalleventas;
        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdetalleventas == null)
            {
                fdetalleventas = new Form_DetalleVentas();
                fdetalleventas.MdiParent = this;
                fdetalleventas.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                // Display the new form.
                fdetalleventas.Show();
            }
            else
            {
                fdetalleventas.Activate();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

       
    }
}
