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
        public static List<producto> productoListar()
        {
            return productoDL.productoListar();
        }
        public static int productoInsertar(producto productoObjeto)
        {
            return productoDL.productoInsertar(productoObjeto);
        }
        //BUSQUEDA DE PRODUCTO GENERAL
        public static List<productobuscado> productobuscadoListar(string parametro)
        {
            return productoDL.productobuscadoListar(parametro);
        }
        

    }
}
