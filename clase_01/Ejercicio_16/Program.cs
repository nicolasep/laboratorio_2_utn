using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Nicolas";
            alumno1.apellido = "Perez";
            alumno1.legajo = 1;

            alumno2.nombre = "Jose";
            alumno2.apellido = "Nogeira";
            alumno2.legajo = 2;

            alumno3.nombre = "Juan";
            alumno3.apellido = "Lalin";
            alumno3.legajo = 3;

            alumno1.Estudiar(9, 9);
            alumno2.Estudiar(3, 4);
            alumno3.Estudiar(8, 7);

            alumno1.Mostrar();
            alumno2.Mostrar();
            alumno3.Mostrar();


            Console.ReadKey();


        }
    }
}
