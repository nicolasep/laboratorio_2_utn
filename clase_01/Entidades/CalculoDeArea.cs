using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double numero)
        {
            
            return (numero*numero);
        }
        public static double CalcularTriangulo(double tBase, double tAltura)
        {

            return (tBase*tAltura)/2;
        }
        public static double CalcularCirculo(double radio)
        {
            double resultado = Math.PI * (radio * radio);
            return resultado;
        }
    }
}
