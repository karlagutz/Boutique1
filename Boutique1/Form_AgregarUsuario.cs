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
        
        string contraseña;
        int tipo;
        DataTable dtGrid2;
        SQLConnector sql = SQLConnector.getInstance();

        public Form_AgregarUsuario(Form_Usuarios form)
        {
            InitializeComponent();
            this.form = form;
        }
        public Form_AgregarUsuario()
        {
            InitializeComponent();
            cbTipo.SelectedIndex = 0;
           
        }
        public Form_AgregarUsuario(int id, string nombreUsuario,string contraseña, int tipo, Form_Usuarios form)
        {
            InitializeComponent();
            this.form = form;
            this.id = id;

            txtUsuario.Text = nombreUsuario;
            txtContrasenia.Text = contraseña;
            cbTipo.SelectedIndex=tipo-1;
            this.Text = "Editar Articulo";
            btnAgregar.Text = "Editar";
            btnAgregar.Click -= btnAgregar_Click;
            this.btnAgregar.Click += new System.EventHandler(this.editar);

        }

      

        private void Form_AgregarUsuario_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {//empleado es tipo 1, y administrador tipo 2
            
            dtGrid2 = sql.consultar("SELECT * FROM Usuarios WHERE nombre='" + txtUsuario.Text +"'");
            //DataSet ds = new DataSet();
            // ds.Tables.Add(dtGrid);
            //DataRow DR2 = dtGrid2.Rows[0];
            //string nombreUsuario = DR2["nombre"].ToString();
            //Verificamos si existe el usuario
            string nombreUsuario = ""; 
            if (txtUsuario.Text != "" && txtContrasenia.Text != "" && cbTipo.SelectedIndex != -1)
            {
                if (dtGrid2.Rows.Count == 0)
                {
                    nombreUsuario = txtUsuario.Text;
                    contraseña = txtContrasenia.Text;
                    tipo = cbTipo.SelectedIndex + 1;

                    try
                    {
                        sql.modificar("INSERT INTO Usuarios (nombre, contraseña, tipo) values ('" + nombreUsuario + "','" + contraseña + "','" + tipo + "')");
                        MessageBox.Show("Usuario agregado, exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        nombreUsuario = "";
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
                else
                {
                    
                    MessageBox.Show("Ya existe ese usuario intenta de nuevo.");
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos para registrar\n un usuario nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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
        private void editar(object sender, EventArgs e)
        {
            if (txtContrasenia.Text != "" && txtUsuario.Text != "" && cbTipo.SelectedIndex != -1)
            {
                string nombre = txtUsuario.Text;
                string contraseña = txtContrasenia.Text;
                int tipo = cbTipo.SelectedIndex + 1;

                Hashtable hash = new Hashtable();
                hash.Add("id", id);
                hash.Add("nombre", nombre);
                hash.Add("contraseña", contraseña);
                hash.Add("tipo", tipo);
                try
                {
                    sql.modificar("UPDATE Usuarios set nombre='" + nombre + "',contraseña='" + contraseña + "',tipo='" + tipo + "'WHERE id_usuario='" + id + "'");


                    MessageBox.Show("Usuario editado correctamente.\nCierre la ventana si desea editar otro cliente");
                    form.actualizarGrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                form.actualizarGrid();
            }
            else
            {
                MessageBox.Show("No debe haber campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
