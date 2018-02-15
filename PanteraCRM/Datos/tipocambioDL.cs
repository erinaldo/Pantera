using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class tipocambioDL
    {
        public static int TipocambioIngresar(tipocambio producto)
        {
            return conexion.executeScalar("fn_tipocambio_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_chfechacambio", producto.chfechacambio),
            new parametro("in_p_inidmoneda", producto.p_inidmoneda),
            new parametro("in_nucambiocompra", producto.nucambiocompra),
            new parametro("in_nucambioventa", producto.nucambioventa),
            new parametro("in_nucambiopon", producto.nucambiopon),
            new parametro("in_p_inidusuarioinsert", producto.p_inidusuarioinsert),
            new parametro("in_p_inidusuariodelete", producto.p_inidusuariodelete),
            new parametro("in_estado", producto.estado
            )
            );

        }

        public static List<tipocambio> busquedaValorTipoCambio(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_producto_busquedatipoCambio", CommandType.StoredProcedure,
                new parametro("in_parametro", parametro)))
            {
                List<tipocambio> listado = new List<tipocambio>();
                while (datareader.Read())
                {
                    tipocambio registro = new tipocambio();

                    registro.p_inidtipocambio = Convert.ToInt32(datareader["p_inidtipocambio"]);
                    registro.chfechacambio = Convert.ToString(datareader["chfechacambio"]).Trim();
                    registro.p_inidmoneda = Convert.ToInt32(datareader["p_inidmoneda"]);
                    registro.nucambiocompra = Convert.ToDecimal(datareader["nucambiocompra"]);
                    registro.nucambioventa = Convert.ToDecimal(datareader["nucambioventa"]);
                    registro.nucambiopon = Convert.ToDecimal(datareader["nucambiopon"]);
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
    }
}
