using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
        
        public enum Puesto
        {
            Caja1, Caja2
        }
        public static int NumeroActual
        {
            get
            {
                return numeroActual +1;
            }
        }
        private PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto):this()
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {
            
            Thread.Sleep(10000);
            

            return true;
        }
    }
}
