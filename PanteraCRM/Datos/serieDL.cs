using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
namespace Datos
{
    public abstract class serieDL
    {
        public static bool verificarExistencias(string parametro)
        {
            bool flat = false;
            int flat2 = 0;
            using (IDataReader datareader = conexion.executeOperation("fn_serie_validarexistencia",
                CommandType.StoredProcedure, new parametro("in_seriecodigo", parametro)))
            {
                
                while (datareader.Read())
                {
                   flat2 = Convert.ToInt32(datareader["out_existencia"]);
                }
            }
            if (flat2 > 0)
            {
                flat = true;
            }    


            
            return flat;
        }

        public static int seriesIngresar(serie serie)
        {
            return conexion.executeScalar("fn_serie_ingresar",
            CommandType.StoredProcedure,
              new parametro("in_chcodigoserie", serie.chcodigoserie),
            new parametro("in_estado", serie.estado),
            new parametro("in_p_inidproducto", serie.p_inidproducto),
            new parametro("in_chadicional", serie.chadicional),
            new parametro("in_chfecha", serie.chfecha),
            new parametro("in_p_inidusuarioinsert", serie.p_inidusuarioinsert),
            new parametro("in_p_inidusuariodelete", serie.p_inidusuariodelete),
            new parametro("in_p_inidpedido", serie.p_inidpedidod),

            new parametro("in_boexhibicion", serie.boexhibicion),
            new parametro("in_chinforme", serie.chinforme),
            new parametro("in_chinformefecha", serie.chinformefecha),
            new parametro("in_chinformeobs", serie.chinformeobs),

            new parametro("in_p_inidmovimientod", serie.p_inidmovimientod)

            );

        }
        public static int SeriesFalsear(int parametro)
        {
            return conexion.executeScalar("fn_serie_detalle_falsear", CommandType.StoredProcedure,   new parametro("in_p_inidmovimientod", parametro));

        }
        public static int SeriesFalsearCodigo(int parametro)
        {
            return conexion.executeScalar("fn_serie_detalle_falsear_codigo", CommandType.StoredProcedure, new parametro("in_p_inidvaledetalle", parametro));

        }
        public static int CabeceraAnular(int parametro)
        {
            return conexion.executeScalar("fn_movimiento_cabecera_anular", CommandType.StoredProcedure, new parametro("in_p_inidpedidocabecera", parametro));

        }
        

        public static List<seriebuscada> serieListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_series_litar", CommandType.StoredProcedure))
            {
                List<seriebuscada> listado = new List<seriebuscada>();
                while (datareader.Read())
                {
                    seriebuscada registro = new seriebuscada();
                    registro.p_inidserie = Convert.ToInt32(datareader["p_inidserie"]);
                    registro.chserie = Convert.ToString(datareader["chserie"]).Trim();
                    registro.chnombreproductocompuesto = Convert.ToString(datareader["chnombreproductocompuesto"]).Trim();
                    registro.chobservacion = Convert.ToString(datareader["chobservacion"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        
            public static serie SerieBusquedaCodigo(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_series_busqueda_codigo", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                serie registro = new serie();
                while (datareader.Read())
                {
                    registro.p_inidserie = Convert.ToInt32(datareader["p_inidserie"]);
                    registro.chcodigoserie = Convert.ToString(datareader["chcodigoserie"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chadicional = Convert.ToString(datareader["chadicional"]).Trim();
                    registro.chfecha = Convert.ToString(datareader["chfecha"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.p_inidmovimientod = Convert.ToInt32(datareader["p_inidmovimientod"]);
                    registro.p_inidpedidod = Convert.ToInt32(datareader["p_inidpedido"]);

                    registro.boexhibicion = Convert.ToBoolean(datareader["boexhibicion"]);
                    registro.chinforme = Convert.ToString(datareader["chinforme"]).Trim();
                    registro.chinformeobs = Convert.ToString(datareader["chinformeobs"]).Trim();
                    registro.chinformefecha = Convert.ToString(datareader["chinformefecha"]).Trim();
                }
                return registro;
            }
        }
        public static List<seriebuscada> serieBuscar(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_series_busqueda", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                List<seriebuscada> listado = new List<seriebuscada>();
                while (datareader.Read())
                {
                    seriebuscada registro = new seriebuscada();
                    registro.p_inidserie = Convert.ToInt32(datareader["p_inidserie"]);
                    registro.chserie = Convert.ToString(datareader["chserie"]).Trim();
                    registro.chnombreproductocompuesto = Convert.ToString(datareader["chnombreproductocompuesto"]).Trim();
                    registro.chobservacion = Convert.ToString(datareader["chobservacion"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<serie> SerieBusquedaMovimiento(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_series_busqueda_movimiento", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                List<serie> listado = new List<serie>();
                while (datareader.Read())
                {
                    serie registro = new serie();
                    registro.p_inidserie = Convert.ToInt32(datareader["p_inidserie"]);
                    registro.chcodigoserie = Convert.ToString(datareader["chcodigoserie"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chadicional = Convert.ToString(datareader["chadicional"]).Trim();
                    registro.chfecha = Convert.ToString(datareader["chfecha"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.p_inidmovimientod = Convert.ToInt32(datareader["p_inidmovimientod"]);
                    registro.p_inidpedidod = Convert.ToInt32(datareader["p_inidpedido"]);

                    registro.boexhibicion = Convert.ToBoolean(datareader["boexhibicion"]);
                    registro.chinforme = Convert.ToString(datareader["chinforme"]).Trim();
                    registro.chinformeobs = Convert.ToString(datareader["chinformeobs"]).Trim();
                    registro.chinformefecha = Convert.ToString(datareader["chinformefecha"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }


        
        
    }
}
