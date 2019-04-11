using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModeloDeDominio
{
    class PersonaJuridica : Persona
    {
        public string RazonSocial { get; set; }
        public string FormaJuridica { get; set; }
    }
}
