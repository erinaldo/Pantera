using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class pedidoNE
    {
        public static int IngresoPedidoCabecera(pedidocabecera registros)
        {
            return pedidoDL.IngresoPedidoCabecera(registros);
        }
        public static int BusquedaMaximaVendida(int cliente, string fecha)
        {
            return pedidoDL.BusquedaMaximaVendida(cliente, fecha);
        }
        public static int BusquedaMaximaVendida2(int cliente, string fecha)
        {
            return pedidoDL.BusquedaMaximaVendida2(cliente, fecha);
        }
        
        public static int IngresoPedidoDetalle(pedidodetalle listado)
        {
            return pedidoDL.IngresoPedidoDetalle(listado);
        }
        public static List<pedidocabecera> PedidoCabeceraListar()
        {
            return pedidoDL.PedidoCabeceraListar();
        }
        public static List<pedidocabecera> PedidoCabeceraBusquedaParametro(string parametro)
        {
            return pedidoDL.PedidoCabeceraBusquedaParametro(parametro);
        }
        public static pedidocabecera PedidoCabeceraBusquedaCodigo(int parametro)
        {
            return pedidoDL.PedidoCabeceraBusquedaCodigo(parametro);
        }
        public static List<pedidodetalle> PedidoDetalleBusquedaParametro(int parametro)
        {
            return pedidoDL.PedidoDetalleBusquedaParametro(parametro);
        }
        public static int CabeceraCambiarEstado(int parametro, int codigo)
        {
            return pedidoDL.CabeceraCambiarEstado(parametro,codigo);
        }
        /*INICIO :: INGRESO COMPROBANTES FACTURADOS*/
        public static int IngresoComprobantesGenerado(pedidoguicomp registros)
        {
            return pedidoDL.IngresoComprobantesGenerado(registros);
        }
        public static pedidoguicomp BuscarComprobantesFacturados(string registros,string parametro)
        {
            return pedidoDL.BuscarComprobantesFacturados(registros, parametro);
        }
        public static List<RegistroVenta> BuscarRegistroVentasCliente(int clientecodigo)
        {
            return pedidoDL.BuscarRegistroVentasCliente(clientecodigo);
        }
        /*FIN :: INGRESO COMPROBANTES FACTURADOS*/
        /*INICIO :: PARA REGISTRO DE VENTA*/
        public static int IngresoRegistroVenta(RegistroVenta registros)
        {
            return pedidoDL.IngresoRegistroVenta(registros);
        }
        /*FIN ::  PARA REGISTRO DE VENTA*/

    }
}
