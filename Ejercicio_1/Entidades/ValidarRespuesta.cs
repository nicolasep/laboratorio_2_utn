﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool retorno;

            if(c == 'S' || c == 's')
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
