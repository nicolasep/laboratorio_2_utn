using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioDeGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            float promedio;
            if (this.totalGoles == 0 || this.partidosJugados == 0)
            {
                return 0;
            }
            promedio = this.partidosJugados / this.totalGoles;

            return promedio;
        }
        private Jugador()
        {
            this.promedioDeGoles = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre):this()
        {
            this.nombre = nombre;
            this.dni = dni;

        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} Dni: {this.dni} Goles Totales: {this.totalGoles} Total de Partidos Jugados {this.partidosJugados} Promedio de Goles {GetPromedioGoles()}");

            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
