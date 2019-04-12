using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPModeloDeDominio
{
    class Compartimiento
    {
        public TipoProducto TipoProducto { get; set; }
        public int Capacidad { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
