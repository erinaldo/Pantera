using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class almacenDL
    {
        public static List<almacen> almacenListar(int idempresa)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_almacen_listar", CommandType.StoredProcedure, new parametro("in_idempresa", idempresa)))
            {
                List<almacen> listado = new List<almacen>();
                while (datareader.Read())
                {
                    almacen registro = new almacen();
                    registro.idalmacen = Convert.ToInt32(datareader["idalmacen"]);
                    registro.idempresa= Convert.ToInt32(datareader["idempresa"]);
                    registro.codigoalmacen = Convert.ToString(datareader["codigoalmacen"]).Trim();
                    registro.nombrealmacen = Convert.ToString(datareader["nombrealmacen"]);
                    registro.direccion = Convert.ToString(datareader["direccion"]);
                    registro.ubigeo = Convert.ToString(datareader["ubigeo"]);
                    registro.prefijoingreso = Convert.ToInt32(datareader["prefijoingreso"]);
                    registro.numeroingreso = Convert.ToInt32(datareader["numeroingreso"]);
                    registro.prefijosalida = Convert.ToInt32(datareader["prefijosalida"]);
                    registro.numerosalida = Convert.ToInt32(datareader["numerosalida"]);
                    registro.situacionalmacen = Convert.ToString(datareader["situacionalmacen"]);
                    registro.estadoalmacen = Convert.ToBoolean(datareader["estadoalmacen"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static almacensesion buscarPoridalmancen(int idalmacen)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_almacen_buscar_por_idalmacen", CommandType.StoredProcedure, new parametro("in_idalmacen", idalmacen)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }
        private static almacensesion convertirRegistro(IDataReader datareader)
        {
            almacensesion registro = new almacensesion();
            registro.idalmacen = Convert.ToInt32(datareader["idalmacen"]);
            registro.codigoalmacen = Convert.ToString(datareader["codigoalmacen"]);
            registro.nombrealmacen = Convert.ToString(datareader["nombrealmacen"]);
            registro.direccion = Convert.ToString(datareader["direccion"]);
            registro.ubigeo = Convert.ToString(datareader["ubigeo"]);
            return registro;
        }
        public static int obtenerNumero(int idalmacen,string idtipo)
        {
            return conexion.executeScalar("fn_empresaserie_obtener_presupuesto",
                    CommandType.StoredProcedure,
                    new parametro("in_idalmacen", idalmacen), new parametro("in_idtipo", idtipo));
        }

        public static List<almacen> buscarPorEmpresa(int idempresa)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_almacen_buscar_por_empresa", CommandType.StoredProcedure, new parametro("in_idempresa", idempresa)))
            {
                List<almacen> listado = new List<almacen>();
                while (datareader.Read())
                {
                    almacen registro = new almacen();

                    registro.idalmacen = Convert.ToInt32(datareader["idalmacen"]);
                    registro.nombrealmacen = Convert.ToString(datareader["nombrealmacen"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static int almacenInsertar(almacen almacen)
        {
            {
                return conexion.executeScalar("fn_almacen_insertar",
                CommandType.StoredProcedure,
                new parametro("in_idempresa", almacen.idalmacen),
                new parametro("in_idempresa", almacen.idempresa),
                new parametro("in_codigoalmacen", almacen.codigoalmacen),
                new parametro("in_nombrealmacen", almacen.nombrealmacen),
                new parametro("in_direccion", almacen.direccion),
                new parametro("in_ubigeo", almacen.ubigeo),
                new parametro("in_prefijoingreso", almacen.prefijoingreso),
                new parametro("in_numeroingreso", almacen.numeroingreso),
                new parametro("in_prefijosalida", almacen.prefijosalida),
                new parametro("in_numerosalida", almacen.numerosalida),
                new parametro("in_situacionalmacen", almacen.situacionalmacen),
                new parametro("in_estadoalmacen", almacen.estadoalmacen));
            }
        }
        public static int SaldoAlmacenAdiconar(int a1, int p2, decimal cantidad)
        {
            {
                return conexion.executeScalar("fn_saldoalmacen_agregar_stock",
                CommandType.StoredProcedure,
                new parametro("in_p_inidalmacen", a1),
                new parametro("in_p_inidproducto", p2),
                new parametro("in_cantidad", cantidad)
                );
            }
        }
        
        public static int almacenActualizar(almacen almacen)
        {
            {
                return conexion.executeScalar("fn_almacen_actualizar",
                CommandType.StoredProcedure,
                new parametro("in_idempresa", almacen.idalmacen),
                new parametro("in_idempresa", almacen.idempresa),
                new parametro("in_codigoalmacen", almacen.codigoalmacen),
                new parametro("in_nombrealmacen", almacen.nombrealmacen),
                new parametro("in_direccion", almacen.direccion),
                new parametro("in_ubigeo", almacen.ubigeo),
                new parametro("in_prefijoingreso", almacen.prefijoingreso),
                new parametro("in_numeroingreso", almacen.numeroingreso),
                new parametro("in_prefijosalida", almacen.prefijosalida),
                new parametro("in_numerosalida", almacen.numerosalida),
                new parametro("in_situacionalmacen", almacen.situacionalmacen),
                new parametro("in_estadoalmacen", almacen.estadoalmacen));
            }
        }
    }
}