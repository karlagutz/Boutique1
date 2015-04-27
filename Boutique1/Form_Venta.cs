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

namespace Boutique1
{
    public partial class Form_Venta : Form
    {

        SQLConnector sql = SQLConnector.getInstance();
        public Form_Venta()
        {
            InitializeComponent();
            lbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss t");
            int res = Convert.ToInt32(sql.ejecutarEscalar("SELECT IDENT_CURRENT('ventas')"));
            int mas = res == 1? 0 : 1;
            txtIdVenta.Text = Convert.ToString(res + mas);
            cbModoPago.SelectedIndex = 0;
            
            
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
            string can = "";
            if (Utilerias.InputBox("Descuento", "Ingrese Descuento (ejemplo => 12): ", ref can) == DialogResult.OK)
            {   
                int n;
                bool isNumeric = int.TryParse(can, out n);

                if (isNumeric && n > 0 && n < 100 )
                {
                    if (txtTotal.Text != "")
                    {
                        double n2 = Convert.ToDouble(n);
                        double total = Convert.ToInt32(txtTotal.Text);
                        double nuevoTotal = total * (1 - (n2 / 100));
                        txtTotal.Text = Convert.ToString(nuevoTotal);
                        MessageBox.Show(total + " " + nuevoTotal);
                    }
                    else
                    {
                        MessageBox.Show("No Existe Total");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese solo numeros entre 1 y 100");
                }
            }
        }

       
        private void bEnviar_Click(object sender, EventArgs e)
        {
           int idVenta = Convert.ToInt32(txtIdVenta.Text);
           Hashtable h = new Hashtable();
           decimal d = Convert.ToDecimal(txtTotal.Text);
            h.Add("precioTotal",d);
            h.Add("fecha",DateTime.Now);
            h.Add("modoPago", cbModoPago.SelectedText);
            h.Add("idCliente", txtIDCliente.Text);
            DataGridViewRowCollection rows = dgVenta.Rows;
            try
            {
                sql.ejecutarProcedimiento("dbo.nuevaVenta", h);
                for (int i = 0; i < rows.Count - 1; i++)
                {
                    h = new Hashtable();
                    h.Add("id_articulo", Convert.ToInt32(rows[i].Cells[0].Value));
                    h.Add("id_venta",idVenta);
                    h.Add("cantidadAComprar", Convert.ToInt32(rows[i].Cells[2].Value));
                    h.Add("precioVenta", Convert.ToDecimal(rows[i].Cells[3].Value));
                    h.Add("total", Convert.ToDecimal(rows[i].Cells[4].Value));

                    sql.ejecutarProcedimiento("dbo.nuevoDetalleVenta", h);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ingrese Bien los datos");
            }

            finally 
            {
                MessageBox.Show("Venta Realizada");
            }

        }

        Form_Articulos fa;
        private void bBuscarArticulo_Click(object sender, EventArgs e)
        {
            if (fa == null)
            {
                fa = new Form_Articulos(this);
                fa.MdiParent = this.MdiParent;
                fa.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                //Display the new form
                fa.Show();
            }
            else
            {
                fa.Activate();
            }
            fa.actualizarGrid();
        }

        Form_Clientes fClien;
        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            if (fClien == null)
            {
                fClien = new Form_Clientes(this);
                fClien.MdiParent = this.MdiParent;
                fClien.FormClosed += new FormClosedEventHandler(Forms_FormClosed);
                //Display the new form
                fClien.Show();
            }
            else
            {
                fClien.Activate();
            }
            fClien.actualizarGrid();
        }

        private void Forms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = (Form)sender;
            //MessageBox.Show(f.Name);
            switch (f.Name)
            {
                case "Form_Articulos":
                    fa = null;
                    break;
                case "Form_Clientes":
                    fClien = null;
                    break;

            }
        }

        private void dgVenta_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
        }

        private void bCancelarArticulo_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgVenta.SelectedRows)
            {
                dgVenta.Rows.Remove(row);
            }
            
        }
        public DataGridView getGrid()
        {
            return dgVenta;
        }

        public TextBox getIdCliente()
        {
            return txtIDCliente;
        }

        public TextBox getNombreCliente()
        {
            return txtNombreCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            DataGridViewRowCollection col = dgVenta.Rows;
            for (int i = 0; i < col.Count; i++)
            {
                total = total + Convert.ToDecimal(col[i].Cells[4].Value);

            }
            txtTotal.Text = Convert.ToString(total);
        }

        private void dgVenta_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hti = dgVenta.HitTest(e.X, e.Y);
                dgVenta.ClearSelection();
                if (hti.RowIndex >= 0)
                {
                    dgVenta.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        public DataGridView getDataGrid() {

            return dgVenta;
        }

        public string getFolio(){
            return txtIdVenta.Text;
        }

        public string getTotal()
        {
            return txtTotal.Text;
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {

        }

      
    }
}
