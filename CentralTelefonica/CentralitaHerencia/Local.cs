using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }
        public Local(Llamada llamada, float costo)
            :base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo)
            :this(new Llamada(duracion,destino,origen),costo)
        {
            

        }
        public override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");
           

            return stringBuilder.ToString();
        }
    }
}
