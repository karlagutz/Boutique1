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
    public partial class Form_Venta : Form
    {
        
        
        public Form_Venta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bDescuento_Click(object sender, EventArgs e)
        {

        }
        Form_Cobrar fcobrar;
        private void bEnviar_Click(object sender, EventArgs e)
        {

            if (fcobrar == null)
            {
                fcobrar = new Form_Cobrar();
                string tot = txtTotal.Text;
                fcobrar.recibir_datos = tot;
                //fcobrar.MdiParent = this;
                fcobrar.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                // Display the new form

                fcobrar.Show();
            }
            else
            {
                fcobrar.Activate();
            }
}

        private void Forms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = (Form)sender;
            //MessageBox.Show(f.Name);
            switch (f.Name)
            {
                case "Form_Cobrar":
                    fcobrar = null;
                    break;
            }
        }
    }
}
