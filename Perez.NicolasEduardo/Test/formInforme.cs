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
    public partial class formInforme : Form
    {
        public formInforme(Empresa empresa)
        {
            InitializeComponent();
            this.rTxtInforme.Text = empresa.ToString();
        }
    }
}
