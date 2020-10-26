using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada 
    {
        /*Llamada:
        a. La clase Llamada ahora será abstracta. Tendrá definida la propiedad de sólo lectura
        CostoLlamada que también será abstracta.
        b. Mostrar deberá ser declarado como virtual, protegido y retornará un string que contendrá
        los atributos propios de la clase Llamada
        c. El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
        (utilizar método Equals, sobrescrito en las clases derivadas) y los números de destino y
        origen son iguales en ambas llamadas.
        */
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada { Local, Provincial, Todas };

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {

            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        protected virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Numero de origen: {this.NroOrigen} Numero Destino: {this.nroDestino} Duracion: {this.Duracion}");
            return stringBuilder.ToString();
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino;
        }
        public abstract float CostoLlamada
        {
            get;
            
        }
        
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if(llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            else if(llamada1.Duracion < llamada2.Duracion)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
        
    }
}
