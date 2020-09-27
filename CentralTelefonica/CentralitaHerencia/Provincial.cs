using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 };
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
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
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            :this(miFranja,new Llamada(duracion,destino,origen))
        {

        }
    }
}
