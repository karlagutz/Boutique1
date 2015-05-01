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
    public partial class Form_AgregarUsuario : Form
    {
        Form_Usuarios form;
        int id;
        public Form_AgregarUsuario()
        {
            InitializeComponent();
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
            MessageBox.Show(this, "Para editar un usuario debe dar click derecho\n" +
                                    "en el articulo que desee editar y de click en editar.");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {//empleado es tipo 1, y administrador tipo 2
            if (txtUsuario.Text!="" &&txtContrasenia.Text!="" && cbTipo.SelectedIndex!=null)
            {
               
            }
            else
            {
                MessageBox.Show("Llene todos los campos para registrar\n un usuario nuevo","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       /* private void editar(object sender, EventArgs e)
        {

        }*/
    }
}
