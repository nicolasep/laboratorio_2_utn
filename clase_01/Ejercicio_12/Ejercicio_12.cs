using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_12
{
    class Ejercicio_12
    {
        static void Main()
        {
            int acumulador = 0;
            int numero;
            char respuesta1;
            char respuesta;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero: ");

                } while (!int.TryParse(Console.ReadLine(), out numero));
                acumulador += numero;
                Console.WriteLine("Desea seguir ingresando? ingrese S/N");
                respuesta1 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("la respuesta es: {0}", respuesta1);
                char.TryParse(Console.ReadLine(), out respuesta);

            } while (ValidarRespuesta.ValidaS_N(respuesta));

            Console.WriteLine("La suma total es: {0}", acumulador);


            Console.ReadKey();

        }
    }
}
