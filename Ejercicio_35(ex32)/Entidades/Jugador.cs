using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {

        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float PomedioDeGoles
        {
            get
            {
                float promedio;
                if (this.TotalGoles == 0 || this.PartidosJugados == 0)
                {
                    return 0;
                }
                promedio = this.PartidosJugados / this.TotalGoles;

                return promedio;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

      
        public Jugador(int dni, string nombre) : this(dni,nombre,0,0)
        {

        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):base(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarDatos()} Goles Totales: {this.TotalGoles} Total de Partidos Jugados {this.PartidosJugados} Promedio de Goles {this.PomedioDeGoles}");

            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
