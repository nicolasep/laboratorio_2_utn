using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua: Botella
    {
        /*a. MEDIDA será una constante con el valor 400.
        b. ServirMedida gastará unidades de contenido con la siguiente lógica:
        i. Si la constante MEDIDA es menor o igual al contenido, gastará MEDIDA.
        ii. Si MEDIDA es mayor al contenido, tomará contenido.
        c. Generar una sobrecarga que reciba una cantidad a gastar que pueda ser diferente de MEDIDA.
        No repetir código.
        d. GenerarInforme utilizará StringBuilder para retornar todos los datos de la botella de agua.*/
        private const int MEDIDA  = 400;

        public Agua(int capacidadML, string marca, int contenidoML):base(marca,capacidadML, contenidoML)
        {

        }
        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Botella de agua");
            sb.AppendLine(base.GenerarInforme());

            return sb.ToString();
        }
        public override int ServirMedida()
        {
            if(MEDIDA <= this.contenidoML)
            {
                this.contenidoML -= MEDIDA;
            }
            else
            {
                this.contenidoML -= this.contenidoML;
            }
            return this.contenidoML;
        }
        public int ServirMedida(int medida)
        {
            if(medida == MEDIDA || medida > this.contenidoML)
            {
                ServirMedida();
            }
            else
            {
                this.contenidoML -= medida;
            }

            return this.contenidoML;
        }


    }
}
