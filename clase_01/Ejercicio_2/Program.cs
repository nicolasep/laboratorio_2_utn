using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
             * Sedebe validar que el número sea mayor que cero, caso contrario,mostrar el mensaje: 
             * "ERROR. ¡Reingresar número!".Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
            */

            Console.Title = "Ejercicio numero 2";

            string ingreso;
            int numero;
            double resultado;


            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();
            while(!int.TryParse(ingreso, out numero) && numero == 0)
            {
                Console.WriteLine("Error, se debe ingresar un numero mayor a cero");
                ingreso = Console.ReadLine();
            }
            
            resultado = Math.Pow(numero,2);
            Console.WriteLine("El el numero: {0} elevado al cubo es: {1}", numero, resultado);
            
            Console.ReadKey();
        }
    }
}
