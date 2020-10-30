using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtenLong
    {
        public static int ContarDigitos(this long numero)
        {
            
            string aux = numero.ToString();
            int contador = 0;
            
            for (int i=0; i<aux.Length;i++)
            {
                if(aux[i] >= '0' && aux[i] <= '9')
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
