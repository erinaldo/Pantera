using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class empresaDL
    {
        public static List<empresa> empresaListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_empresa_listar", CommandType.StoredProcedure))
            {
                List<empresa> listado = new List<empresa>();
                while (datareader.Read())
                {
                    empresa registro = new empresa();
                    registro.idempresa = Convert.ToInt32(datareader["idempresa"]);
                    registro.codigoempresa = Convert.ToString(datareader["codigoempresa"]).Trim();
                    registro.nombreempresa = Convert.ToString(datareader["nombreempresa"]).Trim();
                    registro.rucempresa = Convert.ToString(datareader["rucempresa"]).Trim();
                    registro.direccion = Convert.ToString(datareader["direccion"]).Trim();
                    registro.distrito = Convert.ToString(datareader["distrito"]).Trim();
                    registro.ubigeo = Convert.ToString(datareader["ubigeo"]).Trim();
                    registro.telefono = Convert.ToString(datareader["telefono"]).Trim();
                    registro.situacionempresa = Convert.ToString(datareader["situacionempresa"]).Trim();
                    registro.estadoempresa = Convert.ToBoolean(datareader["estadoempresa"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static empresasesion buscarPorCodigo(int idempresa)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_empresa_busca_por_codigo", CommandType.StoredProcedure, new parametro("in_idempresa", idempresa)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }
        private static empresasesion convertirRegistro(IDataReader datareader)
        {
            empresasesion registro = new empresasesion();
            registro.idempresa= Convert.ToInt32(datareader["idempresa"]);
            registro.codigoempresa = Convert.ToString(datareader["codigoempresa"]);
            registro.nombreempresa = Convert.ToString(datareader["nombreempresa"]);
            registro.rucempresa = Convert.ToString(datareader["rucempresa"]);
            registro.direccion = Convert.ToString(datareader["direccion"]);
            registro.distrito = Convert.ToString(datareader["distrito"]);
            registro.telefono = Convert.ToString(datareader["telefono"]);
            return registro;
        }
        public static int empresaInsertar(empresa empresa)
        {
            {
                return conexion.executeScalar("fn_empresa_insertar",
                CommandType.StoredProcedure,
                new parametro("in_codigoempresa", empresa.codigoempresa),
                new parametro("in_nombreempresa", empresa.nombreempresa),
                new parametro("in_rucempresa", empresa.rucempresa),
                new parametro("in_direccion", empresa.direccion),
                new parametro("in_telefono", empresa.telefono),
                new parametro("in_ubigeo", empresa.ubigeo),
                new parametro("in_situacionempresa", empresa.situacionempresa),
                new parametro("in_estadoempresa", empresa.estadoempresa));
            }
        }
        public static int empresaActualizar(empresa empresa)
        {
            {
                return conexion.executeScalar("fn_empresa_actualizar",
                CommandType.StoredProcedure,
                new parametro("in_idempresa", empresa.idempresa),
                new parametro("in_codigoempresa", empresa.codigoempresa),
                new parametro("in_nombreempresa", empresa.nombreempresa),
                new parametro("in_rucempresa", empresa.rucempresa),
                new parametro("in_direccion", empresa.direccion),
                new parametro("in_telefono", empresa.telefono),
                new parametro("in_ubigeo", empresa.ubigeo),
                new parametro("in_situacionempresa", empresa.situacionempresa),
                new parametro("in_estadoempresa", empresa.estadoempresa));
            }
        }

        public static int EmpresaIngresar(empresas registros)
        {
            {
                return conexion.executeScalar("fn_empresa_ingresar",
                CommandType.StoredProcedure,
                new parametro("in_chrazonsocial", registros.chrazonsocial),
                new parametro("in_chruc", registros.chruc),
                new parametro("in_chtelefono", registros.chtelefono),
                new parametro("in_chdirecfiscal", registros.chdirecfiscal),
                new parametro("in_chobservacion", registros.chobservacion),
                new parametro("in_estado", registros.estado),
                new parametro("in_chnombrecomercial", registros.chnombrecomercial),
                new parametro("in_p_inidubigeo", registros.p_inidubigeo)
                );
            }
        }







    }
}
