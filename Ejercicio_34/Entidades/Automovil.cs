using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        /*34. Crear las clases Automovil, Moto y Camion.
a. Crear un enumerado Colores { Rojo, Blanco, Azul, Gris, Negro }
b. Camión tendrá los atributos cantidadRuedas : short, cantidadPuertas : short, color : Colores,
cantidadMarchas : short, pesoCarga : int.
c. Automovil: cantidadRuedas : short, cantidadPuertas : short, color : Colores,
cantidadMarchas : short, cantidadPasajeros : int.
d. Moto: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
e. Crearle a cada clase un constructor que reciba todos sus atributos.
f. Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores.
Luego generar una relación de herencia entre ellas, según corresponda.
g. VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos. Modificar las
clases que heredan de ésta para que lo reutilicen.*/
        
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            :base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

    }
}
