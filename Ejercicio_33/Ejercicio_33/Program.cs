using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libros = new Libro();

            //
            libros[0] = "888bb";
            libros[1] = "bbbb";
            libros[2] = "cccc";
            libros[3] = "dddd";
            libros[4] = "aaaa";

            libros.Mostrar();
            Console.WriteLine($"El libro es: {libros[2]}");
            libros[2] = "qqqqq";
            libros.Mostrar();
            Console.WriteLine($"El libro es: {libros[2]}");
            libros[8] = "zzzz";
            Console.WriteLine($"El libro es: {libros[4]}");

            Console.ReadKey();
        }
    }
}
