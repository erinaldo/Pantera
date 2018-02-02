using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class modeloDL
    {
        public static List<modelo> modeloListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_modelo_listar", CommandType.StoredProcedure))
            {
                List<modelo> listado = new List<modelo>();
                while (datareader.Read())
                {
                    modelo registro = new modelo();
                    registro.idmodelo = Convert.ToInt32(datareader["idmodelo"]);
                    registro.codigomodelo = Convert.ToString(datareader["codigomodelo"]).Trim();
                    registro.nombremodelo = Convert.ToString(datareader["nombremodelo"]).Trim();
                    registro.idmarca = Convert.ToInt32(datareader["idmarca"]);
                    registro.nombremarca = Convert.ToString(datareader["nombremarca"]).Trim();
                    registro.estadomodelo= Convert.ToBoolean(datareader["estadomodelo"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static string obtenerNumero()
        {
            return conexion.executeScalarStr("fn_modelo_obtener_numero", CommandType.StoredProcedure);
        }
        public static List<modelo> buscarPorMarca(int idmarca)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_modelo_buscar_por_marca", CommandType.StoredProcedure, new parametro("in_idmarca", idmarca)))
            {
                List<modelo> listado = new List<modelo>();
                while (datareader.Read())
                {
                    modelo registro = new modelo();

                    registro.idmodelo = Convert.ToInt32(datareader["idmodelo"]);
                    registro.nombremodelo = Convert.ToString(datareader["nombremodelo"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static int modeloInsertar(modelo modelo)
        {
            {
                return conexion.executeScalar("fn_modelo_insertar",
                CommandType.StoredProcedure,
                new parametro("in_codigomodelo", modelo.codigomodelo),
                new parametro("in_nombremodelo", modelo.nombremodelo),
                new parametro("in_idmarca", modelo.idmarca),
                new parametro("in_estadomodelo", modelo.estadomodelo));
            }
        }
        public static int modeloActualizar(modelo modelo)
        {
            {
                return conexion.executeScalar("fn_modelo_actualizar",
                CommandType.StoredProcedure,
                new parametro("in_idmodelo", modelo.idmodelo),
                new parametro("in_codigomodelo", modelo.codigomodelo),
                new parametro("in_nombremodelo", modelo.nombremodelo),
                new parametro("in_idmarca", modelo.idmarca),
                new parametro("in_estadomodelo", modelo.estadomodelo));
            }
        }
        //private static modelo convertirRegistro(IDataReader datareader)
        //{
        //    modelo registro = new modelo();
        //    registro.idmodelo = Convert.ToInt32(datareader["idmodelo"]);
        //    registro.codigomodelo = Convert.ToString(datareader["codigomodelo"]);
        //    registro.nombremodelo = Convert.ToString(datareader["nombremodelo"]);
        //    registro.idmarca = Convert.ToInt32(datareader["idmarca"]);
        //    registro.estadomodelo = Convert.ToBoolean(datareader["estadomodelo"]);
        //    return registro;
        //}
    }
}