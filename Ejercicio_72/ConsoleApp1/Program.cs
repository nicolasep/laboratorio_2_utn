using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.WriteLine("Ingrese un numero");
                
                long aux;
                long.TryParse(Console.ReadLine(), out aux);
               
                Console.WriteLine($"El numero tiene: {aux.ContarDigitos()} digitos");
                
            } while(true);

                
        }
    }
}
