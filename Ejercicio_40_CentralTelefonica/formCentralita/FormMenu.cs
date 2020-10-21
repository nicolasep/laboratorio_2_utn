using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace formCentralita
{
    public partial class FormMenu : Form
    {
        private Centralita centralita;
        public FormMenu()
        {
            InitializeComponent();
            this.centralita = new Centralita("NicoTel");
        }

        private void btnLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(this.centralita);
            DialogResult resultado = frmLlamador.ShowDialog();

        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.centralita, Llamada.TipoLlamada.Todas);
           // frmMostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.centralita, Local.TipoLlamada.Local);
            //frmMostrar.TipoLlamada = Local.TipoLlamada.Local;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar;
            
            frmMostrar = new FrmMostrar(this.centralita, Llamada.TipoLlamada.Provincial);
            //frmMostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;

            frmMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
