using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;
using Interfaces;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        /*j. Se reemplaza el método Mostrar por la sobrescritura del método ToString.
            k. AgregarLlamada es privado. Recibe una Llamada y la agrega a la lista de llamadas.
            l. El operador == retornará true si la Centralita contiene la Llamada en su lista genérica. Utilizar
            sobrecarga == de Llamada.
            m. El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la
            Centralita (utilizar la sobrecarga del operador == de Centralita).*/

        List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        private string rutaDeArchivo;
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada l in c.listaDeLlamadas)
            {
                if (l == llamada)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {

            if (c != nuevaLlamada)
            {

                c.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                throw new CentralitaException("La llamada ya se agrego", "Centralita", "operador +");
            }

            return c;
        }
        public float GananciasPorLocal
        {
            get
            {

                return this.CalcularGanancuias(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancuias(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancuias(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivo;
            }
            set
            {
                this.rutaDeArchivo = value;
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
            stringBuilder.AppendLine("-------------");
            foreach (Llamada l in listaDeLlamadas)
            {
                stringBuilder.AppendLine($"{l.ToString()}");
            }

            return stringBuilder.ToString();
        }
        public void OrdenarLlamadas()
        {
            
            Llamadas.Sort(Llamada.OrdenarPorDuracion);

        }

        
        public bool Guardar()
        {
            return true;
        }

        string IGuardar<string>.Leer()
        {
            throw new NotImplementedException();
        }
    }
}
