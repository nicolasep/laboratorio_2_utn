using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular(object sender, EventArgs e)
        {
            string texto = this.textPalabras.Text;
            string[] palabras;
            palabras = texto.Split(' ');
            int contador = 1;
            Dictionary<string, int> palabrasDisccionario = new Dictionary<string, int>();
            foreach (string palabra in palabras)
            {
                if(!palabrasDisccionario.ContainsKey(palabra))
                {
                    palabrasDisccionario.Add(palabra, contador);
                    
                }
                else
                {
                    palabrasDisccionario[palabra] = palabrasDisccionario[palabra] + 1;
                }
                contador = 1;
            }

           // List<KeyValuePair>


        }

        private void textPalabras_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
