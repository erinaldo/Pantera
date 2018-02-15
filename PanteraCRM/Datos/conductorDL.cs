using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class conductorDL
    {
        public static List<conductor> Listaconductores(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_conductor_por_transportista", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                List<conductor> listado = new List<conductor>();
                while (datareader.Read())
                {
                    conductor registros = new conductor();
                    registros.p_inidcoductor = Convert.ToInt32(datareader["p_inidcoductor"]);
                    registros.chnombreconductor = Convert.ToString(datareader["chnombreconductor"]).Trim();
                    registros.chbrevete = Convert.ToString(datareader["chbrevete"]).Trim();
                    registros.estado = Convert.ToBoolean(datareader["estado"]);
                    listado.Add(registros);
                }
                return listado;
            }
        }

    }
}
