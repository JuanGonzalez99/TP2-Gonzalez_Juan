﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModeloDeDominio
{
    class Cliente : PersonaJuridica
    {
        public List<string> CodCompartimientos { get; set; }
    }
}
