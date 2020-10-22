using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.Stock = stock;
            this.precio = precio;
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion; 
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
            }
        }
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Descripcion: {0}\nCodigo: {1}\nPrecio: {2}\nStock: {3}", this.Descripcion, this.codigo, this.Precio, this.Stock));

            return sb.ToString();
        }
    }
}
