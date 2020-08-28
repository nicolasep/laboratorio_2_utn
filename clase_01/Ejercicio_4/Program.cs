using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
             * (excluido el mismo) que son divisores del número.El primer número perfecto es 6, ya que los divisores 
             * de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.Escribir una aplicación que encuentre los 4 primeros números 
             * perfectos.Nota: Utilizar estructuras repetitivas y selectivas.*/

            
            Console.Title = "Ejercicio numero 4";
            int acumulador = 0;

            for (int i = 1; i < 100000; i++)
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;
                    }
                }
                if (acumulador == i)
                {
                    Console.WriteLine("el numero: {0} es numero perfecto", i);
                }
                acumulador = 0;
            }

            Console.ReadKey();
        }
    }
}
