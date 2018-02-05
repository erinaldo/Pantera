using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public class productoDL
    {
        public static int productoInsertar(producto productoObjeto)
        {
            return conexion.executeScalar("fn_articulo_insertar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidproducto", productoObjeto.p_inidproducto),
            new parametro("in_chcodigoproducto", productoObjeto.chcodigoproducto),
            new parametro("in_p_inidtipoproducto", productoObjeto.p_inidtipoproducto),
            new parametro("in_p_inidmarca", productoObjeto.p_inidmarca),
            new parametro("in_p_inunidadmedidaproducto", productoObjeto.p_inunidadmedidaproducto),
            new parametro("in_chfechacreacion", productoObjeto.chfechacreacion),
            new parametro("in_estado", productoObjeto.estado),
            new parametro("in_tmhoracreacion", productoObjeto.tmhoracreacion),
            new parametro("in_p_inidfamiliaproducto", productoObjeto.p_inidfamiliaproducto),
            new parametro("in_p_inidcalibre", productoObjeto.p_inidcalibre),
            new parametro("in_p_inidmodelo", productoObjeto.p_inidmodelo),
            new parametro("in_chcodigoproductoantes", productoObjeto.chcodigoproductoantes),
            new parametro("in_chdescripcionproducto", productoObjeto.chdescripcionproducto));

        }
    }
}
