using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Importador;

namespace Test
{
    public partial class formPrincipal : Form
    {
        private Empresa miEmpresa;
        private Producto.Origen origenSeleccionado;
        public formPrincipal()
        {
            InitializeComponent();
            miEmpresa = new Empresa("Nicolas",6);
            this.cmbOrigen.DataSource= Enum.GetValues(typeof(Producto.Origen));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formInforme informe = new formInforme(this.miEmpresa);
            DialogResult dialogResult = informe.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                MessageBox.Show("Gracias por usar mi programa");
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            int precioDeCompra;
            Enum.TryParse<Producto.Origen>(cmbOrigen.SelectedValue.ToString(), out origenSeleccionado);
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) && 
                int.TryParse(txtValorDeCompraProducto.Text,out precioDeCompra))
            {
                Producto productoNuevo;
                if(rbtnLineaBlanca.Checked)
                {
                    productoNuevo = new LineaBlanca(nombreProducto,precioDeCompra,origenSeleccionado); 
                }
                else
                {
                    productoNuevo = new Smartphone(nombreProducto, precioDeCompra, origenSeleccionado);
                }
                miEmpresa += productoNuevo;
                MessageBox.Show("El producto se agrego con exito");
            }

            LineaBlanca aux1 = new LineaBlanca("heladera",1500, Producto.Origen.Importado,true);
            LineaBlanca aux2 = new LineaBlanca("heladera",3200, Producto.Origen.Nacional);
            LineaBlanca aux3 = new LineaBlanca("heladera",7450, Producto.Origen.Importado);

            Smartphone sm1 = new Smartphone("s7",2000, Producto.Origen.Importado);
            Smartphone sm2 = new Smartphone("s7",5545, Producto.Origen.Importado);
            Smartphone sm3 = new Smartphone("s7",1000, Producto.Origen.Importado);
            miEmpresa += aux1;
            miEmpresa += aux2;
            miEmpresa += aux3;
            miEmpresa += sm1;
            miEmpresa += sm2;
            miEmpresa += sm3;
        }


    }
}
