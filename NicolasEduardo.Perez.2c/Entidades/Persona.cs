using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;


        protected Persona(string nombre, short edad)
        {
            this.Edad = edad;
            this.Nombre = nombre;
        }
        public short Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value; 
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        /// <summary>
        /// imprime los datos de una persona
        /// </summary>
        /// <returns>devuelve un string con los datos de la persona</returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.Nombre} Edad: {this.Edad}");


            return sb.ToString();
        }
        
        public abstract bool Validar();

        /// <summary>
        /// sobrecarga de casteo a persona que devuelve los datos de la misma
        /// </summary>
        /// <param name="persona">devuelve un string con los datos de una persona</param>
        public static explicit operator string(Persona persona)
        {
            return persona.Mostrar();//asi esta bien
        }

    }
}
