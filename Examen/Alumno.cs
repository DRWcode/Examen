﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen

{
    abstract class Alumno
    {
        public string? Nombre { get; set; }
        public string? NumeroCuenta { get; set; }
        public string? Email { get; set; }

        
        public abstract void Imprimir();
    }
}

