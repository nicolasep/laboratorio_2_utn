using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }
        public string MiAtributo
        {
            get
            {
                return this.miAtributo;
            }
        }
        public abstract string MiMetodo();
        public override string ToString()
        {
            return "¡Este es mi metodo ToString sobreescrito!";
        }
        public override bool Equals(object obj)
        {
            return this==obj;
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
