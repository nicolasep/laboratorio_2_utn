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
    public partial class FormIngresoEmpleados : Form
    {
        private List<Empleado> aux;
        public FormIngresoEmpleados(List<Empleado> list)
        {
            InitializeComponent();
            this.aux = list;
        }

        private void btnargar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string dni = txtDni.Text;


            if (string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(edad) && string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Alguno de los datos no fue ingresado", "ATENCION", MessageBoxButtons.OK);
               
            }
            else
            {

                this.aux.Add(new Empleado(nombre, Convert.ToInt16(edad), Convert.ToInt32(dni)));
                
                DialogResult  = DialogResult.OK;
                this.Close();
            }

        }
    }
}
