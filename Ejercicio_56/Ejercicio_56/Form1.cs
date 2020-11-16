using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_56
{
    public partial class Form1 : Form
    {
        private string direccionArchivo;
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = "0";
        }

       
        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {
            string texto = this.rtbTexto.Text;
            toolStripStatusLabel2.Text = texto.Length.ToString();
        }

       

        private void menuAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de texto(*.txt)|*.txt";
            DialogResult n =openFileDialog.ShowDialog();
            if(n == DialogResult.OK)
            {
                this.direccionArchivo = openFileDialog.FileName;
                this.rtbTexto.Text = LeerArchivoTexto(this.direccionArchivo);
            }
            
        }
        public void EscribirArchivoTexto(string rutaCompleta, string texto, bool anexar)
        {

            StreamWriter streamWriter = null;
            try
            {//en ves de usar \\ se puede usar @"\"  al usar el arroba no toma los caracteres de escape
                
                streamWriter = new StreamWriter(rutaCompleta, anexar);//si anexar esta en true no pisa el contenido del archivo
                streamWriter.WriteLine(texto);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }

            }



        }
        public string LeerArchivoTexto(string rutaCompleta)
        {

            StreamReader streamReader = null;
            try
            {//en ves de usar \\ se puede usar @"\"  al usar el arroba no toma los caracteres de escape
               
                streamReader = new StreamReader(rutaCompleta);

                string text = string.Empty;

                string newLine;

                while ((newLine = streamReader.ReadLine()) != null)
                {
                    text += newLine + "\n";

                }
                return text;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }

            }
        }

        private void menuGuardar_Click(object sender, EventArgs e)
        {
            if(this.direccionArchivo != null)
            {
                this.EscribirArchivoTexto(this.direccionArchivo, this.rtbTexto.Text, true);
            }
            else
            {
                this.menuGuardarComo_Click(sender,e);
            }
        }

        private void menuGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.InitialDirectory = "c:\\";
            DialogResult resultado = guardar.ShowDialog();
            guardar.DefaultExt = ".txt";
            if (resultado == DialogResult.OK)
            {
                this.EscribirArchivoTexto(guardar.FileName +"."+ guardar.DefaultExt, this.rtbTexto.Text, false);
            }
        }
    }
}
