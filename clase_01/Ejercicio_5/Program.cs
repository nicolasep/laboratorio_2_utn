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
            Console.Title = "Ejercicio numero 5";

            int i;
            int j;
            int z;
            int acumulador1 = 0;
            int acumulador2 = 0;
            int numero;
            bool flag = false;
            

            Console.WriteLine("Ingrese un numero");

            while(!int.TryParse(Console.ReadLine(),out numero))
            {
                Console.WriteLine("Error, deben ser numeros");
            }

            for (i = 1; i <= numero; i++)
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
                    if(numero == i)
                    {
                        flag = true;
                    }
                    
                } 

                acumulador1 = 0;
                acumulador2 = 0;
            }
            if(flag)
            {
                Console.WriteLine("El numero elejido: {0} es centro numerico", numero);
            }
            else
            {
                Console.WriteLine("El numero elejido: {0} NO es centro numerico", numero);
            }


            Console.ReadKey();

        }
    }
}
