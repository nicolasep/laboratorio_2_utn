using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion):this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        public static explicit operator Dolar(Euro p)
        {
            return new Dolar(p.cantidad * Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(Pesos.GetCotizacion() * ((Dolar)e).GetCantidad());
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return ((Dolar)e).GetCantidad() == d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return ((Dolar)e).GetCantidad() == ((Dolar)p).GetCantidad();
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)(d.GetCantidad()/Euro.GetCotizacion())).cantidad);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)(d.GetCantidad() / Euro.GetCotizacion())).cantidad);
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }

    }
}
