using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por 
             * consola.Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%)*/

            Console.Title = "Ejercicio numero 3";
            string ingresoU;
            int numero;
            int i;
            bool esPrimo = true;

            Console.WriteLine("Ingrese un numero");
            ingresoU = Console.ReadLine();
            
            while(!int.TryParse(ingresoU,out numero))
            {
                Console.WriteLine("Error, debe ingresar solo numeros");
                ingresoU = Console.ReadLine();
            }
            for(i = numero-1; i>1; i--)
            {
                if(numero%i == 0)
                {
                    esPrimo = false;
                }
            }
            if(esPrimo)
            {
                Console.WriteLine("El numero: {0} es primo", numero);
            }
            else
            {
                Console.WriteLine("El numero: {0} no es primo", numero);
            }


            Console.ReadKey();
            
        }
    }
}
