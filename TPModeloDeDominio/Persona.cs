using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModeloDeDominio
{
    class Persona
    {
        public string Localidad { get; set; }
        public string Domicilio { get; set; }
        public string CUI { get; set; }
        public Contacto Contacto { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
