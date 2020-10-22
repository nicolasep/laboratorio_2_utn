using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        private Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }
        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }
        public static Cantina GetCantina(int espacios)
        {
            if(singleton is null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espaciosTotales = espacios;
            }
            return singleton;
        }
        public static bool operator +(Cantina c, Botella b)
        {
            if(c.espaciosTotales > 0)
            {
                c.botellas.Add(b);
                c.espaciosTotales++;
                return true;
            }
            return false;
        }
    }
}
