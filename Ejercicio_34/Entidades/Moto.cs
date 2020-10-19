using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto :VehiculoTerrestre
    {
        /*Moto: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.*/
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            :base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
