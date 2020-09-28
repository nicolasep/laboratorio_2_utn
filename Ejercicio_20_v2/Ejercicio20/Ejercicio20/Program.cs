using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*20. Generar un nuevo proyecto del tipo Console Application. Construir tres clases dentro de un
            namespace llamado Billetes: Pesos, Euro y Dolar.
            a. Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí
            con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro
            equivale a 1,08 dólares y 1 dólar equivale a 66 pesos.
            b. El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.
            c. Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los
            distintos tipos de datos.
            d. Colocar dentro del Main el código necesario para probar todos los métodos.
            e. Los constructores estáticos le darán una cotización respecto del dólar por defecto a las
            clases.
            f. Los comparadores == compararan cantidades.
            g. Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido.
            Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego
            sumarlos.
            h. Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso.*/
            Dolar d1 = new Dolar(20);
            Dolar d2 = new Dolar(10);

            Euro e1 = new Euro(20);
            Euro e2 = new Euro(10);

            Pesos p1 = new Pesos(66);
            Pesos p2 = new Pesos(100);
            Console.WriteLine(d1.GetCantidad());
            Console.WriteLine($"Dolar 1: {d1.GetCantidad()}");
            Console.WriteLine($"Dolar 2: {d1.GetCantidad()}");

            Console.WriteLine($"Dolar 1 + 2: {(d1+d2).GetCantidad()}");

            Console.WriteLine($"Dolar 1 + Euro 1: {(d1 + e1).GetCantidad()}");
            Dolar aux = d1 + p1;
            Console.WriteLine($"Dolar 1 + Pesos 1: {aux.GetCantidad()}");
            Euro aux2 = e1 + d1;
            Console.WriteLine($"Euro 1 + Dolar 1: {aux2.GetCantidad()}");
            Console.ReadKey();
        }
    }
}
