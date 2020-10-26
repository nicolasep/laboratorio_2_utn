using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class MiClase 
    {
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("metodo1");
        }
        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
        }
        public MiClase(int i)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("mi clase",ex);
            }
        }
    }
}
