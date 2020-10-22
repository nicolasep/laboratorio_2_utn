using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ListasGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Comic comic = new Comic("Un comic", 256, 150, "yo", Comic.TipoComic.Oriental);
            Factura<Comic> factura = new Factura<Comic>();
            string text = factura.GenerarFactura(comic, 2);
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
