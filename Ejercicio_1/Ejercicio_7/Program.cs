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
            Console.Title = "Ejercicio numero 7";
            
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int anio = DateTime.Now.Year;

           
            int anioNac;
            int mesNac;
            int diaNac;
            int acumuladorDias = 0;

            Console.WriteLine("Ingrese el año de nacimiento, primero el dia, luego el mes y por ultimo el año");

            while ((!(int.TryParse(Console.ReadLine(), out diaNac) &&
                    int.TryParse(Console.ReadLine(), out mesNac) &&
                    int.TryParse(Console.ReadLine(), out anioNac)))||
                    anioNac > anio || mesNac > 12 || (mesNac > mes && anio == anioNac) || diaNac > DateTime.DaysInMonth(anioNac,mesNac))
            {
                Console.WriteLine("Error deben ser numeros, reintente");
                Console.WriteLine("Ingrese el año de nacimiento, primero el dia, luego el mes y por ultimo el año");
            }

            for(int i=anioNac;i<=anio;i++)
            {
                for(int j=1;j<=12 && anioNac < anio;j++)
                {
                    if(i==anioNac && j<mesNac)
                    {
                        continue;
                    }
                    acumuladorDias += DateTime.DaysInMonth(i,j);
                }
                acumuladorDias -= diaNac;
                for(int z=1;z<mes && anio == i;z++)
                {
                    if(anio == anioNac && z < mesNac)
                    {
                        continue;
                    }
                    acumuladorDias += DateTime.DaysInMonth(anio, z);
               
                }
                acumuladorDias += dia;

            }
            
            Console.WriteLine("La cantidad de dias vividos hasta la fecha: {0}/{1} son: {2}", mes, anio, acumuladorDias);
            

           

            Console.ReadKey();
        }
    }
}
