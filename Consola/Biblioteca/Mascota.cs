using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;//atributos
        private DateTime fechaNacimiento;
        private string especie;
        

        //constructor de instancia
        public Mascota(string nombre, DateTime fechaNacimiento, string especie)//constructor
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
        }
        public string MostrarDatos()
        {
            //una opcion de hacerlo
            //string datos = "Nombre de la mascota: " + nombre + " La fecha de nacimiento es: " + fechaNacimiento + " De especie: " + especie;

            //la mejor opcion para mostrar

            StringBuilder stringBuilder = new StringBuilder();
            // stringBuilder.AppendFormat("Nombre: {0}\n", this.nombre);
            //stringBuilder.AppendFormat("Fecha de nacimiento: {0}\n", this.fechaNacimiento.ToString("dd/MM/yyyy"));
            // stringBuilder.AppendFormat("Especie: {0}\n", this.especie);

            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            //stringBuilder.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToString("dd/MM/yyyy")} ");
            stringBuilder.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToLongDateString()}");
            stringBuilder.AppendLine($"Especie: {this.especie}");



            return stringBuilder.ToString(); 
        }
        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - this.fechaNacimiento.Year;

            if(this.fechaNacimiento.AddYears(edad)>fechaActual)
            {
                edad--;
            }

            return edad;
        }

        //getter
        public string GetNombre()
        {
            return this.nombre;
        }

        //setter
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

    }
}
