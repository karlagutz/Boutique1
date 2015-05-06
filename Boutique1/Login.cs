using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Boutique1
{
    
    public partial class Login : Form
    {
        int tipoUsuario;
        SQLConnector sql = SQLConnector.getInstance();
        DataTable dtGrid;
        public Login()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void bEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contra = txtContra.Text;

            dtGrid = sql.consultar("SELECT * FROM Usuarios WHERE nombre='" + usuario + "' AND contraseña='" + contra + "'");

            if (txtUsuario.Text != "" || txtContra.Text != "")
            {
                if (dtGrid.Rows.Count != 0)
                {
                    contra = txtContra.Text;
                    usuario = txtUsuario.Text;

                    DataRow DR = dtGrid.Rows[0];
                    string nombreUsuario = DR["nombre"].ToString();
                    string contraUsuario = DR["contraseña"].ToString();
                    tipoUsuario = Convert.ToInt32(DR["tipo"].ToString());

                    if (usuario == nombreUsuario && contra == contraUsuario)
                    {
                        this.Hide();

                        Principal prin = new Principal(tipoUsuario);
                        prin.Show();
                        sql.cerrarConexion();


                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña incorrectos.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario No Existe");
                }
            }
            else
            {
                MessageBox.Show("Ingrese Campos");
            }
           
            
        }

        

    }
}
