using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        public bool Guardar(S obj)
        {
            throw new NotImplementedException();
        }

        public V Leer()
        {
            throw new NotImplementedException();
        }
    }
}
