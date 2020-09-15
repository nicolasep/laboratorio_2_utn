using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];

        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Format("Estante ubicacion {0}", e.ubicacionEstante));
            stringBuilder.AppendLine("Productos de. estante: ");

            for (int i = 0; i < e.productos.Length; i++)
            {
                stringBuilder.AppendLine(Producto.MostrarProducto(e.productos[i]));
            }


            return stringBuilder.ToString();

        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            if (!Object.ReferenceEquals(p, null) && !Object.ReferenceEquals(e, null))
            {

                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        retorno = true;
                    }
                }
            }
            Object.Equals(e, null);
            Object.Equals(p, null);
            return retorno;
            
        }
        public static bool operator !=(Estante e, Producto p)
        {
            if(!(e == p) && !(e is null && p is null))
            {
                return true;
            }

            return false;
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    
                    if (e.productos[i] is null)
                    {
                       
                        e.productos[i] = p;
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            Producto[] productosAux = e.GetProductos();
            
            for (int i = 0; i < e.productos.Length; i++)
            {

                if (productosAux[i] == p)
                {
                    productosAux[i] = null;

                }
            }
            Estante aux = new Estante(e.productos.Length);
            aux.productos = productosAux;

            return aux;
        }
    }
}
