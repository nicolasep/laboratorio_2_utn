using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 6

            string ingresoUs;
            int numeroInicio;
            int numeroFin;

            Console.WriteLine("Ingrese el año de inicio");
            ingresoUs = Console.ReadLine();
            int.TryParse(ingresoUs, out numeroInicio);

            Console.WriteLine("Ingrese el año de fin");
            ingresoUs = Console.ReadLine();
            int.TryParse(ingresoUs, out numeroFin);

            for (int i = numeroInicio; i <= numeroFin; i++)
            {
                if (i % 4 == 0)
                {

                    if (i % 100 == 0 && i % 400 != 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("El año: {0} es bisiesto", i);
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
