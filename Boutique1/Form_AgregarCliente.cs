using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique1
{
    public partial class Form_AgregarCliente : Form
    {
        SQLConnector sql = SQLConnector.getInstance();

        private int id;
        private string nombre;
        private string direccion;
        private string correo;
        private string telefono;
        private string limiteCredito;
        Form_Clientes form;


        //constructor que se manda a llamar si se nesesita editar un usuario.
        public Form_AgregarCliente(int id, string nombre, string direccion, string correo, string telefono, string limiteCredito, Form_Clientes form)
        {
            InitializeComponent();
            this.form = form;
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.correo = correo;
            this.telefono = telefono;
            this.limiteCredito = limiteCredito;

            txtNombre.Text = nombre;
            txtDireccion.Text = direccion;
            txtcorreo.Text = correo;
            txtTelefono.Text = telefono;
            txtCredito.Text = limiteCredito;

            bAgregar.Text = "Editar";
            this.Text = "Editar Cliente";
            bAgregar.Click -= button1_Click;
            this.bAgregar.Click += new System.EventHandler(this.editar);
        }


        public Form_AgregarCliente(Form_Clientes form)
        {
            InitializeComponent();
            this.form = form;
        }

        public Form_AgregarCliente()
        {
            InitializeComponent();
        }
        // hola karla bonita c:

        //nope D:
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string correo = txtcorreo.Text;
            string tel = txtTelefono.Text;
            decimal credito = Convert.ToDecimal(txtCredito.Text);


            Hashtable hash = new Hashtable();
            hash.Add("nombre",nombre);
            hash.Add("direccion", direccion);
            hash.Add("correo", correo);
            hash.Add("telefono",tel);
            hash.Add("credito",credito);
            hash.Add("saldo",credito);
            try
            {
                sql.ejecutarProcedimiento("dbo.insertarCliente",hash);
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
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string correo = txtcorreo.Text;
            string tel = txtTelefono.Text;
            decimal credito = Convert.ToDecimal(txtCredito.Text);

            Hashtable hash = new Hashtable();
            hash.Add("id", id);
            hash.Add("nombre", nombre);
            hash.Add("direccion", direccion);
            hash.Add("correo", correo);
            hash.Add("telefono", tel);
            hash.Add("credito", credito);
            try
            {
                sql.ejecutarProcedimiento("dbo.actualizarCliente", hash);
                MessageBox.Show("Cliente editado correctamente. cierre la ventana si desea editar otro cliente" );
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            form.actualizarGrid();
        }
    }
}
