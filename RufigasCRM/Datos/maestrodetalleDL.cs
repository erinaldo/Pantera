using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class maestrodetalleDL
    {
        public static List<maestrodetalle> buscarPorCodigoMaestro(string codigomaestro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_maestrodetalle_buscar_por_codigomaestro", CommandType.StoredProcedure, new parametro("in_codigomaestro", codigomaestro)))
            {
                List<maestrodetalle> listado = new List<maestrodetalle>();
                while (datareader.Read())
                {
                    maestrodetalle registro = new maestrodetalle();
                    registro.idmaestrodetalle = Convert.ToInt32(datareader["idmaestrodetalle"]);
                    registro.idmaestro = Convert.ToInt32(datareader["idmaestro"]);
                    registro.codigoitem = Convert.ToString(datareader["codigoitem"]).Trim();
                    registro.nombreitem = Convert.ToString(datareader["nombreitem"]).Trim();
                    registro.libre = Convert.ToString(datareader["libre"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
    }
}
