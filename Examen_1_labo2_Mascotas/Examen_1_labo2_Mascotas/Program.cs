using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Examen_1_labo2_Mascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo grupo = new Grupo("nicolas");

            Gato gato1 = new Gato("g1", "michi1");
            Gato gato2 = new Gato("g2", "michi2");
            Gato gato3 = new Gato("g3", "michi3");
            Gato gato4 = new Gato("g4", "michi4");

            Perro perro1 = new Perro("p1", "rope1");
            Perro perro2 = new Perro("p2", "rope2");
            Perro perro3 = new Perro("p3", "rope3", 10, true);
            Perro perro4 = new Perro("p4", "rope4");

            grupo += gato1;
            grupo += perro1;
            grupo += perro2;
            grupo += gato2;
            grupo += perro3;
            grupo += gato3;
            grupo += gato4;
            grupo += perro4;

            grupo += gato2;
            grupo += perro3;

            Console.WriteLine(grupo); 
            
            Console.ReadKey();
        }
    }
}
