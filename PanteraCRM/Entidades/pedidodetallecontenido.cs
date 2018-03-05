using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class pedidodetallecontenido
    {
        public int orden;
        public pedidodetalle pedidodetalle;
        public productoparaventa productoparaventa;
        public serie serie;
        public bool estado;
        public pedidodetallecontenido()
        {
            this.orden = 0;
            this.pedidodetalle = null;
            this.productoparaventa = null;
            this.serie = null;
            this.estado = false;
        }
    }
}
