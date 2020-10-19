using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio numero 10";

            int columna = 5;
            int fila = 1;
            int espacios = 15;

            for (int i = 1; i <= columna; i++)
            {
                
                for (int z = espacios; z > 1; z -= 3)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < fila; j += 2)
                {
                    
                    Console.Write("*");
                }
                fila += 4;
                espacios -=3;
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
