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
    public partial class FrmMostrar : Form
    {

        private Llamada.TipoLlamada tipo;

        
        public FrmMostrar(Centralita centralita, Llamada.TipoLlamada tipos)
        {
            InitializeComponent();
            this.TipoLlamada = tipos;
           
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(TipoLlamada.ToString());
            
            
            if(tipo == Llamada.TipoLlamada.Local)
            {
                //this.richTextBox1.Text = centralita.GananciasPorLocal.ToString();
                sb.AppendLine(centralita.GananciasPorLocal.ToString());
            }
            else if(tipo == Llamada.TipoLlamada.Provincial)
            {
                //this.richTextBox1.Text = centralita.GananciasPorProvincial.ToString();
                sb.AppendLine(centralita.GananciasPorProvincial.ToString());
            }
            else if(tipo == Llamada.TipoLlamada.Todas)
            {
                //this.richTextBox1.Text = centralita.GananciasPorTotal.ToString();
                sb.AppendLine(centralita.GananciasPorTotal.ToString());
            }

            this.richTextBox1.Text = sb.ToString() ;
        }
        public Llamada.TipoLlamada TipoLlamada
        {

            set
            {
                this.tipo = value;
            }
            get
            {
                return this.tipo;
            }
        }

    }
}
