using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        /*Escribir reducirá la tinta en 0.3 por cada carácter escrito.
        ii. Recargar incrementará tinta en tantas unidades como se agreguen.
        iii. UnidadesDeEscritura retonará tinta.*/

        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.Color = color;
            this.tinta = unidades;
        }
        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura 
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
            
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escrituraWrapper = new EscrituraWrapper(texto, this.colorTinta);
            this.tinta -= ((float)texto.Length*0.3f);
            return escrituraWrapper;
        }

        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Boligrafo color: {this.Color} nivel de tinta {this.tinta}");

            return sb.ToString();
        }
    }
}
