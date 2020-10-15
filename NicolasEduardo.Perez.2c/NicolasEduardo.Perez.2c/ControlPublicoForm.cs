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
    public partial class ControlPublicoForm : Form
    {
        private Bar bar = Bar.GetBar();


        private decimal valorNumericEmpleados;
        private decimal valorNumericGente;

        public ControlPublicoForm()
        {
            InitializeComponent();

            this.valorNumericEmpleados = 0;
            this.valorNumericGente = 0;
            EmpleadosDefault();
            ClientesDefault();
        }

        private void nudEmpleados_ValueChanged(object sender, EventArgs e)
        {
            Empleado aux;

            if (this.nudEmpleados.Value > this.valorNumericEmpleados)
            {
                DatosForm datos = new DatosForm();
                DialogResult resultado = datos.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    if (!(datos.Nombre is null) && !(datos.Edad is null))
                    {
                        if (!(datos.Dni is null))
                        {
                            aux = new Empleado(datos.Nombre, Convert.ToInt16(datos.Edad), Convert.ToInt32(datos.Dni));
                        }
                        else
                        {
                            aux = new Empleado(datos.Nombre, Convert.ToInt16(datos.Edad));
                        }
                        if (!(bar + aux))
                        {
                            MessageBox.Show("EL EMPLEADO NO CUMPLE CON LOS REQUISITOS O YA SE ENCUENTRA EN LA LISTA", "LISTA EMPLEADOS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            this.nudEmpleados.Value = this.valorNumericEmpleados;
                            this.valorNumericEmpleados--;
                        }
                        else
                        {
                            MessageBox.Show("EMPLEADO AGREGADO CON EXITO!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("EL EMPLEADO NO SE CARGO");
                        this.nudEmpleados.Value = this.valorNumericEmpleados;
                        this.valorNumericEmpleados--;
                    }
                    this.valorNumericEmpleados++;
                }
                else
                {
                    this.nudEmpleados.Value = this.valorNumericEmpleados;
                }

            }
            else if (this.nudEmpleados.Value < this.valorNumericEmpleados)
            {
                if (this.bar - "empleado")
                {
                    MessageBox.Show("EMPLEADO ELIMINADO CON EXITO!!!", "LISTA EMPLEADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.valorNumericEmpleados--;
                }
                else
                {
                    MessageBox.Show("NO ES POSIBLE ELIMINAR EMPLEADOS, NO QUEDAN LOS SUFICIENTES PARA LA GENTE EN EL BAR!!!", "LISTA EMPLEADOS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.nudEmpleados.Value = this.valorNumericEmpleados;
                }

            }

        }

        private void nudGente_ValueChanged(object sender, EventArgs e)
        {
            Gente aux;
            if (this.nudGente.Value > this.valorNumericGente)
            {
                DatosForm datos = new DatosForm();
                DialogResult resultado = datos.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    if (!(datos.Edad is null))
                    {
                        aux = new Gente(Convert.ToInt16(datos.Edad));

                        if (!(bar + aux))
                        {
                            if (Convert.ToInt16(datos.Edad) < 18)
                            {
                                MessageBox.Show("LA PERSONA ES MENOR DE 18", "LISTA PERSONAS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            else
                            {
                                MessageBox.Show("FALTA PERSONAL", "LISTA PERSONAS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            this.nudGente.Value = this.valorNumericGente;
                            this.valorNumericGente--;
                        }
                        else
                        {
                            MessageBox.Show("PERSONA AGREGADA CON EXITO!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("LA PERSONA NO SE CARGO");
                        this.nudGente.Value = this.valorNumericGente;
                        this.valorNumericGente--;
                    }
                    this.valorNumericGente++;
                }
                else
                {
                    this.nudGente.Value = this.valorNumericGente;
                }

            }
            else if (this.nudGente.Value < this.valorNumericGente)
            {

                if (this.bar - "gente")
                {
                    MessageBox.Show("PERSONA ELIMINADA CON EXITO!!!", "LISTA PERSONAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.valorNumericGente--;
                }

            }
        }

        /// <summary>
        /// Carga una lista determinada de clientes solo en modo de prueba
        /// </summary>
        private void ClientesDefault()
        {
            Random random = new Random();
            short aleatorio;

            for (int i = 0; i < 20; i++)
            {
                aleatorio = (short)random.Next(18, 70);
                Gente aux = new Gente(aleatorio);
                bool res = bar + aux;
                if (res)
                {
                    this.valorNumericGente++;
                    this.nudGente.Value = this.valorNumericGente;
                }
            }


        }
        /// <summary>
        /// Carga un lista de empleados predeterminada, solo en modo de prueba
        /// </summary>
        private void EmpleadosDefault()
        {
            Random random = new Random();
            short aleatorio;
            string[] nombres = new string[] { "nicolas","alejandro","susana","cristian","matias"};
            for (int i = 0; i < nombres.Length; i++)
            {
                aleatorio = (short)random.Next(21, 50);
                Empleado aux = new Empleado(nombres[i], aleatorio);
                bool res = bar + aux;
                if(res)
                {
                    this.valorNumericEmpleados++;
                    this.nudEmpleados.Value = this.valorNumericEmpleados;
                }
            }

        }
        private void btnInforme_Click(object sender, EventArgs e)
        {
            FormInformes informes = new FormInformes(bar.ToString());
            informes.ShowDialog();

        }

        private void FormBar_Load(object sender, EventArgs e)
        {

        }
        
    }
}
