using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace Datos
{
    public abstract class notasDL
    {
        public static int NotaCreditoCabeceraIngresar(notacreditocabecera registros)
        {
            {
                return conexion.executeScalar("fn_notacreditoc_ingresar",
                CommandType.StoredProcedure,
                //new parametro("in_p_inidnotacreditoc", registros.p_inidnotacreditoc ),
                new parametro("in_chcorrelativo", registros.chcorrelativo),
                new parametro("in_chfechanota", registros.chfechanota),
                new parametro("in_p_inidpedido", registros.p_inidpedido),
                new parametro("in_p_inidcliente", registros.p_inidcliente),
                new parametro("in_p_iniddocreferencia", registros.p_iniddocreferencia),
                new parametro("in_chfechareferencia", registros.chfechareferencia),
                new parametro("in_chobservacion", registros.chobservacion),
                new parametro("in_chtiponotacredito", registros.chtiponotacredito),
                new parametro("in_p_inidusuarioinsert", registros.p_inidusuarioinsert),
                new parametro("in_p_inidusuariodelete", registros.p_inidusuariodelete),
                new parametro("in_estado", registros.estado)
                );
            }
        }
        public static int NotaCreditoDetalleIngresar(notacreditodetalle registros)
        {
            {
                return conexion.executeScalar("fn_notacreditod_ingresar",
                CommandType.StoredProcedure,
//                   new parametro("in_p_inidnotacreditod", registros.p_inidnotacreditod ),
                new parametro("in_p_inidnotacreditoc", registros.p_inidnotacreditoc),
                new parametro("in_initem", registros.initem),
                new parametro("in_p_inidproducto", registros.p_inidproducto),
                new parametro("in_p_inidserie", registros.p_inidserie),
                new parametro("in_nucantidad", registros.nucantidad),
                new parametro("in_nuprecio", registros.nuprecio),
                new parametro("in_nudesc1", registros.nudesc1),
                new parametro("in_nudesc2", registros.nudesc2),
                new parametro("in_nuventa", registros.nuventa),
                new parametro("in_nuimporte", registros.nuimporte),
                new parametro("in_nutotdesc", registros.nutotdesc)                
                );
            }
        }
        public static int NotaDebitoIngresar(notadebito registros)
        {
            {
                return conexion.executeScalar("fn_notadebito_ingresar",
                CommandType.StoredProcedure,
                //this.p_inidnotadebito = 0;
                
                new parametro("in_chcorrelativo", registros.chcorrelativo),
                new parametro("in_chfecha", registros.chfecha),
                new parametro("in_p_inidcliente", registros.p_inidcliente),
                new parametro("in_p_iniddocreferencia", registros.p_iniddocreferencia),
                new parametro("in_chfechareferencia", registros.chfechareferencia),
                new parametro("in_p_inidsituacionnota", registros.p_inidsituacionnota),
                new parametro("in_chobservacion", registros.chobservacion),
                new parametro("in_p_inidusuarioinsert", registros.p_inidusuarioinsert),
                new parametro("in_p_inidusuariodelete", registros.p_inidusuariodelete ),
                new parametro("in_estado", registros.estado)
                );
            }
        }
    }
}
