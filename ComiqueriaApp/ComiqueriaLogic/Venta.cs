using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
     public sealed class Venta
    {
        internal DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        static Venta()
        {
            porcentajeIva = 21;
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }

        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double resultado;
            resultado = precioUnidad * cantidad;
            //resultado = resultado + ((resultado * porcentajeIva) / 100);
            return resultado;
           
        }
        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0} {1} {2:00.0}", this.Fecha, this.producto.Descripcion, this.precioFinal));

            return sb.ToString();
        }
        private void Vender(int cantidad)
        {
            int aux = this.producto.Stock;
            aux -= cantidad;
            this.producto.Stock = aux;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
        }
        
    }
}
