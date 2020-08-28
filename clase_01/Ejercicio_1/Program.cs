using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar 5 números por consola, guardándolos en una variable escalar.
             * Luego calcular y mostrar: el valor máximo, el valormínimo y el promedio*/
            Console.Title = "Ejercicio 1";
            string ingresoUs;
            int numero;
            
            int max = 0; // se puede usar int.MinValue
            int min = 0; // se puede usar int.MaxValue
            int acumulador = 0;
            float promedio;
            int i;

            for (i = 0; i < 5; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese numero {0}: ", i + 1);
                    //numero = Convert.ToInt32(Console.ReadLine());
                    ingresoUs = Console.ReadLine();
                    if (int.TryParse(ingresoUs, out numero))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error, debe ingresar solo numeros");
                    }


                } while (true);
                    
                

                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else
                {
                    if (numero > max)
                    {
                        max = numero;
                    }
                    else if (numero < min)
                    {
                        min = numero;
                    }
                }
                acumulador += numero;

            }
            promedio = acumulador / i;

            Console.WriteLine("El numero maximo es: {0}  Y el minimo es: {1}", max, min);
            Console.WriteLine("El promedio es: {0:#,###.00}", promedio);


            Console.ReadKey();
        }
    }
}
