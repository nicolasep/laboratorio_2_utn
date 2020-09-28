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
            return p.codigoDeBarra;
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
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Producto marca: {p.GetMarca()} el codigo de barras: {p.CodigoDeBarra} el precio es: {p.GetPrecio()}");

            return stringBuilder.ToString();

        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            return !(p2 is null || p1 is null) && p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;

        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, string marca)
        {
            return (p1.marca == marca );
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }
        public Producto(string marca, string codigo, float precio)
        {
            this.CodigoDeBarra = codigo;
            this.Marca = marca;
            this.Precio = precio;
        }
        public string CodigoDeBarra
        {
            get
            {
                return this.codigoDeBarra;
            }
            set
            {
                this.codigoDeBarra = value;
            }
        }
        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }
        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

    }
}
