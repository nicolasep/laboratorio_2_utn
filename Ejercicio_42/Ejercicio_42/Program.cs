using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                OtraClase otra = new OtraClase();
            }
            catch(MiExcepcion ex)
            {
                Console.WriteLine("fue errror");
                Console.WriteLine($"Excepcion  {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
