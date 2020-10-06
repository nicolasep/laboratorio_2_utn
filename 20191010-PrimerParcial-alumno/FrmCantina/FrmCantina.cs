using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ControlCantina;

namespace FrmCantina
{
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {
            InitializeComponent();

            this.numCapacidad.Minimum = 1;
            this.numCapacidad.Maximum = 5000;
            this.numCapacidad.Value = 1000;
            this.numContenido.Minimum = 1;
            this.numContenido.Maximum = 5000;
            this.numContenido.Value = 1000;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            this.numCapacidad.Minimum= 1;
            this.numCapacidad.Maximum = 5000;
            this.numCapacidad.Increment=1;
            //this.numericUpDown1.Value = 1000;

        }

        private void DarEstadoInicial(object sender, ControlEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Barra barra ;
            this.barra.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void barra3_Load(object sender, EventArgs e)
        {

        }

        private void cmbBotellaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella botella;
            if (rdbCerbeza.Checked)
            {
                Botella.Tipo tipo;
                Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
                botella = new Cerveza((int)numContenido.Value, textMarca.Text, (int)numContenido.Value);
            }
            else
            {
                botella = new Agua((int)numContenido.Value, textMarca.Text, (int)numContenido.Value);
            }
            this.barra.AgregarBotella(botella);
        }
    }
}
