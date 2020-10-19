using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : this(nombre, DateTime.Now)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : base(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarDatos()} Fecha de nacimiento: {this.fechaNacimiento}");

            return sb.ToString();
        }
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento;
        }
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }
}
