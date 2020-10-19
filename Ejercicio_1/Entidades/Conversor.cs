using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            int aux;
            string resultado = "";

            while (numero > 1)
            {
                aux = numero % 2;

                resultado = Convert.ToString(aux) + resultado;
                numero = numero / 2;
            }
            resultado = Convert.ToString(numero) + resultado;

            return resultado;
        }
        public static int BinarioDecimal(string numero)
        {
            int contador = 1;
            int multiplo = 1;
            int resultado = 0;

            foreach (char letra in numero)
            {
                multiplo = multiplo * contador;

                contador = 2;

            }
            foreach (char l in numero)
            {

                if (l == '1')
                {
                    resultado += multiplo * 1;
                }
                multiplo /= 2;

            }
            return resultado;
        }

    }
}
