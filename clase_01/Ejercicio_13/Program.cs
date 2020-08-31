using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
            string DecimalBinario(int). Convierte un número de entero a binario.
            int BinarioDecimal(string). Convierte un número binario a entero.
            NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.*/

            Console.Title = "Ejercicio numero 13";

            /*int numero = 10;
            string aux;
            int resul;
            bool ver = true;
            decimal alt;
            resul = numero % 2;*/
            /* double prueba;

             int numero, exp, digito;
             double binario;
             numero = 10;
             exp = 0;
             binario = 0;

             string aux="";
             int contador = 0;

             while (numero != 0)
             {

                 digito = numero % 2;
                 Console.WriteLine("digito {0}  ", digito);
                 binario = binario + digito * Math.Pow(10, exp);
                 Console.WriteLine("binario + digito {0}  ", binario + digito);
                 prueba = Math.Pow(10, exp);
                 Console.WriteLine(" resultado math {0}  ", prueba);
                 Console.WriteLine(" resultado binario {0}  ", binario);
                 Console.WriteLine(" ---------- ");
                 exp++;
                 numero = numero / 2;
                 digito = numero % 2;
                 aux += digito.ToString();
                 Console.WriteLine("concat {0}", aux);
                 numero = numero / 2;


                // aux = string.Concat(digito);
             }
             int contador2 = 0;
             string auxFinal = "";
             bool valida = true;

             for (int i=contador;i>0;i--)
             {
                 foreach(char numeros in aux)
                 {
                     contador++;

                 }
                 contador2 = contador;
                 foreach(char final in aux)
                 {
                     if()
                 }

             }*/

            //Console.WriteLine("{0}  ", binario);
            /*
            do
            {
                if (numero % 2 == 0)
                {
                    

                }

            } while (ver);*/




            string numeroBinario;
            int numeroDecimal;
            int opcion;

            do
            {
                Console.WriteLine("Elija la operacion:\n1. Pasar decimal a binario \n2. Pasar de binario a decimal");
                while(!int.TryParse(Console.ReadLine(),out opcion))
                {
                    Console.WriteLine("Error, debe ser un numero de las opciones disponibles");
                }
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese numero en decimal");
                        while (!int.TryParse(Console.ReadLine(), out numeroDecimal))
                        {
                            Console.WriteLine("Error, deben ser numeros");
                        }
                        numeroBinario = Conversor.DecimalBinario(numeroDecimal);
                        Console.WriteLine("El numero: {0} en binario es: {1}", numeroDecimal, numeroBinario);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese numero en binario");
                        numeroBinario = Console.ReadLine();
                        numeroDecimal = Conversor.BinarioDecimal(numeroBinario);
                        Console.WriteLine("El numero: {0} en decimal es: {1}", numeroBinario, numeroDecimal);
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

                Console.WriteLine("Desea realizar otra conversion?? ingrese S/N");
            } while (ValidarRespuesta.ValidaS_N(Convert.ToChar(Console.ReadLine())));

            
            
            Console.ReadKey();
        }
    }
}
