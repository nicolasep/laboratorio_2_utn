using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        delegate void CallBack();
        Thread thread;
        public Form1()
        {
            InitializeComponent();

            
        }
        public void AsignarHora()
        {
            while(true)
            {
                this.ActualizarHora();
                Thread.Sleep(1000);
            }
            
        }
        public void ActualizarHora()
        {
            if(this.lblHora.InvokeRequired)
            {
                CallBack callBack = new CallBack(this.ActualizarHora);

                this.Invoke(callBack);

            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString(); 
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.thread = new Thread(AsignarHora);
            this.thread.Start();
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.thread.IsAlive)
            {
                this.thread.Abort();
            }
        }
    }
}
