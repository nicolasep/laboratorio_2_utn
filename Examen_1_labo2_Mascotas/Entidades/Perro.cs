using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro :Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza):base(nombre,raza)
        {
            this.Edad = 0;
            this.EsAlfa = false;
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa):base(nombre,raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }
        public int Edad
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
        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Perro");
            sb.Append(base.DatosCompletos());
            if (this.EsAlfa)
            {
                sb.Append(", alfa de la manada");
            }
            sb.Append($", Edad: {this.Edad}");

            return sb.ToString();
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            return (j1.Nombre == j2.Nombre && j1.Raza == j2.Raza && j1.Edad == j2.Edad);
        }
        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }
        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            return  (Perro)obj == this;
        }
    }
}
