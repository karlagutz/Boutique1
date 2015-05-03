using System;
using System.Collections.Generic;
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
    public partial class Form_DetalleVentas : Form
    {
        DataTable dtGrid;
        SQLConnector sql = SQLConnector.getInstance();
        public Form_DetalleVentas()
        {
            InitializeComponent();
            actualizarGrid();
        }

        private void Form_DetalleVentascs_Load(object sender, EventArgs e)
        {
           

        }
        public void actualizarGrid()
        {
            dtGrid = sql.consultar("SELECT v.id_venta as Folio, c.nombre as Cliente, v.fecha as Fecha,v.modoPago as 'Modo Pago', v.precioTotal as 'Precio Total' FROM Ventas v, Clientes c WHERE v.id_cliente=c.id_cliente ");

            dgDetalleVentas.DataSource = dtGrid;
         
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string texto = textBox1.Text;
            string cadena = "modoPago like '%" + texto + "%'";
            Debug.WriteLine(cadena);
            DataView res = new DataView(dtGrid);
            res.RowFilter = cadena;
            dgDetalleVentas.DataSource = res;
        }

    }
}
