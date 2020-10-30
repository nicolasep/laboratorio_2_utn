using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtenString
    {
        public static int ContarSignos(this string palabra)
        {
            int contador = 0;
            for(int i=0; i< palabra.Length;i++)
            {
                if (palabra[i] =='.' || palabra[i] == ',' || palabra[i] == ';')
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
