using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return 0;
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return 0;
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return 0;
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }
        private float CalcularGanancuias(Llamada.TipoLlamada tipoLlamada)
        {
            float total = 0.0f;

            foreach (Llamada aux in this.Llamadas)
            {
                
                switch (tipoLlamada)
                {
                    case Llamada.TipoLlamada.Local:
                        if(aux is Local)
                        {
                            total += ((Local)aux).CostoLlamada;
                        }
                    break;
                    case Llamada.TipoLlamada.Provincial:
                        if(aux is Provincial)
                        {
                            total += ((Provincial)aux).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (aux is Local)
                        {
                            total += ((Local)aux).CostoLlamada;
                        }
                        else if (aux is Provincial)
                        {
                            total += ((Provincial)aux).CostoLlamada;
                        }
                        break;
                }
            }
            return total;
        }
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Empresa: {this.razonSocial} Ganancias totales: {CalcularGanancuias(Llamada.TipoLlamada.Todas)}");
            stringBuilder.AppendLine($"Ganancias por llamadas Locales: {CalcularGanancuias(Llamada.TipoLlamada.Local)}");
            stringBuilder.AppendLine($"Ganancias por llamadas Provinciales: {CalcularGanancuias(Llamada.TipoLlamada.Provincial)}");
            foreach(Llamada l in listaDeLlamadas)
            {
                if(l is Local)
                {
                    stringBuilder.AppendLine($"Tipo de llamada: {Llamada.TipoLlamada.Local} Numero origen: {l.NroOrigen} Numero destino: {l.NroDestino} Duracion: {l.Duracion}");
                }
                else if(l is Provincial)
                {
                    stringBuilder.AppendLine($"Tipo de llamada: {Llamada.TipoLlamada.Provincial} Numero origen: {l.NroOrigen} Numero destino: {l.NroDestino} Duracion: {l.Duracion}");
                }
                
            }

            return stringBuilder.ToString();
        }
        public void OrdenarLlamadas()
        {
            
            Llamadas.Sort(Llamada.OrdenarPorDuracion);

        }
    }
}
