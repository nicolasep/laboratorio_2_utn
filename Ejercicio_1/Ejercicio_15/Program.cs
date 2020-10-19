using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
            multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
            operación que desea realizar (pulsando el caracter +, -, * ó /).
            El usuario decidirá cuándo finalizar el programa.
            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
            a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
            operación matemática. El método devolverá el resultado de la operación.
            b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
            utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
            TRUE si el número es distinto de CERO.*/

            Console.Title = "Ejercicio Numero 15";

            char operacion;
            float num1;
            float num2;
            float resultado;
            char respuesta;

            do
            {
                Console.WriteLine("Ingrese dos numeros:");

                while (!Single.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Error, deben ser numeros");
                }
                while (!Single.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Error, deben ser numeros");
                }
                Console.WriteLine("Elija la operacion (+ - * /)");
                operacion = Convert.ToChar(Console.ReadLine());
                resultado = Calculadora.Calcular(num1, num2, operacion);
                if (resultado == -1 && operacion == '/')
                {
                    Console.WriteLine("No es posible dividir por cero");
                }
                else
                {
                    Console.WriteLine("El resultado de la operacion: {0} entre los numeros {1} y {2} es: {3}", operacion, num1, num2, resultado);
                }

                Console.WriteLine("Desea realizar otra operacion?? elija S/N");

                char.TryParse(Console.ReadLine(), out respuesta);

            } while (ValidarRespuesta.ValidaS_N(respuesta));


            Console.ReadKey();
        }
    }
}
