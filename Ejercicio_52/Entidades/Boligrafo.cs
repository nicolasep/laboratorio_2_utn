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
            this.UnidadesDeEscritura = unidades;
        }
        public ConsoleColor Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float UnidadesDeEscritura { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escrituraWrapper = new EscrituraWrapper(texto, this.colorTinta);
        }

        public bool Recargar(int inidades)
        {
            throw new NotImplementedException();
        }
    }
}
