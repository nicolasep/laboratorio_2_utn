using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {

        private int dni;

        /// <summary>
        /// Constructor de empleado que recibe nombre y edad. inicializa el campo dni con -1
        /// </summary>
        /// <param name="nombre">nombre del empleados</param>
        /// <param name="edad">edad del empleado</param>
        public Empleado(string nombre, short edad) : this(nombre, edad,-1)
        {
            
        }
        /// <summary>
        /// Constructor de un empleado con todos sus datos
        /// </summary>
        /// <param name="nombre">nombre del empleado</param>
        /// <param name="edad">edad del emplado</param>
        /// <param name="dni">dni del empleado</param>
        public Empleado(string nombre, short edad, int dni) : base(nombre,edad)
        {
            this.Dni = dni;
        }
        /// <summary>
        /// propiedad que asigan el dni al atributo dni
        /// </summary>
        private int Dni
        {
            set
            {
                this.dni = value;
            }
        }
        /// <summary>
        /// sobrecarga que Imprime los datos de un empleado
        /// </summary>
        /// <returns>devuelve un string con los datos</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"EMPLEADO {base.Mostrar()}");
            if(this.dni != -1)
            {
                sb.Append($" DNI: {this.dni}");
            }
            
            return sb.ToString();
        }
        /// <summary>
        /// Valida que el empleado tenga 21 años o mas y que su nombre tenga mas de 3 letras
        /// </summary>
        /// <returns>devuelve true si su edad es mayor o igual a 21 y si su nombre tiene al menos 3 letras, de lo contrario retorna false</returns>
        public override bool Validar()
        {
            if (this.Edad >= 21 && this.Nombre.Length > 2)
            {
                return true;
            }
            return false;
        } 
        /// <summary>
        /// Sobrecarga que compara un empleado con otro por su edad y nombre
        /// </summary>
        /// <param name="e1">primer empleado</param>
        /// <param name="e2">segundo empleado</param>
        /// <returns>devuelve true sus nombres y edades son iguales, de contrario devuelve false </returns>
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return (e1.Nombre == e2.Nombre && e1.Edad == e2.Edad);
        }
        /// <summary>
        /// Sobrecarga que compara un empleado con otro y devuelve si sus nombres y edades son distintos 
        /// </summary>
        /// <param name="e1">primer empleado</param>
        /// <param name="e2">segundo empleado</param>
        /// <returns>devuelve true si los nombres y/o edades son distintas, falte si son iguales</returns>
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
        
    }
}
