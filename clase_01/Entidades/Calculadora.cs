using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static float Calcular(float numero1, float numero2,char operacion)
        {
            float resultado = 0;
            switch(operacion)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if(Validar(numero2))
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        resultado = -1;
                    }
                    break;
            }

            return resultado;
        }
        static bool Validar(float numero)
        {
            bool respuesta = false;
            if(numero > 0)
            {
                respuesta = true;
            }

            return respuesta;
        }

    }
}
