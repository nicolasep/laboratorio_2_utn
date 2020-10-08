using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;

        public bool EsCapitan
        {
            get
            {
                return this.esCapitan;
            }
            set
            {
                this.esCapitan = value;
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public Jugador(string nombre, string apellido) : base(nombre,apellido)
        {
            this.EsCapitan = false;
            this.Numero = 0;
        }
        public Jugador(string nombre, string apellido, int numero, bool capitan):this(nombre,apellido)
        {
            this.EsCapitan = capitan;
            this.Numero = numero;
        }
        protected override string FichaTecnica()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format(base.NombreCompleto()));
            if (this.EsCapitan)
            {
                sb.Append(string.Format(", capitan del equipo"));
            }
            sb.Append(string.Format(" camiseta numero {0}", this.Numero));

            return sb.ToString();
        }
        public static explicit operator int(Jugador jugador)
        {
            return jugador.numero; 
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido && j1.Numero == j2.Numero);
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public override bool Equals(object obj)
        {
            return ((Jugador)obj == this);
        }
        public override string ToString()
        {
            return FichaTecnica();
        }
    }
}
