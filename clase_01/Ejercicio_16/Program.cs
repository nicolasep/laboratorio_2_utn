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
            Alumno alumno1 = new Alumno("Nicolas","lopez",01);
            Alumno alumno2 = new Alumno("Matias","Gil",02);
            Alumno alumno3 = new Alumno("Alejandro","Lencina",03);

            

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
