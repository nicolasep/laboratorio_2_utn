using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadDedJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();

        }
        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDedJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
           

            if(e.jugadores.Count < e.cantidadDedJugadores)
            {
                foreach(Jugador l in e.jugadores)
                {
                    if(l==j)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }

            return false;
        }
    }
}
