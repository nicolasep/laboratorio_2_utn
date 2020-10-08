using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PracticaParcialEquipo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico d1 = new DirectorTecnico("Nicolas", "Perez");
            Equipo e1 = new Equipo("El pichi", d1, Equipo.Deportes.Futbol);

            Jugador j1 = new Jugador("jose", "lopez", 2, true);
            Jugador j2 = new Jugador("matias", "gil", 4, false);
            Jugador j3 = new Jugador("alejandro", "armolla", 6, false);
            Jugador j4 = new Jugador("felipe", "sosa");
            Jugador j5 = new Jugador("cristian", "fernandez", 9, false);

            e1 += j1;
            e1 += j2;
            e1 += j3;
            e1 += j4;
            e1 += j5;

            Console.WriteLine(e1);

            Console.WriteLine("-----------------------");
            e1 -= j3;
            e1 += j1;
            Console.WriteLine(e1);

            Console.ReadKey();


        }
    }
}
