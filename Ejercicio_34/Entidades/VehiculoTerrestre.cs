using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoTerrestre
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

        public enum Colores
        {
            Rojo, Blanco, Azul, Gris, Negro
        }
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadRuedas;
            this.color = color;
        }
    }
}
