using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;
        public enum TipoCompetencia
        {
            F1, MotoCross
        }
        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            foreach(VehiculoDeCarrera a in this.competidores)
            {
                sb.AppendLine($"{a.MostrarDatos()}");
            }
            return sb.ToString();
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera a1)
        {
            if(c.competidores.Count < c.cantidadCompetidores && c == a1)
            {
                foreach(VehiculoDeCarrera l in c.competidores)
                {
                    if(l == a1)
                    {
                        return false;
                    }
                }
                a1.EnCompetencia = true;
                a1.VueltasRestantes = c.cantidadVueltas;
                Random random1 = new Random();
                a1.CantidadCombustible = (short)random1.Next(15, 100);
                c.competidores.Add(a1);
                
                return true;
            }

            return false;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera a1)
        {
            if(c == a1)
            {
                c.competidores.Remove(a1);
                a1.EnCompetencia = false;
                a1.CantidadCombustible = 0;
                a1.VueltasRestantes = 0;
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera a1)
        {
            /*
            foreach(VehiculoDeCarrera a in c.competidores)
            {
                if(a == a1)
                {
                    return false;
                }
            }
            return true;
            */
            if(c.tipo == TipoCompetencia.F1 && a1 is AutoF1)
            {
                return true;
            }
            else if(c.tipo == TipoCompetencia.MotoCross && a1 is MotoCross)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a1)
        {
            return !(c == a1);
        }
    }
}
