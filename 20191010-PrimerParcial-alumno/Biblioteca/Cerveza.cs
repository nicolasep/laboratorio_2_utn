using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        const int MEDIDA = 330;
        protected Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contedidoML) : base(marca,capacidadML,contedidoML)
        {
            this.tipo = Tipo.Vidrio;
        }
        public Cerveza(int capacidadML, string marca,Tipo tipo ,int contedidoML):this(capacidadML,marca,contedidoML)
        {
            this.tipo = tipo;

        }
        public override int ServirMedida()
        {
            if (MEDIDA <= ((this.contenidoML * 80) / 100))
            {
                this.contenidoML -= ((MEDIDA*80)/100);
            }
            else
            {
                this.contenidoML -= this.contenidoML;
            }
            return this.contenidoML;
        }
        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Botella de Cerveza");
            sb.AppendLine(base.GenerarInforme());

            return sb.ToString();
        }
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo = Tipo.Vidrio;
        }

    }
}
