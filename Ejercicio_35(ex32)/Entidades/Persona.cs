using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
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
        public Persona(long dni, string nombre)
        {

        }
        public Persona(string nombre)
        {

        }
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.Nombre} Dni: {this.Dni}");

            return sb.ToString();
        }
    }
}
