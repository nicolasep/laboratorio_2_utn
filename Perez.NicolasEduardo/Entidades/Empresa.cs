using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador
{
    public class Empresa
    {
        private int limiteProductos;
        private string nombre;
        private List<Producto> prodructos;

        private Empresa(): this(" ")
        {
            
        }
        public Empresa(string nombre): this(nombre,3)
        {

        }
        public Empresa(string nombre, int limite)
        {
            this.prodructos = new List<Producto>();
            this.nombre = nombre;
            this.limiteProductos = limite;
        }
        /// <summary>
        /// devuelve la informacion completa de la empresa
        /// </summary>
        /// <returns>string con los datos de la empresa y los productos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Productos de la empresa {this.nombre}");
            foreach(Producto l in this.prodructos)
            {
                sb.AppendLine(l.Etiqueta());
            }
            return sb.ToString();
        }

        public static Empresa operator +(Empresa empresa, Producto producto)
        {
            if(empresa.limiteProductos > empresa.prodructos.Count)
            {
                empresa.prodructos.Add(producto);
            }
            return empresa;
        }
    }
}
