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
        void limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCredito.Text = "";
            txtcorreo.Text = "";
            txtTelefono.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //verificamos si no estan vaciós los campos
            if (txtNombre.Text!="" && txtCredito.Text!="" && txtDireccion.Text!="" && txtcorreo.Text!="" && txtTelefono.Text!="")
            {

                try//Evita errores cuando cuando se llenan campos con diferentes tipos de variables
                {
                    string nombre = txtNombre.Text;
                    string direccion = txtDireccion.Text;
                    string correo = txtcorreo.Text;
                    string tel = txtTelefono.Text;
                    decimal credito = Convert.ToDecimal(txtCredito.Text);

                    Hashtable hash = new Hashtable();
                    hash.Add("nombre", nombre);
                    hash.Add("direccion", direccion);
                    hash.Add("correo", correo);
                    hash.Add("telefono", tel);
                    hash.Add("credito", credito);
                    hash.Add("saldo", credito);
                    try
                    {
                        sql.ejecutarProcedimiento("dbo.insertarCliente", hash);
                        MessageBox.Show("Cliente agregado, exitosamente.","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();

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
                catch (Exception)
                {
                    MessageBox.Show("Añada datos validos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                


            }
            else
            {
                MessageBox.Show("Llene todos los datos.","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                MessageBox.Show("Cliente editado correctamente.\nCierre la ventana si desea editar otro cliente" );
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            form.actualizarGrid();
        }
    }
}
