using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 5

            int i;
            int j;
            int z;
            int acumulador1 = 0;
            int acumulador2 = 0;
            
            for (i = 1; i < 10000; i++)
            {
                for (j = i - 1; j >= 1; j--)
                {
                    acumulador1 += j;
                }
                for (z = i + 1; acumulador2 < acumulador1; z++)
                {
                    acumulador2 += z;
                }

                if (acumulador1 == acumulador2)
                {
                    Console.WriteLine("El numero: {0} es centro numerico", i);
                }
                acumulador1 = 0;
                acumulador2 = 0;
            }
            Console.ReadKey();

        }
    }
}
