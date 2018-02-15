using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class vechiculoDL
    {
        public static List<vehiculo> ListadoVehiculos(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_vehiculo_por_transportista", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                List<vehiculo> listado = new List<vehiculo>();
                while (datareader.Read())
                {
                    vehiculo registros = new vehiculo();
                    registros.p_inidvehiculo = Convert.ToInt32(datareader["p_inidvehiculo"]);
                    registros.chplacavehiculo = Convert.ToString(datareader["chplacavehiculo"]).Trim();
                    registros.chmarcavehiculo = Convert.ToString(datareader["chmarcavehiculo"]).Trim();
                    listado.Add(registros);
                }
                return listado;
            }
        }
    }
}
