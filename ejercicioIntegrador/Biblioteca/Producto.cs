using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra.ToString();
        }

        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;

        }
        public static string MostrarProducto(Producto p)
        {
            StringBuilder b = new StringBuilder();
            b.AppendFormat("Marca del producto: {0}  Precio: {1} Codigo de barras: {2}", p.GetMarca(), p.GetPrecio(), p.codigoDeBarra);
            return b.ToString();
        }

        public static bool operator ==(Producto p, string marca)
        {
            return !(p is null || marca is null) && p.marca == marca;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p.marca == marca);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            return !(p2 is null || p1 is null) && p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigo;
        }
    }
}
