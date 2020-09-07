using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Mascota mascota;//declarar el objeto

            //instanciacion del objeto. se llama al new y al constructor para dar estado inicial al objeto
            mascota = new Mascota("Salem",new DateTime(1990, 01, 20),"Gato");
            //el new reserva memoria y el constructor le sda un estado inicial

            */

            //instanciar las 4 mascotas
            Mascota perro = new Mascota("lolo",new DateTime(1999, 06, 14), "Perro");
            Mascota perro2 = new Mascota("fatiga", new DateTime(1998, 03, 09), "Perro");
            Mascota perro3 = new Mascota("mili", new DateTime(2009, 02, 10), "Perro");
            Mascota perro4 = new Mascota("perro", new DateTime(2010, 09, 23), "Perro");
            //mostrar en consola utilizando el metodo MostrarDatos que devuelve un string, los datos de la mascota
            Console.WriteLine(perro.MostrarDatos());
            Console.WriteLine(perro2.MostrarDatos());
            Console.WriteLine(perro3.MostrarDatos());
            Console.WriteLine(perro4.MostrarDatos());

            //realizar un metodo que devuelva la edad de la mascota. usando DataTime (devuelve un int)
            perro.SetNombre("MATIAS");

            Console.WriteLine($"{perro.GetNombre()} tiene {perro.CalcularEdad()} años");


            Console.ReadKey();
        }
    }
}
