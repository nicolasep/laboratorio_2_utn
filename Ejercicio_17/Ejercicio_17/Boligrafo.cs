using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {

        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        public bool Pintar(short gasto,out string dibujo)
        {
            
            if((this.tinta - gasto) >0)
            {
                this.SetTinta(gasto);
                dibujo = " ";
                return true;
            }
            StringBuilder stringBuilder = new StringBuilder();
            char aste = '*';
            dibujo = stringBuilder.Append(aste,gasto);
            return false;
        }
        public void Recargar()
        {
            tinta = cantidadTintaMaxima;
        }
        private void SetTinta(short tinta)
        {
            if(tinta > 0 && ((this.tinta + tinta)<=Boligrafo.cantidadTintaMaxima))
            {
                this.tinta += tinta;
            }
            else if(tinta < 0 && (this.tinta-tinta)>=0)
            {
                this.tinta -= tinta;
            }
            
            
        }
    }
}
