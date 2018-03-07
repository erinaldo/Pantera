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

    }
}
