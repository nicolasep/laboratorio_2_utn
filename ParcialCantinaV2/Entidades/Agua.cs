using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        public const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoML):base(marca,capacidadML,contenidoML)
        {

        }
        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Agua {base.ToString()}");

            return sb.ToString();
        }
        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);
        }
        public int ServirMedida(int medida)
        {
            if (medida <= this.contenidoML)
            {
                this.contenidoML -= medida;
            }
            else
            {
                this.contenidoML -= this.contenidoML;
            }
            return this.contenidoML;
        }

    }
}
