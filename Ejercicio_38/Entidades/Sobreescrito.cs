using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sobreescrito
    {
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
