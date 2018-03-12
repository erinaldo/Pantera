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
        public static producto ProductoBusquedaCodigo(int parametro)
        {
            return productoDL.ProductoBusquedaCodigo(parametro);
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
        public static int stockminimoingresar(saldoalmacen productoObjeto)
        {
            return productoDL.stockminimoingresar(productoObjeto);
        }
        public static int productoInsertarSaldoalamcen(saldoalmacen productoObjeto)
        {
            return productoDL.productoInsertarSaldoalamcen(productoObjeto);
        }
        //BUSQUEDA DE PRODUCTO GENERAL
        public static List<productobuscado> productobuscadoListar(string parametro)
        {
            return productoDL.productobuscadoListar(parametro);
        }
        public static List<productobuscado> productobuscadoListarParametro(string parametro)
        {
            return productoDL.productobuscadoListar(parametro);
        }
        public static List<productobuscado> ListaProductosKardexBusquedaParametro(string parametro)
        {
            return productoDL.ListaProductosKardexBusquedaParametro(parametro);
        }
        public static List<productobuscado> ListaProductosKardex()
        {
            return productoDL.ListaProductosKardex();
        }

        public static List<productobuscado> productobuscadoListaPrecios(string parametro)
        {
            return productoDL.productobuscadoListaPrecio(parametro);
        }
        public static List<productobuscado> ListaPreciosLista()
        {
            return productoDL.ListaPreciosLista();
        }
        public static List<productobuscado> ListaStockminimoLista()
        {
            return productoDL.ListaStockminimoLista();
        }
        public static List<productobuscado> ListaPreciosListaParametro(string parametro)
        {
            return productoDL.ListaPreciosListaParametro(parametro);
        }
        public static List<productobuscado> ListaStockMinimoParametro(string parametro)
        {
            return productoDL.ListaStockMinimoParametro(parametro);
        }
        //INSERTAR PRECIO A PRODUCTO
        public static int productoPrecioInsertar(productobuscado productoObjeto)
        {
            return productoDL.productoPrecioInsertar(productoObjeto);
        }
        public static List<productoparaventa> ListaProductosVentaParametro(int parametro)
        {
            return productoDL.ListaProductosVentaParametro(parametro);
        }
        public static productoparaventa ProductosVentaParametro(string parametro)
        {
            return productoDL.ProductosVentaParametro(parametro);
        }

        
    }
}
