using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class condicionpagoDL
    {
        public static List<condicionpago> ListaCondicionPago()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_condicion_pago_listar", CommandType.StoredProcedure))
            {
                List<condicionpago> listado = new List<condicionpago>();
                while (datareader.Read())
                {
                    condicionpago registro = new condicionpago();
                    registro.p_inidcondicionpago = Convert.ToInt32(datareader["p_inidcondicionpago"]);
                    registro.chnombrepago = Convert.ToString(datareader["chnombrepago"]).Trim();
                    registro.incantidaddias = Convert.ToInt32(datareader["incantidaddias"]);
                    registro.incantidaddiasaplasa = Convert.ToInt32(datareader["incantidaddiasaplasa"]);
                    registro.nucantidadporcentajedesc = Convert.ToInt32(datareader["nucantidadporcentajedesc"]);
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
