using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class tipodocumentoDL
    {
        public static List<tipodocumento> ListarTipoDocumentosVenta()
        {
            using(IDataReader datareader = conexion.executeOperation("fn_tipo_documento_listar_venta", CommandType.StoredProcedure))
            {
                List<tipodocumento> listado = new List<tipodocumento>();
                while (datareader.Read())
                {
                    tipodocumento registro = new tipodocumento();    
                    registro.p_inidtipodocumento = Convert.ToInt32(datareader["p_inidtipodocumento"]);
                    registro.chnombredocumento = Convert.ToString(datareader["chnombredocumento"]).Trim();
                    registro.chacrominodocumento = Convert.ToString(datareader["chacrominodocumento"]).Trim();
                    registro.chserieunica = Convert.ToString(datareader["chserieunica"]).Trim();
                    registro.boventa = Convert.ToBoolean(datareader["boventa"]);
                    registro.boconta = Convert.ToBoolean(datareader["boconta"]);
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    listado.Add(registro);
                }
                return listado;
            }

        }
        public static tipodocumento documentoVentaBusquedacodigo(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_tipo_documento_venta_busqueda_codigo", CommandType.StoredProcedure, new parametro("in_p_inidtipodocumento", parametro)))
            {
                tipodocumento registro = new tipodocumento();
                while (datareader.Read())
                {
                    registro.p_inidtipodocumento = Convert.ToInt32(datareader["p_inidtipodocumento"]);
                    registro.chnombredocumento = Convert.ToString(datareader["chnombredocumento"]).Trim();
                    registro.chacrominodocumento = Convert.ToString(datareader["chacrominodocumento"]).Trim();
                    registro.chserieunica = Convert.ToString(datareader["chserieunica"]).Trim();
                    registro.boventa = Convert.ToBoolean(datareader["boventa"]);
                    registro.boconta = Convert.ToBoolean(datareader["boconta"]);
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                }
                return registro;
            }

        }
        
    }
}
