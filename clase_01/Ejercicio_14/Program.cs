using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio numero 14";

            int opcion;
            double aux1;
            double aux2=0;
            double resultado;


            do
            {
                Console.WriteLine("Elija la operacion:\n1. Calcular area del cuadrado \n2. Calcular area de triangulo \n3. Calcular area del circulo ");
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Error, debe ser un numero de las opciones disponibles");
                }
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el lado: ");
                        while (!double.TryParse(Console.ReadLine(), out aux1))
                        {
                            Console.WriteLine("Error, deben ser numeros");
                        }
                        resultado = CalculoDeArea.CalcularCuadrado(aux1);
                        Console.WriteLine("El area del cuadrado es: {0}", resultado);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese base y luego altura: ");
                        while (!double.TryParse(Console.ReadLine(), out aux1)&&
                                double.TryParse(Console.ReadLine(), out aux2))
                        {
                            Console.WriteLine("Error, deben ser numeros");
                        }
                        resultado = CalculoDeArea.CalcularTriangulo(aux1,aux2);
                        Console.WriteLine("El area del triangulo es: {0}", resultado);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el radio: ");
                        while (!double.TryParse(Console.ReadLine(), out aux1))
                        {
                            Console.WriteLine("Error, deben ser numeros");
                        }
                        resultado = CalculoDeArea.CalcularCirculo(aux1);
                        Console.WriteLine("El area del circulo es: {0}", resultado);
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
