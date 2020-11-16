using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        private List<IAcciones> acciones;

        public Cartuchera1()
        {
            this.acciones = new List<IAcciones>();
        }

        public void ProbarElementos()
        {
            foreach(IAcciones l in this.acciones)
            {
                l.UnidadesDeEscritura -= 1;
            }
            foreach (IAcciones l in this.acciones)
            {
                l.UnidadesDeEscritura += 20;
            }
            
        }
    }
}
