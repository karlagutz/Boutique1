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
    public partial class Form_DetalleVentas : Form
    {
        public Form_DetalleVentas()
        {
            InitializeComponent();
        }

        private void Form_DetalleVentascs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_boutiqueDataSet.DetalleVentas' Puede moverla o quitarla según sea necesario.
            this.detalleVentasTableAdapter.Fill(this.bD_boutiqueDataSet.DetalleVentas);

        }
    }
}
