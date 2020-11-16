using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();

            Negocio negocio = new Negocio(c1, c2);

            Thread asignar = new Thread(negocio.AsignarCaja);
            Thread atenderCaja1 = new Thread(c1.AtenderClientes);
            atenderCaja1.Name = "Caja 1";
            Thread atenderCaja2 = new Thread(c2.AtenderClientes);
            atenderCaja2.Name = "caja2";
            asignar.Start();
            asignar.Join();
            atenderCaja1.Start();
            atenderCaja2.Start();
            Console.ReadKey();
        }
    }
}
