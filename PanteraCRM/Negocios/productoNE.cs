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
        public static List<producto> productoListarBusqueda(string parametro)
        {
            return productoDL.productoListarBusqueda(parametro);
        }
        //ACTUALIZAR PRODUCTO
        public static int ProductoActualizar(producto productoObjeto)
        {
            return productoDL.ProductoActualizar(productoObjeto);
        }
        //INGRESO DE PRODUCTOS
        public static int productoInsertar(producto productoObjeto)
        {
            return productoDL.productoInsertar(productoObjeto);
        }
        //BUSQUEDA DE PRODUCTO GENERAL
        public static List<productobuscado> productobuscadoListar(string parametro)
        {
            return productoDL.productobuscadoListar(parametro);
        }
        public static List<productobuscado> productobuscadoListaPrecios(string parametro)
        {
            return productoDL.productobuscadoListaPrecio(parametro);
        }
        public static List<productobuscado> ListaPreciosLista()
        {
            return productoDL.ListaPreciosLista();
        }
        public static List<productobuscado> ListaPreciosListaParametro(string parametro)
        {
            return productoDL.ListaPreciosListaParametro(parametro);
        }
        //INSERTAR PRECIO A PRODUCTO
        public static int productoPrecioInsertar(productobuscado productoObjeto)
        {
            return productoDL.productoPrecioInsertar(productoObjeto);
        }
    }
}
