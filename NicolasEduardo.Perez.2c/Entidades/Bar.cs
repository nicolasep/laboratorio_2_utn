﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton;

        /// <summary>
        /// Constructor privado que inicializa las listas
        /// </summary>
        private Bar()
        {
            empleados = new List<Empleado>();
            gente = new List<Gente>();

        }
        /// <summary>
        /// Propiedad que devuelve la lista de empleados
        /// </summary>
        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }
        /// <summary>
        /// Propiedad que devuelve la lista de gente
        /// </summary>
        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }
        /// <summary>
        /// verifica si el bar no existe y lo crea y si exixste lo devuelve
        /// </summary>
        /// <returns>devuelve la instancia bar</returns>
        public static Bar GetBar()
        {
            if(singleton is null)
            {
                singleton = new Bar();
            }
            return singleton;
        }
        /// <summary>
        /// agrega un empleado al bar si este no esta cargado y cumple con la edad minima
        /// </summary>
        /// <param name="bar">instancia del bar</param>
        /// <param name="empleado">devuelve true si lo cargo, false si ya cargado o no cumple con la edad minima</param>
        /// <returns></returns>
        public static bool operator +(Bar bar, Empleado empleado)
        {
            foreach(Empleado l in bar.Empleados)
            {
                if(l == empleado)
                {
                    return false;
                }
            }
            if(empleado.Validar())
            {
                bar.empleados.Add(empleado);
                return true;
            }
            return false;
        }
        /// <summary>
        /// agrega gente al bar siempre que halla empleados para atender
        /// </summary>
        /// <param name="bar">instancia del bar</param>
        /// <param name="gente">gente a agregar</param>
        /// <returns>devuelve true si pudo agregar, de lo contratrio false</returns>
        public static bool operator +(Bar bar, Gente gente)
        {
            if (bar.Gente.Count < ((bar.Empleados.Count) * 10))
            {
                if(gente.Validar())
                {
                    bar.Gente.Add(gente);
                    return true;
                }
                
            }
            return false;
        }
        /// <summary>
        /// Elemina el tipo de persona pasado por parametro (si es empleado, elimina el ultimo empleado y si es gente, elimina la primera en la lista)
        /// </summary>
        /// <param name="bar">instancia del bar</param>
        /// <param name="persona">tipo de persona a eliminar "gente" o "empleado"</param>
        /// <returns>devuelve true si pudo eliminar, false si no pudo</returns>
        public static bool operator -(Bar bar, string persona)
        {
            bool retorno = false;
            if (persona == "empleado")
            {
                if (bar.Empleados.Count > ((bar.Gente.Count) / 10))
                {
                    bar.Empleados.RemoveAt(bar.Empleados.Count - 1);
                    retorno = true;
                }
            }
            else if (persona == "gente")
            {
                bar.Gente.RemoveAt(0);
                retorno = true;
            }
            
            return retorno;
        }
        /// <summary>
        /// Sobrecarga que retorna la lista de empleados y gente en el bar
        /// </summary>
        /// <returns>devuelve un string con los empleados y la gente</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Empleado l in this.Empleados)
            {
                sb.AppendLine((string)l);
            }
            foreach (Gente g in this.Gente)
            {
                sb.AppendLine(((string)g));
            }
            
            return sb.ToString();
        }

    }
}
