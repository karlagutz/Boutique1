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
    public partial class Form_Apartados : Form
    {
        
        public Form_Apartados()
        {
            InitializeComponent();
        }
       

        Form_Cobrar fcobrar;
        private void bAbonar_Click(object sender, EventArgs e)
        {
            if (fcobrar == null)
            {
                fcobrar = new Form_Cobrar();
                fcobrar.MdiParent = this.MdiParent;
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
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Apartados_Load(object sender, EventArgs e)
        {
            double total = dgApartados.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["Credito"].Value));
            lbSaldo.Text = "$"+ (3000 - total);
        }
        
    }
}
