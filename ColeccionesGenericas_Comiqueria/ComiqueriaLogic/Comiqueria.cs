using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {
                
                foreach(Producto l in this.productos)
                {
                    if((Guid)l == codigo)
                    {
                        return l;
                    }
                }
                return null;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> lista = new Dictionary<Guid, string>();
            foreach(Producto l in this.productos)
            {
                lista.Add((Guid)l, l.Descripcion);
            }
            return lista;
        }
        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();
            this.ventas.Sort(CriterioOrdenPorFecha);
            foreach(Venta l in this.ventas)
            {
                sb.AppendLine(l.ObtenerDescripcionBreve());
            }
            return sb.ToString();
        }
        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }
        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach(Producto l in comiqueria.productos)
            {
                if(l.Descripcion == producto.Descripcion)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }
        private int CriterioOrdenPorFecha(Venta v1, Venta v2)
        {
            if(v1.Fecha < v2.Fecha)
            {
                return 1;
            }
            else if( v1.Fecha > v2.Fecha)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
