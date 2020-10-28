using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> n = new Contabilidad<Factura,Recibo>();
            Recibo recibo = new Recibo(55);
            Factura factura = new Factura(88);
            n += recibo;
            n += factura;

            

            Console.WriteLine(n.Mostrar());


            Console.ReadKey();
        }
    }
}
