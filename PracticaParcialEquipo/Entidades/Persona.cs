﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        protected abstract string FichaTecnica();
        protected virtual string NombreCompleto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0} {1}", this.Nombre, this.Apellido));

            return sb.ToString();
        }


    }
}
