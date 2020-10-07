using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;
        public enum TipoManada
        {
            Unica, Mixta
        }
        public TipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }
        static Grupo()
        {
            tipo = TipoManada.Unica;
        }
        private Grupo()
        {
            manada = new List<Mascota>();
        }
        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, TipoManada tipo):this(nombre)
        {
            Tipo = tipo;
        }
        
        public static bool operator ==(Grupo e, Mascota j)
        {
            foreach(Mascota l in e.manada)
            {
                if(l == j)
                {
                    return true;
                }
            }
            return false;

        }
        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }
        public static Grupo operator +(Grupo e, Mascota j)
        {
            foreach(Mascota l in e.manada)
            {
                if(l == j)
                {
                    return e;
                }
            }
            e.manada.Add(j);
            return e;
        }
        public static Grupo operator -(Grupo e, Mascota j)
        {
            for(int i= 0; i< e.manada.Count;i++)
            {
                if(e.manada[i] == j)
                {
                    e.manada.Remove(j);
                    break;
                }
            }
            return e;
        }
        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Grupo.tipo.ToString());
            sb.AppendLine("Integrantes:");
            foreach (Mascota l in e.manada)
            {
                if (l is Perro)
                {
                    sb.AppendLine(((Perro)l).ToString());
                }
                else if(l is Gato)
                {
                    sb.AppendLine(((Gato)l).ToString());
                }

            }
            return sb.ToString();
        }

    }
}
