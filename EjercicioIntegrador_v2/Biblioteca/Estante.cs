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
            productos  = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion):this(capacidad)
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
            stringBuilder.AppendLine($"La ubicacion del estante es: {e.ubicacionEstante}");
            stringBuilder.AppendLine("Los productos del estante son: ");
            for( int i= 0; i<e.productos.Length; i++)
            {
                stringBuilder.AppendLine(Producto.MostrarProducto(e.productos[i]));
            }
            return stringBuilder.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            for (int i=0; i<e.productos.Length; i++)
            {
                if(e.productos[i] == p)
                {
                    return true;
                }
            }
            return false; 
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static Estante operator -(Estante e, Producto p)
        {
            Producto[] auxProductos = e.GetProductos();
            for(int i= 0; i<auxProductos.Length; i++)
            {
                if(auxProductos[i]==p)
                {
                    auxProductos[i] = null;
                }
            }
            Estante auxEstante = new Estante(e.productos.Length, e.ubicacionEstante);
            auxEstante.productos = auxProductos;

            return auxEstante;
            
        }
        public static bool operator +(Estante e, Producto p)
        {
            for(int i=0; i<e.productos.Length; i++)
            {
                if(e.productos[i] is null && e != p)
                {
                    e.productos[i] = p;
                    return true;
                }
            }
            return false;
        }
    }
}
