using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public abstract class productoNE
    {
        public static List<producto> articuloListar()
        {
            return productoDL.productoListar();
        }
        public static int productoInsertar(producto productoObjeto)
        {
            return productoDL.productoInsertar(productoObjeto);
        }
    }
}
