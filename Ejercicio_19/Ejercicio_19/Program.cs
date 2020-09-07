using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*a. Crear dos constructores:
        i. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
        ii. Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
        b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
        siguiente lógica:
        i. En el caso de Sumar(long, long) sumará los valores numéricos
        ii. En el de Sumar(string, string) concatenará las cadenas de texto.
        Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.
        c. Generar una conversión explícita que retorne cantidadSumas.
        d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
        con dicho valor.
        e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
        cantidadSumas.
        Agregar un segundo objeto del tipo Sumador en el Main y probar el código.*/



            
            Sumador numero1 = new Sumador();
            Sumador numero2 = new Sumador();
            Console.WriteLine("La suma es {0}", numero1.Sumar(5, 3));
            
            numero1.Sumar("nico", "jose");
            numero2.Sumar(1, 2);
            Console.WriteLine("El numero 1 y 2 son: {0}", (numero2 | numero1));


            Console.ReadKey();



     
        }
    }
}
