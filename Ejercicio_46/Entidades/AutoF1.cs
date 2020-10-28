using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1 :VehiculoDeCarrera
    {
        private short caballosDeFuerza;   

        public AutoF1(short numero, string escuderia):this(numero, escuderia,0)
        {

        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza):base(numero,escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;

        }
        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.MostrarDatos()} {this.caballosDeFuerza}");

            return sb.ToString();
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            
            return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.caballosDeFuerza == a2.caballosDeFuerza ;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}
