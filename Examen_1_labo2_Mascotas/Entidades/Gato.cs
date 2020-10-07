using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Gato");
            sb.Append(base.DatosCompletos());

            return sb.ToString();
        }
        public static bool operator ==(Gato obj1, Gato obj2)
        {
            return (obj1.Nombre == obj2.Nombre && obj1.Raza == obj2.Raza);
        }
        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            return (Gato)obj == this;
        }
    }
}
