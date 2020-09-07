using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int numero)
        {
            this.cantidadSumas = numero;
        }
        public Sumador() : this(0)
        {

        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            StringBuilder stringBuilder = new StringBuilder();

            return stringBuilder.AppendFormat("{0} {1}",a,b).ToString();
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
        public static long operator +(Sumador valor1, Sumador valor2)
        {

            return valor1.cantidadSumas + valor2.cantidadSumas;
        }
        public static bool operator |(Sumador valor1, Sumador valor2)
        {
            return valor1.cantidadSumas == valor2.cantidadSumas;
        }

    }
}
