using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModeloDeDominio
{
    class Producto : TipoProducto
    {
        public string Marca { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
