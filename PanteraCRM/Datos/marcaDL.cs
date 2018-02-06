using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class marcaDL
    {
        public static List<marca> marcaListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_marca_listar", CommandType.StoredProcedure))
            {
                List<marca> listado = new List<marca>();
                while (datareader.Read())
                {
                    marca registro = new marca();
                    registro.idmarca = Convert.ToInt32(datareader["idmarca"]);
                    registro.codigomarca= Convert.ToString(datareader["codigomarca"]).Trim();
                    registro.nombremarca = Convert.ToString(datareader["nombremarca"]).Trim();
                    registro.estadomarca = Convert.ToBoolean(datareader["estadomarca"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static string obtenerNumero()
        {
            return conexion.executeScalarStr("fn_marca_obtener_numero",CommandType.StoredProcedure);
        }

        public static int marcaInsertar(marca marca)
        {
            {
                return conexion.executeScalar("fn_marca_insertar",
                CommandType.StoredProcedure,
                new parametro("in_codigomarca", marca.codigomarca),
                new parametro("in_nombremarca", marca.nombremarca),
                new parametro("in_estadomarca", marca.estadomarca));
            }
        }
        public static int marcaActualizar(marca marca)
        {
            {
                return conexion.executeScalar("fn_marca_actualizar",
                CommandType.StoredProcedure,
                new parametro("in_idmarca", marca.idmarca),
                new parametro("in_codigomarca", marca.codigomarca),
                new parametro("in_nombremarca", marca.nombremarca),
                new parametro("in_estadomarca", marca.estadomarca));
            }
        }
        private static marca convertirRegistro(IDataReader datareader)
        {
            marca registro = new marca();
            registro.idmarca = Convert.ToInt32(datareader["idmarca"]);
            registro.codigomarca = Convert.ToString(datareader["codigomarca"]);
            registro.nombremarca = Convert.ToString(datareader["nombremarca"]);
            registro.estadomarca = Convert.ToBoolean(datareader["estadomarca"]);
            return registro;
        }
    }
}
