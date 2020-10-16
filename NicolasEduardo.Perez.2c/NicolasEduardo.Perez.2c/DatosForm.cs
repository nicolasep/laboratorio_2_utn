using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace NicolasEduardo.Perez._2c
{
    public partial class DatosForm : Form
    {
      
        public DatosForm()
        {
            InitializeComponent();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string edad = this.txtEdad.Text;
            string dni = this.txtDni.Text;
            if (!ValidarNombre(nombre) || !ValidarEdad(edad) || string.IsNullOrWhiteSpace(edad) || !ValidarDni(dni))
            {
                MessageBox.Show("NO SE REGISTRARON CORRECTAMENTE LOS DATOS", "ATENCION", MessageBoxButtons.OK);
                this.txtNombre.Clear();
                this.txtEdad.Clear();
                this.txtDni.Clear();
                this.txtNombre.Focus();
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        
        public string Nombre
        {
            
            get
            {
                if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
                {
                    return null;
                }
                return this.txtNombre.Text;
            }
        }
        public string Edad
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.txtEdad.Text))
                {
                    return null;
                }
                return this.txtEdad.Text;
            }
        }
        public string Dni
        {
            get
            {
                if(string.IsNullOrWhiteSpace(this.txtDni.Text))
                {
                    return null;
                }
                return this.txtDni.Text;
            }
        }

        private void FormIngresoEmpleados_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Valida que la cadena pasada por parametro sea una edad aceptable
        /// </summary>
        /// <param name="numero">string con la edad</param>
        /// <returns>devuelve true si es un numero valido o null y false si no esun numero valido</returns>
        private static bool ValidarEdad(string numero)
        {
            short aux;
            if (!string.IsNullOrWhiteSpace(numero) && (!short.TryParse(numero, out aux) || (aux < 10 || aux > 100)))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Valida que la cadena pasada por parametro sea valida como nombre
        /// </summary>
        /// <param name="nombre">nombre</param>
        /// <returns>devuelve false si contiene algo que no sean letras y si esta bien devuelve true</returns>
        private static bool ValidarNombre(string nombre)
        {
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                string aux = nombre;

                for (int i = 0; i < aux.Length; i++)
                {
                    if (((aux[i] > 'Z' || aux[i] < 'A') && (aux[i] > 'z' || aux[i] < 'a')) && aux[i] != ' ')
                    {
                        return false;

                    }
                }

            }
            return true;
        }
        /// <summary>
        /// Valida que la cadena pasada por parametro sea un dni valido
        /// </summary>
        /// <param name="dni">dni a analizar</param>
        /// <returns>devuelve true si tienne solo numeros y la cantidad es 8, false si no lo cumple</returns>
        private static bool ValidarDni(string dni)
        {
            if (!string.IsNullOrWhiteSpace(dni) && dni.Length != 8)
            {
                return false;
            }
            return true;
        }
    }
}
