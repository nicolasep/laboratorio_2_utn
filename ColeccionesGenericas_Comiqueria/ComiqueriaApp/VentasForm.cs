using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto aux;
        private Comiqueria auxC;
        public VentasForm(Comiqueria c, Producto p)
        {
            InitializeComponent();
            this.numericUpDown1.Minimum = 1;
            this.lblDescripcion.Text = p.Descripcion;
            this.auxC = c;
            this.aux = p;
            this.lblPrecioFinal.Text = Venta.CalcularPrecioFinal(aux.Precio, (int)this.numericUpDown1.Value).ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            this.lblPrecioFinal.Text = Venta.CalcularPrecioFinal(aux.Precio,(int) this.numericUpDown1.Value).ToString();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int cantidad = (int)this.numericUpDown1.Value;
            if (aux.Stock >= cantidad)
            {
                auxC.Vender(aux, cantidad);
                MessageBox.Show("Compra finalizada","confirmado",MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay ese stock");
            }
        }
    }
}
