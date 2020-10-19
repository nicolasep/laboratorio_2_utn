using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public OtraClase()
        {
            OtroError();
        }
        public static void OtroError()
        {
            try
            {
                MiClase aux = new MiClase();
            }
            catch(UnaExcepcion ex)
            {
                throw new MiExcepcion("error3", ex);
            }
        }
    }
}
