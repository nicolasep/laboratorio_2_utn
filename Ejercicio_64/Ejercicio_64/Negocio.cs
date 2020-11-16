using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio(Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;
            this.clientes = new List<string> { "nicolas", "matias", "alejandro" ,"silvia","cristian"};

        }
        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }
        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }
        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }
        public void AsignarCaja()
        {
            
            Console.WriteLine("asiganando cajas....");
            foreach (string n in this.clientes)
            {
                Thread.Sleep(2000);
                if (this.caja1.FilaClientes.Count() < this.caja2.FilaClientes.Count())
                {
                    this.caja1.FilaClientes.Add(n);
                    Console.WriteLine($"se asigno {n} a caja 1");
                }
                else
                {
                    this.caja2.FilaClientes.Add(n);
                    Console.WriteLine($"se asigno {n} a caja 2");
                }
            }
            
            
        }
        
    }
}
