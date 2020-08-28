using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 7

            //DateTime fechaActual = DateTime.Now.Hour;
            //string fecha = fechaActual.ToString();
            int horas = DateTime.Now.Hour;
            //fechaActual.ToString();
            int minutos = DateTime.Now.Minute;
            int day = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int anio = DateTime.Now.Year;

            //Console.WriteLine("actual: {0}",fechaActual);
            Console.WriteLine("actual horas: {0}", horas);
            Console.WriteLine("actual minutos: {0}", minutos);
           

            Console.ReadKey();
        }
    }
}
