using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_73
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Ingrese una palabra");
                string palabra = Console.ReadLine();
                Console.WriteLine($"La palabra tiene: {palabra.ContarSignos()} cantidad de signos");

            } while (true);
        }
    }
}
