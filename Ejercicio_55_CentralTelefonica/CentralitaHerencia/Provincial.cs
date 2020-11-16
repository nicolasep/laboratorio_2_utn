using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace CentralitaHerencia
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        /*g. El método Mostrar será protegido. Reutilizará el código escrito en la clase base y agregará
        franjaHoraria y CostoLlamada, utilizando un StringBuilder.
        h. Equals retornará true sólo si el objeto que recibe es de tipo Provincial.
        i. ToString reutilizará el código del método Mostrar.*/

        public enum Franja { Franja_1, Franja_2, Franja_3 };
        protected Franja franjaHoraria;

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        public override string ToString()
        {
            return Mostrar();
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        string IGuardar<Provincial>.RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Numero de origen: {this.NroOrigen} Numero Destino: {this.nroDestino} Duracion: {this.Duracion}");
            stringBuilder.Append($"La franja horaria es: {franjaHoraria} El costo de la llamada es: {this.CostoLlamada}");
            return stringBuilder.ToString();
        }
        private float CalcularCosto()
        {
            float total = 0.0f;
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    total = this.Duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    total = this.Duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    total = this.Duracion * 0.66f;
                    break;
            }
            return total;
        }

        public override bool Guardar()
        {
            throw new NotImplementedException();
        }

        public override Llamada Leer()
        {
            throw new NotImplementedException();
        }

        Provincial IGuardar<Provincial>.Leer()
        {
            throw new NotImplementedException();
        }

        public Provincial(Franja miFranja, Llamada llamada):this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino) //: base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) :base(duracion,destino,origen)
            //:this(miFranja,((Llamadaduracion,origen,destino)))
            //:this(miFranja,(Llamada)Provincial.duracion,Provincial.destino,Provincial.origen)
        {
            this.franjaHoraria = miFranja;
        }
    }
}
