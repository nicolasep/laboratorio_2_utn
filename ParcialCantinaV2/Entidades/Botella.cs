using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        public enum Tipo
        {
            Vidrio, Plastico
        }
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            if(capacidadML<contenidoML)
            {
                this.contenidoML = capacidadML;
            }
            else
            {
                this.contenidoML = contenidoML;
            }
            this.capacidadML = capacidadML;
            this.marca = marca;

        }

        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }
        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }
        public float PorcentejeContenido
        {
            get
            {
                return (this.contenidoML *this.capacidadML)/ 100;
            }
        }
        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.marca} Capacidad:{this.capacidadML} Contenido:{this.contenidoML}");
            return sb.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return GenerarInforme();
        }
    }
}
