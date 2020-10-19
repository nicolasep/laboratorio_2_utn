using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio numero 9";

            int columna = 5;
            int fila = 1;

            for (int i = 1; i <= columna; i++)
            {
                for(int j=0 ;j<fila;j+=2)
                {
                    Console.Write("*");
                }
                fila += 4;
                Console.WriteLine("");
            }


            Console.ReadKey();
        }
    }
}
