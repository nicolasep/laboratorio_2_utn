using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
        public Gente(short edad):base(null,edad)
        {

        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("GENTE ");
            sb.AppendLine(string.Format("Edad: {0}",base.Edad));

            return sb.ToString();
        }
        public override bool Validar()
        {
            if (this.Edad > 18)
            {
                return true;
            }
            return false;
        }
    }
}
