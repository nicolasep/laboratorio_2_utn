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

        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML;
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
        public float PorcentajeContenido
        {
            get
            {
                return ((this.contenidoML * this.capacidadML) / 100);
            }
        }

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;
            this.contenidoML = contenidoML;
        }
        protected string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Botella Marca: {this.marca} Capacidad: {this.capacidadML} Contenido: {this.contenidoML}");
            return sb.ToString();
        }
        public abstract int ServirMedida();
        
        public override string ToString()
        {
            return GenerarInforme();
        }
    }
}
