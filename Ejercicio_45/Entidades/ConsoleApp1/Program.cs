using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_42;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase n = new OtraClase();
                n.OtroMetodoDeInstancia();
            }
            catch (Exception ex) //(MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    Console.WriteLine(ex.Message);
                    
                }
                /*
                Exception inneer = ex.InnerException;
                Console.WriteLine(ex.Message);
                while (inneer != null)
                {
                    Console.WriteLine(inneer.Message);
                    inneer = inneer.InnerException;
                }*/
                
            }
            Console.ReadKey();
        }
    }
}
