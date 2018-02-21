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
            using (IDataReader datareader = conexion.executeOperation("fn_ubigeo_busqueda_parametro", CommandType.StoredProcedure))
            {
                List<ubigeo> listado = new List<ubigeo>();
                while (datareader.Read())
                {
                    ubigeo registro = new ubigeo();
                    registro.cod_ubigeo = Convert.ToInt32(datareader["cod_ubigeo"]);
                    registro.desc_departamento = Convert.ToString(datareader["desc_departamento"]).Trim();
                    registro.desc_provincia = Convert.ToString(datareader["desc_provincia"]).Trim();
                    registro.desc_distrito = Convert.ToString(datareader["desc_distrito"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }

        public static List<ubigeo> BuscarPorParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_ubigeo_busqueda_parametro", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                List<ubigeo> listado = new List<ubigeo>();
                while (datareader.Read())
                {
                    ubigeo registro = new ubigeo();

                    registro.cod_ubigeo = Convert.ToInt32(datareader["p_inidubigeo"]);
                    registro.desc_departamento = Convert.ToString(datareader["chnombredeparta"]);
                    registro.desc_provincia = Convert.ToString(datareader["chnombreprivincia"]);
                    registro.desc_distrito = Convert.ToString(datareader["chnomdistrito"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static ubigeo buscarPorCodigo(int cod_ubigeo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_ubigeo_busqueda_codigo", 
            CommandType.StoredProcedure, new parametro("in_parametro", cod_ubigeo)))
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
            registro.cod_ubigeo = Convert.ToInt32(datareader["p_inidubigeo"]);
            registro.desc_departamento = Convert.ToString(datareader["chnombredeparta"]);
            registro.desc_provincia = Convert.ToString(datareader["chnombreprivincia"]);
            registro.desc_distrito = Convert.ToString(datareader["chnomdistrito"]);
            return registro;
        }
    }
}
