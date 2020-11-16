using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    public class Caja
    {
        private List<string> filaClientes;
        private string nombre;

        public Caja()
        {
            this.filaClientes = new List<string>();
            

        }
        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }
        public void AtenderClientes()
        {
            while(this.filaClientes.Count() > 0)
            {
                Console.WriteLine($"atendiendo cliente {this.filaClientes[0]} en la caja {Thread.CurrentThread.Name}");
                Thread.Sleep(2000);
                this.filaClientes.RemoveAt(0);
            }

        }

    }
}
