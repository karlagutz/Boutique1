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
    public partial class Form_AgregarUsuario : Form
    {
        Form_Usuarios form;
        int id;
        string nombreUsuario;
        string contraseña;
        int tipo;
        SQLConnector sql = SQLConnector.getInstance();

        public Form_AgregarUsuario()
        {
            InitializeComponent();
        }
        public Form_AgregarUsuario(int id, string nombreUsuario,string contraseña, int tipo, Form_Usuarios form)
        {
            InitializeComponent();
            this.form = form;
        }

       /* public void Form_AgregarUsuario(int id, string nombre, string contraseña, string tipo)
        {
           InitializeComponent();
            this.form = form;
            this.id = id;

            txtUsuario.Text = nombre;
            txtContrasenia.Text = contraseña;
            cbTipo.SelectedText = tipo;

            this.Text = "Editar Articulo";
            btnAgregar.Text = "Editar";
            btnAgregar.Click -= btnAgregar_Click;
            this.btnAgregar.Click += new System.EventHandler(this.editar);
        }*/

        private void Form_AgregarUsuario_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {//empleado es tipo 1, y administrador tipo 2
            Hashtable hash = new Hashtable();
           
            if (txtUsuario.Text!="" &&txtContrasenia.Text!="" && cbTipo.SelectedIndex!=-1)
            {
                nombreUsuario = txtUsuario.Text;
                contraseña = txtContrasenia.Text;
                tipo = cbTipo.SelectedIndex + 1;
        
                try
                {
                    sql.modificar("INSERT INTO Usuarios (nombre, contraseña, tipo) values ('"+nombreUsuario+"','"+contraseña+"','"+tipo+"')");
                    MessageBox.Show("Usuario agregado, exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();

                    if (form != null)
                    {
                       // form.actualizarGrid();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

            }
            else
            {
                MessageBox.Show("Llene todos los campos para registrar\n un usuario nuevo","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       /* private void editar(object sender, EventArgs e)
        {

        }*/
        void limpiar()
        {
            txtUsuario.Text = "";
            txtContrasenia.Text = "";
            cbTipo.SelectedIndex = 0;
        }
    }
}
