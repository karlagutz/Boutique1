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
    public partial class Form_AgregarArticulos : Form
    {
        SQLConnector sql = SQLConnector.getInstance();
        Form_Articulos form;
        int id;

        public Form_AgregarArticulos()
        {
            InitializeComponent();
        }

        public Form_AgregarArticulos(Form_Articulos form)
        {
            InitializeComponent();
            this.form = form;
        }

        public Form_AgregarArticulos(int id, string desc, string precioventa, string preciocompra, string cantidad, Form_Articulos form)
        {
            InitializeComponent();
            this.form = form;
            this.id = id;
        
            txtDesc.Text = desc;
            txtprecioventa.Text = precioventa;
            txtpreciocompra.Text = preciocompra;
            txtcantidad.Text = cantidad;

            this.Text = "Editar Articulo";
            button1.Text = "Editar";
            button1.Click -= button1_Click;
            this.button1.Click += new System.EventHandler(this.editar);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string desc = txtDesc.Text;
            decimal precioVenta = Convert.ToDecimal(txtprecioventa.Text);
            decimal precioCompra = Convert.ToDecimal(txtpreciocompra.Text);
            int cantidad = Convert.ToInt32(txtcantidad.Text);


            Hashtable hash = new Hashtable();
            hash.Add("des", desc);
            hash.Add("precioventa", precioVenta);
            hash.Add("preciocompra", precioCompra);
            hash.Add("cantidadStock", cantidad);
            try
            {
                sql.ejecutarProcedimiento("dbo.insertarArticulo", hash);
                if (form != null)
                {
                    form.actualizarGrid();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void editar(object sender, EventArgs e)
        {
            string descripcion = txtDesc.Text;
            decimal precioVenta = Convert.ToDecimal(txtprecioventa.Text);
            decimal precioCompra = Convert.ToDecimal(txtpreciocompra.Text);
            int cantidadStock = Convert.ToInt32(txtcantidad.Text);

            Hashtable hash = new Hashtable();
            hash.Add("id", id);
            hash.Add("des", descripcion);
            hash.Add("precioventa", precioVenta);
            hash.Add("preciocompra", precioCompra);
            hash.Add("cantidadStock", cantidadStock);

            try
            {
                sql.ejecutarProcedimiento("dbo.actualizarArticulo", hash);
                MessageBox.Show("Cliente editado correctamente. cierre la ventana si desea editar otro cliente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            form.actualizarGrid();
        }
    }
}
