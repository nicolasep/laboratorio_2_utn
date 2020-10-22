using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T>
        where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach(T l in torneo.equipos)
            {
                if(l == equipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach(T l in this.equipos)
            {
                sb.AppendLine(l.ToString());
            }
            return sb.ToString();
        }
        private string CalcularPartido(T t1, T t2)
        {
            Random random = new Random();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{t1.ToString()}: {random.Next(0, 10)} - {t2.ToString()}: {random.Next(0,10)}");
            return sb.ToString();
        }
        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                Random random2 = new Random();
                
                return CalcularPartido(this.equipos.ElementAt(random.Next(0, this.equipos.Count - 1)), this.equipos.ElementAt(random2.Next(0, this.equipos.Count - 1)));
            }
        }
    }
}
