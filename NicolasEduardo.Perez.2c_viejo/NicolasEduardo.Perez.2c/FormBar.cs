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
    public partial class FormBar : Form
    {
        private Bar MiBar = Bar.GetBar();

        public FormBar()
        {
            InitializeComponent();

            

            

        }

        private void numEmpleados_ValueChanged(object sender, EventArgs e)
        {
            /*
            switch((int)numEmpleados.Value)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }*/

            //Form cargaEmpleados = new FormIngresoEmpleados(MiBar);
            int valor = (int)this.numEmpleados.Value;
            Form cargaEmpleados = new FormIngresoEmpleados(MiBar.Empleados);
            DialogResult result = cargaEmpleados.ShowDialog();
            if(DialogResult.OK == result)
            {
                MessageBox.Show("Empleado cargado con exito", "ATENCION", MessageBoxButtons.OK);
                MessageBox.Show(MiBar.ToString());
            }
            
            else
            {
                
                if(valor == 0)
                {
                    this.numEmpleados.Value = 0;
                }
                else
                {
                   // valor--;
                    //this.numEmpleados.Value = valor;
                    this.numEmpleados.Value=(valor-1);
                }
                
            }




        }

        private void numGenter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnInforme_Click(object sender, EventArgs e)
        {

            Form informes = new FormInformes();

            informes.ShowDialog();


        }

        private void FormBar_Load(object sender, EventArgs e)
        {

            /*
           

        Empleado e1 = new Empleado("Nicolas", 22);
        Empleado e2 = new Empleado("matias", 18);
        Empleado e3 = new Empleado("alejandro", 36);
        Empleado e4 = new Empleado("ernesto", 15);
        Empleado e5 = new Empleado("mariano", 25);

        Gente g1 = new Gente(15);
        Gente g2 = new Gente(20);
        Gente g3 = new Gente(25);
        Gente g4 = new Gente(21);
        Gente g5 = new Gente(36);
        Gente g6 = new Gente(19);
        Gente g7 = new Gente(17);*/


        }
    }
}
