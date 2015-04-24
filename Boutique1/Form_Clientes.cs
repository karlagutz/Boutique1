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
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }

        Form_Apartados fApartados;
        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fApartados == null)
            {
                fApartados = new Form_Apartados();
               // string tot = txtTotal.Text;
                //fApartados.recibir_datos = tot;
              //  fApartados.MdiParent = this;
                fApartados.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                // Display the new form

                fApartados.Show();
            }
            else
            {
                fApartados.Activate();
            }
        }
        private void Forms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = (Form)sender;
            //MessageBox.Show(f.Name);
            switch (f.Name)
            {
                case "Form_Apartados":
                    fApartados = null;
                    break;
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
