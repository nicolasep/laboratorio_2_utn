using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private int legajo;
        private int dni;
        //sobrecarga de metodos y constructores
        public Persona(string divisor)
        {
            this.nombre = divisor;
        }
        public Persona(int divisor, int dividendo) : this(divisor)
        {
            this.legajo = dividendo;
        }
        public double Sumar(int a, int b)
        {
            return a + b;
        }
        public float Sumar(float a, float b)
        {
            return a + b;
        }
        //sobrecarga de operadores
        public static bool operator ==(Persona p1, int dni)
        {
            return p1.dni == dni;
        }
        public static bool operator !=(Persona p1, int dni)
        {
            return !(p1 == dni);
        }
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1.dni == p2.dni);
        }

        //sobrecarga de operadores
        //implicita
        public static implicit operator Persona (int dni)
        {
            return new Persona;
        }
    }
}
