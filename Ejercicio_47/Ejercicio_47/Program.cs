using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {

            Torneo<EquipoFutbol> futbol = new Torneo<EquipoFutbol>("nico1");
            Torneo<EquipoBasquet> basquet = new Torneo<EquipoBasquet>("nico2");

            EquipoFutbol e1 = new EquipoFutbol("boca", DateTime.Today);
            EquipoFutbol e2 = new EquipoFutbol("river", DateTime.Today);
            EquipoFutbol e3 = new EquipoFutbol("chacarita", DateTime.Today);

            EquipoBasquet b1 = new EquipoBasquet("nose1", DateTime.Today);
            EquipoBasquet b2 = new EquipoBasquet("nose2", DateTime.Today);
            EquipoBasquet b3 = new EquipoBasquet("nose3", DateTime.Today);
            
            bool res;
            res = futbol + e1;
            res = futbol + e2;
            res = futbol + e3;
            res = futbol + e2;

            Console.WriteLine("----------------------------");
            Console.WriteLine(futbol.Mostrar());
            Console.WriteLine("----------------------------");
            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine("----------------------------");
            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine("----------------------------");
            res = basquet + b1;
            res = basquet + b2;
            res = basquet + b3;
            res = basquet + b1;
            Console.WriteLine("----------------------------");
            Console.WriteLine(basquet.Mostrar());
            Console.WriteLine("----------------------------");
            Console.WriteLine(basquet.JugarPartido);
            Console.WriteLine("----------------------------");
            Console.WriteLine(basquet.JugarPartido);
            Console.WriteLine("----------------------------");


            Console.ReadKey();
        }
    }
}
