using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Datos
{
    public abstract class generarCodigoDL
    {
        
        public static string ObtegerUltimocodigoPedido(int parametro)
        {
            return conexion.executeScalarStr("fn_pedido_correlativo",CommandType.StoredProcedure, new parametro("in_parametro", parametro));
        }

        public static int ObetenertipoCambio(string parametro)
        {
            return conexion.executeScalar("fn_buscar_fecha_tipocambio", CommandType.StoredProcedure, new parametro("in_parametro", parametro));
        }
        /* INICIO :: OBTENER CORRELATIVOS DE COMPROBANTES*/
        public static string ObtenercorrelativoFactura(int parametro)
        {
            return conexion.executeScalarStr("fn_correlativo_factura", CommandType.StoredProcedure, new parametro("in_parametro", parametro));
        }
        public static string ObtenerCorrelativoGuia(int parametro)
        {
            return conexion.executeScalarStr("fn_correlativo_guia", CommandType.StoredProcedure, new parametro("in_parametro", parametro));
        }
        public static string ObtenerCorrelativoBoleta(int parametro)
        {
            return conexion.executeScalarStr("fn_correlativo_boleta", CommandType.StoredProcedure, new parametro("in_parametro", parametro));
        }
        public static string ObtenerCorrelativoNotaCredito(int parametro)
        {
            return conexion.executeScalarStr("fn_correlativo_notacredito", CommandType.StoredProcedure, new parametro("in_parametro", parametro));
        }
        public static string ObtenerCorrelativoNotaDebito(int parametro)
        {
            return conexion.executeScalarStr("fn_correlativo_notadebito", CommandType.StoredProcedure, new parametro("in_parametro", parametro));
        }
        public static string ObtenerCorrelativoNotaVenta(int parametro)
        {
            return conexion.executeScalarStr("fn_correlativo_notaventa", CommandType.StoredProcedure, new parametro("in_parametro", parametro));
        }
        /* FIN :: OBTENER CORRELATIVOS DE COMPROBANTES*/


    }
}
