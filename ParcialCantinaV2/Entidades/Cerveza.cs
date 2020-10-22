using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML):this(capacidadML,marca,Botella.Tipo.Vidrio,contenidoML)
        {

        }
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML):base(marca,capacidadML,contenidoML)
        {
            this.tipo = tipo;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Cerveza {base.ToString()}");
            return sb.ToString();
        }
        public override int ServirMedida()
        {
            if (MEDIDA <= this.contenidoML)
            {
                this.contenidoML -= ((MEDIDA*80)/100);
            }
            else
            {
                this.contenidoML -= this.contenidoML;
            }
            return this.contenidoML;
        }
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
