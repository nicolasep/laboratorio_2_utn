using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            MotoCross m1 = new MotoCross(1, "ferrari",500);
            MotoCross m2 = new MotoCross(2, "mclaren",600);
            MotoCross m3 = new MotoCross(3, "fiat",300);
            MotoCross m4 = new MotoCross(4, "porche",450);
            MotoCross m5 = new MotoCross(5, "lamborgini",900);

            AutoF1 a1 = new AutoF1(1, "auto1", 300);
            AutoF1 a2 = new AutoF1(2, "auto2", 600);
            AutoF1 a3 = new AutoF1(3, "auto3", 350);
            AutoF1 a4 = new AutoF1(4, "auto4", 450);
            AutoF1 a5 = new AutoF1(5, "auto5", 200);
            bool n;
            
            Competencia competencia = new Competencia(10, 4, Competencia.TipoCompetencia.F1);
            try
            {
                n = competencia + a1;
                n = competencia + a3;
                n = competencia + m1;
                n = competencia + m4;
                n = competencia + a4;
                n = competencia + a5;
                n = competencia + a2;
            }
            catch(CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            Console.WriteLine("Competencia F1\n");
            Console.WriteLine(competencia.MostrarDatos());
            Console.WriteLine("-----------------------------------\n");
            
            
            Competencia competencia2 = new Competencia(1055, 6, Competencia.TipoCompetencia.MotoCross);
            try
            {
                n = competencia2 + m1;
                n = competencia2 + m2;
                n = competencia2 + m3;
                n = competencia2 + m4;
                n = competencia2 + m5;
                n = competencia2 + a2;
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("Competencia Moto\n");
            Console.WriteLine(competencia2.MostrarDatos());
            
            Console.ReadKey();
        }
    }
}
