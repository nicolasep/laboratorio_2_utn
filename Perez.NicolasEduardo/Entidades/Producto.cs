using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public abstract class Producto
    {
        private string nombre;
        private Origen origen;
        private int valorDeCompra;

        public enum Origen
        {
            Nacional, Importado
        }

        protected Producto(string nombre, int valorDeCompra, Origen origen)
        {
            this.nombre = nombre;
            this.valorDeCompra = valorDeCompra;
            this.origen = origen;
        }

        public virtual int PorcentajeGanancia
        {
            get
            {
                return 0;
            }
        }
        public virtual int PorcentajeImpuestoImportacion
        {
            get
            {
                if((Origen)this==Origen.Importado)
                {
                    return 35;
                }
                else
                {
                    return 0;
                }
                //((this.valorDeCompra*35)/100);
            }
        }
        public virtual int PorcentajeImpuestoInterno
        {
            get
            {
                return 21;
            }
        }
        public virtual float ValorDeVenta
        {
            get
            {
                float total = 0f;
                
                total = this.valorDeCompra + ((this.valorDeCompra * this.PorcentajeImpuestoImportacion) / 100);
                total += (total * this.PorcentajeImpuestoInterno) / 100;
                total += (total * this.PorcentajeGanancia) / 100;
                return total;
                
                
            }
        }
        public virtual string Etiqueta()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Producto {this.nombre} comprado a {this.ValorDeVenta} como {(Origen)this}");
            return sb.ToString();
        }
        /// <summary>
        /// devuelve el origen del producto pasado por valor
        /// </summary>
        /// <param name="p">origen del producto</param>
        public static explicit operator Origen(Producto p)
        {
            return p.origen;
        }
    }
}
