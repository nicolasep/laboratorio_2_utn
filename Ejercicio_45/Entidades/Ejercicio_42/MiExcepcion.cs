﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string i, Exception innerExepcion) : base(i, innerExepcion)
        {

        }
    }
}
