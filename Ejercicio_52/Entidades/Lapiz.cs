using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        /*Escribir reducirá la mina en 0.1 por cada carácter escrito.
        ii. Recargar lanzará NotImplementedException.
        iii. El color será gris (grey), sin posibilidad de morificarlo. El set lanzará
        NotImplementedException.
        iv. UnidadesDeEscritura retonará tamanioMina.*/


        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }
        ConsoleColor IAcciones.Color  
        { 
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura 
        { 
            get
            {
                return this.tamanioMina;
            }
            set => throw new NotImplementedException(); }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper escrituraWrapper = new EscrituraWrapper(texto,((IAcciones)this).Color );

            this.tamanioMina -= (texto.Length * 0.1f);
            
            return escrituraWrapper;
        }

        bool IAcciones.Recargar(int inidades)
        {
            throw new NotImplementedException();
        }
    }
}
