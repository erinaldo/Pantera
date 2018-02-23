using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class exhibicionDL
    {
        public static List<productoserie> ListaProductosSerieExhibicion()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_producto_exhibicion_listar", CommandType.StoredProcedure))
            {
                List<productoserie> listado = new List<productoserie>();
                while (datareader.Read())
                {
                    productoserie registro = new productoserie();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.chdescripcion = Convert.ToString(datareader["chdescripcion"]).Trim();
                    registro.p_inidserie = Convert.ToInt32(datareader["p_inidserie"]);
                    registro.chcodigoserie = Convert.ToString(datareader["chcodigoserie"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.boexhibicion = Convert.ToBoolean(datareader["boexhibicion"]);
                    registro.chinforme = Convert.ToString(datareader["chinforme"]).Trim();
                    registro.chinformeobs = Convert.ToString(datareader["chinformeobs"]).Trim();
                    registro.chinformefecha = Convert.ToString(datareader["chinformefecha"]).Trim();
                    registro.chcodigo = Convert.ToString(datareader["chcodigo"]).Trim();                    
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<productoserie> ListaProductosSerieExhibicionParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_producto_exhibicion_listar_parametro", CommandType.StoredProcedure, new Datos.parametro("in_parametro",parametro)))
            {
                List<productoserie> listado = new List<productoserie>();
                while (datareader.Read())
                {
                    productoserie registro = new productoserie();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.chdescripcion = Convert.ToString(datareader["chdescripcion"]).Trim();
                    registro.p_inidserie = Convert.ToInt32(datareader["p_inidserie"]);
                    registro.chcodigoserie = Convert.ToString(datareader["chcodigoserie"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.boexhibicion = Convert.ToBoolean(datareader["boexhibicion"]);
                    registro.chinforme = Convert.ToString(datareader["chinforme"]).Trim();
                    registro.chinformeobs = Convert.ToString(datareader["chinformeobs"]).Trim();
                    registro.chinformefecha = Convert.ToString(datareader["chinformefecha"]).Trim();
                    registro.chcodigo = Convert.ToString(datareader["chcodigo"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        
        public static int ExibicionIngresar(int p_inidserie,string chinforme, string chinformeobs, string chinformefecha, bool boexhibicion)
        {
            {
                return conexion.executeScalar("fn_exhibicion_ingresar",
                CommandType.StoredProcedure,
                new parametro("in_p_inidserie", p_inidserie),
                new parametro("in_boexhibicion", boexhibicion),
                new parametro("in_chinforme", chinforme),
                new parametro("in_chinformeobs", chinformeobs),
                new parametro("in_chinformefecha", chinformefecha)
                );
            }
        }
    }
}
