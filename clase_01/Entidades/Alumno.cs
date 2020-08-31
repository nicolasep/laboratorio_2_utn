using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        void CalcularFinal()
        {
            notaFinal = (nota1 + nota2) / 2;
        }
        public void Estudiar(byte nota11, byte nota22)
        {
            nota1 = nota11;
            nota2 = nota22;
            if(nota11 >= 4 && nota22 >= 4)
            {
                CalcularFinal();
            }
            else
            {
                notaFinal = -1;
            }
        }
        public string Mostrar()
        {
            if (notaFinal == -1)
            {
                Console.WriteLine("Legajo: {0} Nombre: {1} Apellido: {2} Nota1: {3} Nota2: {4} Nota final: DESAPROBADO", legajo, nombre, apellido, nota1, nota2);
            }
            else
            {
                Console.WriteLine("Legajo: {0} Nombre: {1} Apellido: {2} Nota1: {3} Nota2: {4} Nota final: {5}", legajo, nombre, apellido, nota1, nota2, notaFinal);
            }

            return "";
        }
    }
}
