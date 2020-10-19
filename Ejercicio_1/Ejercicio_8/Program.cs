using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
                trabajadas en el mes de N empleados de una fábrica.
                Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
                valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
                multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
                descuentos.
                Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
                bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
                Nota: Utilizar estructuras repetitivas y selectivas.*/

            Console.Title = "Ejercicio numero 8";

            float valorHora;
            string nombre;
            int antiguedad;
            float total;
            float descuento;
            float subTotal;
            int cantidadHoras;
            

            do
            {
                Console.WriteLine("Ingrese El valor de la hora:");
                while (!Single.TryParse(Console.ReadLine(), out valorHora))
                {
                    Console.WriteLine("Error, deben ser numeros. Reintente");
                }

                Console.WriteLine("Ingrese nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad en años:");
                while (!int.TryParse(Console.ReadLine(), out antiguedad))
                {
                    Console.WriteLine("Error, deben ser numeros. Reintente");
                }
                Console.WriteLine("Ingrese la cantidad de horas trabajadas:");
                while (!int.TryParse(Console.ReadLine(), out cantidadHoras))
                {
                    Console.WriteLine("Error, deben ser numeros. Reintente");
                }
                subTotal = (cantidadHoras * valorHora) +(antiguedad*150);
                descuento =(float)((subTotal/100) * 13);
                total = subTotal - descuento;

                Console.WriteLine("-----------------");
                Console.WriteLine("NOMBRE: {0}\n\n  ANTIGUEDAD: {1} VALOR_HORA: {2} TOTAL_BRUTO: {3} TOTAL DESCUENTOS: {4} NETO A COBRAR {5}", nombre,antiguedad, valorHora, subTotal, descuento, total);
                Console.WriteLine("-----------------");

                Console.WriteLine("Desea realizar otro calculo? ingrese S/N");
                
            } while (ValidarRespuesta.ValidaS_N(Convert.ToChar(Console.ReadLine())));
            
        }
    }
}
