using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace CalculadoraDeFormas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Rectangulo(2,3));
            figuras.Add(new Cuadrado(5));
            figuras.Add(new Circulo(9));

            int i = 1;

            foreach(Figura f in figuras)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"----------FIGURA {string.Format("{00:00}", i)} ------------");
                stringBuilder.AppendLine($"Tipo: {f.GetType()}");
                stringBuilder.AppendLine(f.Dibujar());
                stringBuilder.AppendLine($"Area: {string.Format("{00:00}",f.CalcularSuperficie())}");
                stringBuilder.AppendLine($"Perimetro: {string.Format("{00:00}", f.CalcularPerimetro())}");
                stringBuilder.AppendLine("----------------------------------------------------------");
                Console.WriteLine(stringBuilder);
                i++;
            }
            Console.ReadKey();
        }
    }
}
