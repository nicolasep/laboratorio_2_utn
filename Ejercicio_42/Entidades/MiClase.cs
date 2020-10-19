using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        public MiClase()
        {
           // Lanzar();
            try
            {
                Lanzar();
            }
            catch(DivideByZeroException)
            {
                throw new DivideByZeroException();
            }
        }
        public MiClase(string dato)
        {
            try
            {
                MiClase aux = new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("error2",ex);
            }
        }
        public static void Lanzar()
        {
            throw new DivideByZeroException();
        }

    }
}
