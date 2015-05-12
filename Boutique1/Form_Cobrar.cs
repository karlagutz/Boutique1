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

    public partial class Form_Cobrar : Form
    {


        public Form_Venta form;
        public double pago = 0;



        public Form_Cobrar()
        {
            InitializeComponent();
        }


        public Form_Cobrar(Form_Venta form)
        {
            InitializeComponent();
            this.form = form;
            lbTotal.Text = form.getTotal();
        }


        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bPagar_Click(object sender, EventArgs e)
        {





            double deuda = Convert.ToDouble(lbTotal.Text);
            double restante = Convert.ToDouble(lbRestante.Text);
            pago = Convert.ToDouble(txtPago.Text);
            int modo = cbModoPago.SelectedIndex;
            /* 
            0= efectivo
            1= tarjeta
            2= credito tienda
             */
            if (pago > deuda)
            {
               
                if (modo!=0)
                {
                    MessageBox.Show("El metodo de pago no regresa cambio.");
                }
                else
                {
                    lbRestante.Text = "$0.00";
                    lbCambio.Text = "$" + (pago - deuda);
                    dgPagos.Rows.Add(modo, pago);
                }
            }
            else 
            {
                lbRestante.Text = "$" + (deuda - pago);
                dgPagos.Rows.Add(modo, pago);
                txtPago.Text = "";
            }
        }


        private void txtPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            double restante = Convert.ToDouble(lbRestante.Text);
            if (restante>0)
            {
                MessageBox.Show("Aún resta "+restante+" por pagar.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
