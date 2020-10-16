using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicolasEduardo.Perez._2c
{
    public partial class FormInformes : Form
    {

        public FormInformes(string lista)
        {
            InitializeComponent();
            //this.textInformes.Text = lista;
            this.richTextBoxInformes.Text = lista;
           
        }

       
    }
}
