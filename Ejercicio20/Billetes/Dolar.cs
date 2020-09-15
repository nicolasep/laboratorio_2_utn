using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private double cotizRespectoDolar;

        private Dolar()
        {

        }
        public Dolar(double cantidad)
        {

        }
        public Dolar(double cantidad, double cotizacion)
        {

        }
        public double GetCantidad()
        {
            return 0;
        }
        public double GetCotizacion()
        {
            return 0;
        }
        public static Euro explicit operator Euro(Dolar d)
        {

            return Euro;

        }
        public static Pesos explicit operator Pesos(Dolar d)
        {
            return Pesos;

        }




    }
}
