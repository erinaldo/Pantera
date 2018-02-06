using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class ubigeoDL
    {
        public static List<ubigeo> ubigeoListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_ubigeo_listar", CommandType.StoredProcedure))
            {
                List<ubigeo> listado = new List<ubigeo>();
                while (datareader.Read())
                {
                    ubigeo registro = new ubigeo();
                    registro.cod_ubigeo = Convert.ToString(datareader["cod_ubigeo"]);
                    registro.desc_departamento = Convert.ToString(datareader["desc_departamento"]).Trim();
                    registro.desc_provincia = Convert.ToString(datareader["desc_provincia"]).Trim();
                    registro.desc_distrito = Convert.ToString(datareader["desc_distrito"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }

        public static List<ubigeo> buscarPorDistrito(string desc_distrito)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_ubigeo_busca_por_distrito", CommandType.StoredProcedure, new parametro("in_desc_distrito", desc_distrito)))
            {
                List<ubigeo> listado = new List<ubigeo>();
                while (datareader.Read())
                {
                    ubigeo registro = new ubigeo();

                    registro.cod_ubigeo = Convert.ToString(datareader["cod_ubigeo"]);
                    registro.desc_departamento = Convert.ToString(datareader["desc_departamento"]);
                    registro.desc_provincia = Convert.ToString(datareader["desc_provincia"]);
                    registro.desc_distrito = Convert.ToString(datareader["desc_distrito"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }

        public static ubigeo buscarPorCodigo(string cod_ubigeo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_ubigeo_busca_por_codigo", 
            CommandType.StoredProcedure, new parametro("in_cod_ubigeo", cod_ubigeo)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }

        private static ubigeo convertirRegistro(IDataReader datareader)
        {
            ubigeo registro = new ubigeo();
            registro.cod_ubigeo = Convert.ToString(datareader["cod_ubigeo"]);
            registro.desc_departamento = Convert.ToString(datareader["desc_departamento"]);
            registro.desc_provincia = Convert.ToString(datareader["desc_provincia"]);
            registro.desc_distrito = Convert.ToString(datareader["desc_distrito"]);
            return registro;
        }
    }
}
