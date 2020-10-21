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
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        private string numerosMarcado;
        private Provincial.Franja franjas;
       
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            
        }
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }
        private void Marcar()
        {
            string n = Control.MouseButtons.ToString();
            this.txtNumeroDestino.Text = n;
        }
        private void BotonPrecionado(string numero)
        {
            StringBuilder sb = new StringBuilder();
            
            if (!(this.numerosMarcado is null))
            {
                sb.Append(this.numerosMarcado);

            }
            else
            {
                if (numero != "#" && numero.Length == 1)
                {
                    this.cmbFranja.Enabled = false;

                }
            }
            sb.Append(numero);
            
            this.numerosMarcado = sb.ToString();
            this.txtNumeroDestino.Text = sb.ToString();
            
            
        }
        private void btn_Click(object sender, EventArgs e)
        {
            
            BotonPrecionado(((Button)sender).Text);
        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.numerosMarcado = null;
            this.txtNumeroDestino.Text= "Nro Destino";
            this.cmbFranja.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult dialogResult = DialogResult.OK;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
            Llamada llamada;
            if (this.cmbFranja.Enabled)
            {

                 llamada = new Provincial(this.txtNumeroOrigen.Text, this.franjas, 2.3f, this.numerosMarcado);
            }
            else
            {
                 llamada = new Local(this.txtNumeroOrigen.Text, 2.6f, this.numerosMarcado, 5.7f);

            }
            MessageBox.Show(llamada.ToString());
            centralita += llamada;
        }

    }
}
