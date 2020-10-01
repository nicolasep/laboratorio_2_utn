using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado):base(lado)
        {

        }
        public override double CalcularSuperficie()
        {
            
            return this.basee * this.basee;
        }
        public override double CalcularPerimetro()
        {
            
            return this.basee*4;
        }
        public override string Dibujar()
        {
            return "Dibujando Cuadrado";
        }
        
    }
}
