using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class OtraClase
    {
        public void OtroMetodoDeInstancia()
        {
            try
            {
                 new MiClase(10);
                

            }
            catch(UnaExcepcion ex)
            {
                throw new MiExcepcion("otra clase", ex);
            }
        }
    }
}
