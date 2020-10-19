using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Ejercicio_11
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            int numero;
            string ingreso;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acumulador = 0;
            float promedio;

            Console.WriteLine("Ingrese 10 numeros");
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese numero {0}", i + 1);
                    ingreso = Console.ReadLine();
                }
                while (!int.TryParse(ingreso, out numero));

                if (Validacion.Validar(numero, -100, 100))
                {
                    if (numero < min)
                    {
                        min = numero;
                    }
                    else if (numero > max)
                    {
                        max = numero;
                    }
                    acumulador += numero;
                }

            }

            promedio = (float)acumulador / 10;

            Console.WriteLine("El numero maximo es: {0}  El numero minimo es: {1}", max, min);
            Console.WriteLine("El promedio es: {0}", promedio);


            Console.ReadKey();

        }
    }
}
