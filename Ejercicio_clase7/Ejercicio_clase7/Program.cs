using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeNombres = new List<string>();
            
            listaDeNombres.Add("Fede");
            listaDeNombres.Add("Claudia");
            listaDeNombres.Add("Mauricio");

            foreach ( string nombre in listaDeNombres)
            {
                Console.WriteLine(nombre);
            }
            Console.WriteLine("---------------------");
            listaDeNombres.Remove("Mauricio");


            for(int i= 0; i< listaDeNombres.Count; i++)
            {
                Console.WriteLine(listaDeNombres[i]);
            }
            listaDeNombres.RemoveAt(0);
            Console.WriteLine("---------------------");
            Console.WriteLine(listaDeNombres[0]);

            Console.ReadKey();

        }
        
    }
}
