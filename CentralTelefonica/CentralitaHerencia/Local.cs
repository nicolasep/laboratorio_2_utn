using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {

        /*d. Sobreescribir el método Mostrar. Será protegido. Reutilizará el código escrito en la clase
        base y además agregará la propiedad CostoLlamada, utilizando un StringBuilder.
        e. Equals retornará true sólo si el objeto que recibe es de tipo Local.
        f. ToString reutilizará el código del método Mostrar.*/

        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Local;
        }
        public override string ToString()
        {
            return Mostrar();
        }
        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }
        public Local(Llamada llamada, float costo):this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
            //:base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            
        }
        public Local(string origen, float duracion, string destino, float costo):base(duracion,destino,origen)
            //:this(new Llamada(duracion,destino,origen),costo)
        {
            this.costo = costo;

        }
        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");
           

            return stringBuilder.ToString();
        }
    }
}
