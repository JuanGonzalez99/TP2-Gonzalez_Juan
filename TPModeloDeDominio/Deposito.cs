using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModeloDeDominio
{
    class Deposito
    {
        public string Nombre { get; set; }
        public List<Pasillo> Pasillos { get; set; }        
    }
}
