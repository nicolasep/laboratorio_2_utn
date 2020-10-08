using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        public enum Deportes
        {
            Basquet, Futbol, Handball, Rugby
        }
        private static Deportes deporte;
        private DirectorTecnico dt;
        List<Jugador> jugadores;
        private string nombre;

        static Equipo()
        {
            deporte = Deportes.Futbol;
        }
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string nombre, DirectorTecnico dt):this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }
        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte):this(nombre,dt)
        {
            Deporte = deporte;
        }
        public Deportes Deporte
        {
            set
            {
                deporte = value;
            }
        }

        public static implicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**{e.nombre} {Equipo.deporte}**");
            foreach(Jugador l in e.jugadores)
            {
                sb.AppendLine($"{l.ToString()}");
            }
            sb.AppendLine($"Dirigido por: {e.dt}");

            return sb.ToString();
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach(Jugador l in e.jugadores)
            {
                if(l == j)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e != j)
            {
                e.jugadores.Add(j);
            }
            return e;
        }
        public static Equipo operator -(Equipo e, Jugador j)
        {
            
            if(e==j)
            {
                /*for(int i=0; i<e.jugadores.Count;i++)
                {
                    if(e.jugadores[i] == j)
                    {
                        e.jugadores.Remove(j);
                    }
                }*/
                e.jugadores.Remove(j);
            }

            return e;

        }

    }
}
