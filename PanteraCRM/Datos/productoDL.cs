using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class productoDL
    {
        public static List<producto> productoListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_producto_listar", CommandType.StoredProcedure))
            {
                List<producto> listado = new List<producto>();
                while (datareader.Read())
                {
                    producto registro = new producto();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.p_inidtipoproducto = Convert.ToInt32(datareader["p_inidtipoproducto"]);
                    registro.chtipoproducto = Convert.ToString(datareader["chtipoproducto"]).Trim();
                    registro.p_inidmarca = Convert.ToInt32(datareader["p_inidmarca"]);
                    registro.chmarca = Convert.ToString(datareader["chmarca"]).Trim();
                    registro.p_inidunidadmedidaproducto = Convert.ToInt32(datareader["p_inidunidadmedidaproducto"]);
                    registro.chunidadmedidaproducto = Convert.ToString(datareader["chunidadmedidaproducto"]).Trim();
                    registro.chfechacreacion = Convert.ToString(datareader["chfechacreacion"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]) ;
                    registro.p_inidfamiliaproducto = Convert.ToInt32(datareader["p_inidfamiliaproducto"]);
                    registro.chfamiliaproducto = Convert.ToString(datareader["chfamiliaproducto"]).Trim();
                    registro.p_inidcalibre = Convert.ToInt32(datareader["p_inidcalibre"]);
                    registro.chcalibre = Convert.ToString(datareader["chcalibre"]).Trim();
                    registro.p_inidmodelo = Convert.ToInt32(datareader["p_inidmodelo"]);
                    registro.chdmodelo = Convert.ToString(datareader["chdmodelo"]).Trim();
                    registro.chcodigoproductoantes = Convert.ToString(datareader["chcodigoproductoantes"]).Trim();
                    registro.chdescripcionproducto = Convert.ToString(datareader["chdescripcionproducto"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.chusuarioinsert = Convert.ToString(datareader["chusuarioinsert"]).Trim();
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.chusuariodelete = Convert.ToString(datareader["chusuariodelete"]).Trim();
                   
                    registro.p_inidsituacion = Convert.ToInt32(datareader["p_inidsituacion"]);
                    registro.chsituacion = Convert.ToString(datareader["chsituacion"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static int productoInsertar(producto productoObjeto)
        {
            return conexion.executeScalar("fn_articulo_insertar",
            CommandType.StoredProcedure,

            new parametro("in_p_inidproducto", productoObjeto.p_inidproducto),
            new parametro("in_chcodigoproducto", productoObjeto.chcodigoproducto),
            new parametro("in_p_inidtipoproducto", productoObjeto.p_inidtipoproducto),
            new parametro("in_chtipoproducto", productoObjeto.chtipoproducto),
            new parametro("in_p_inidmarca", productoObjeto.p_inidmarca),
            new parametro("in_chmarca", productoObjeto.chmarca),
            new parametro("in_p_inidunidadmedidaproducto", productoObjeto.p_inidunidadmedidaproducto),
            new parametro("in_chunidadmedidaproducto", productoObjeto.chunidadmedidaproducto),
            new parametro("in_chfechacreacion", productoObjeto.chfechacreacion),
            new parametro("in_estado", productoObjeto.estado),
            new parametro("in_p_inidfamiliaproducto", productoObjeto.p_inidfamiliaproducto),
            new parametro("in_chfamiliaproducto", productoObjeto.chfamiliaproducto),
            new parametro("in_p_inidcalibre", productoObjeto.p_inidcalibre),
            new parametro("in_chcalibre", productoObjeto.chcalibre),
            new parametro("in_p_inidmodelo", productoObjeto.p_inidmodelo),
            new parametro("in_chdmodelo", productoObjeto.chdmodelo),
            new parametro("in_chcodigoproductoantes", productoObjeto.chcodigoproductoantes),
            new parametro("in_chdescripcionproducto", productoObjeto.chdescripcionproducto),
            new parametro("in_p_inidusuarioinsert", productoObjeto.p_inidusuarioinsert),
            new parametro("in_chusuarioinsert", productoObjeto.chusuarioinsert),
            new parametro("in_p_inidusuariodelete", productoObjeto.p_inidusuariodelete),
            new parametro("in_chusuariodelete", productoObjeto.chusuariodelete),
            new parametro("in_nuprecio", productoObjeto.nuprecio),
            new parametro("in_p_inidsituacion", productoObjeto.p_inidsituacion),
            new parametro("in_chsituacion", productoObjeto.chsituacion));

        }
    }
}
