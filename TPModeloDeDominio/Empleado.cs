﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModeloDeDominio
{
    class Empleado : PersonaFisica
    {
        public PuestoTrabajo Puesto { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
