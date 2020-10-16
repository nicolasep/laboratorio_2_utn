using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
       /// <summary>
       /// Contructor de instancia de Gente
       /// </summary>
       /// <param name="edad">edad de la persona</param>
        public Gente(short edad):base(null,edad) 
        {

        }
        /// <summary>
        /// Imprime los datos de un objeto Gente
        /// </summary>
        /// <returns>devuelve un string con sus datos</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"GENTE {base.Mostrar()}");
           
            return sb.ToString();
        }

        /// <summary>
        /// Valida que la persona sea mayor a 18 años
        /// </summary>
        /// <returns>devuelve true si es mayor, false si es menor</returns>
        public override bool Validar()
        {
            if (this.Edad >= 18)
            {
                return true;
            }
            return false;
        }
        
    }
}
