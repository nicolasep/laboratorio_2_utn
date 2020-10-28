using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia) : this(numero, escuderia,0)
        {

        }
        public MotoCross(short numero, string escuderia, short cilindrada) : base(numero, escuderia)
        {
            this.Cilindrada = cilindrada;

        }
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.MostrarDatos()} {this.cilindrada}");

            return sb.ToString();
        }
        public static bool operator ==(MotoCross m1, MotoCross m2)
        {

            return (VehiculoDeCarrera)m1 == (VehiculoDeCarrera)m2 && m1.cilindrada == m2.cilindrada;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
