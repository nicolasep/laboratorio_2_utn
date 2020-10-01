using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo : Figura
    {
        protected double basee;
        protected double altura;
        public Rectangulo(double basee, double altura) : this(basee)
        {
            this.altura = altura;
        }
        protected Rectangulo(double lado)
        {
            this.basee = lado;
        }
        
        public override string Dibujar()
        {
            return "Dibujando Rectangulo";
        }
        public override double CalcularSuperficie()
        {
            
            return this.basee*this.altura;
        }
        public override double CalcularPerimetro()
        {
            
            return ((this.basee*2)+(this.altura*2));
        }
    }
}
