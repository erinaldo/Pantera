using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace Datos
{
    public abstract class pedidoDL
    {
        public static int IngresoPedidoCabecera(pedidocabecera registros)
        {
            return conexion.executeScalar("",
            CommandType.StoredProcedure,
                    new parametro("in_p_inidpedidocabecera", registros.p_inidpedidocabecera),
                    new parametro("in_p_inidpuntoventa", registros.p_inidpuntoventa),
                    new parametro("in_chcodigopedido", registros.chcodigopedido),
                    new parametro("in_chfechapedido", registros.chfechapedido),
                    new parametro("in_tmhorapedido", registros.tmhorapedido),
                    new parametro("in_p_inidtipodocumento", registros.p_inidtipodocumento),
                    new parametro("in_p_inidcliente", registros.p_inidcliente),
                    new parametro("in_p_inmotivotransaccion", registros.p_inmotivotransaccion),
                    new parametro("in_p_inidcompromisopago", registros.p_inidcompromisopago),
                    new parametro("in_nuporcenatajedesc", registros.nuporcenatajedesc),
                    new parametro("in_chordencompra", registros.chordencompra),
                    new parametro("in_p_inidalmacen", registros.p_inidalmacen),
                    new parametro("in_p_inidtransportista", registros.p_inidtransportista),
                    new parametro("in_p_inidconductor", registros.p_inidconductor),
                    new parametro("in_chplacavehiculo", registros.chplacavehiculo),
                    new parametro("in_chfechainiciotransporte", registros.chfechainiciotransporte),
                    new parametro("in_chpuntopartida", registros.chpuntopartida),
                    new parametro("in_chpuntollegada", registros.chpuntollegada),
                    new parametro("in_nuventaafectamonnacional", registros.nuventaafectamonnacional),
                    new parametro("in_chmotivotransaccion", registros.chmotivotransaccion),
                    new parametro("in_p_inidmoneda", registros.p_inidmoneda),
                    new parametro("in_p_inidigv", registros.p_inidigv),
                    new parametro("in_boafectoigv", registros.boafectoigv),
                    new parametro("in_nuimportecambioventa", registros.nuimportecambioventa),
                    new parametro("in_p_inidvendedor", registros.p_inidvendedor),
                    new parametro("in_chtiempoentrega", registros.chtiempoentrega),
                    new parametro("in_nuventainafectamonnacional", registros.nuventainafectamonnacional),
                    new parametro("in_nutotaldescmonnacional", registros.nutotaldescmonnacional),
                    new parametro("in_nutotaligvmonnacional", registros.nutotaligvmonnacional),
                    new parametro("in_nutotalventamonnacional", registros.nutotalventamonnacional),
                    new parametro("in_nuventaafectamonextra", registros.nuventaafectamonextra),
                    new parametro("in_nuventainafectamonextra", registros.nuventainafectamonextra),
                    new parametro("in_nutotaldescmonextra", registros.nutotaldescmonextra),
                    new parametro("in_nutotaligvmonextra", registros.nutotaligvmonextra),
                    new parametro("in_nutotalventamonextra", registros.nutotalventamonextra),
                    new parametro("in_p_inidsituacionpedido", registros.p_inidsituacionpedido),
                    new parametro("in_chobservacion", registros.chobservacion),
                    new parametro("in_p_inidusuarioinsert", registros.p_inidusuarioinsert),
                    new parametro("in_p_inidusuariodelete", registros.p_inidusuariodelete),
                    new parametro("in_estado", registros.estado),
                    new parametro("in_p_inidvehiculo", registros.p_inidvehiculo )        
            
            );
        }
        public static int IngresoPedidoDetalle(List<pedidodetalle> listado)
        {   int valores = 0;
            int contador = 0;
            foreach(pedidodetalle registros in listado){
                valores = conexion.executeScalar("",
                    CommandType.StoredProcedure,
                    new parametro("in_p_inidpedidodetalle", registros.p_inidpedidodetalle),
                    new parametro("in_p_inidpedidocabecera", registros.p_inidpedidocabecera),
                    new parametro("in_chitem", registros.chitem),
                    new parametro("in_p_inidproducto", registros.p_inidproducto),
                    //new parametro("in_chcodigoproducto", registros.chcodigoproducto),
                    new parametro("in_nucantidad", registros.nucantidad),
                    //new parametro("in_nustock", registros.nustock),
                    //new parametro("in_chnombrecompuesto", registros.chnombrecompuesto),
                    new parametro("in_nuprecioproducto", registros.nuprecioproducto),
                    new parametro("in_nuporcentajedesc1", registros.nuporcentajedesc1),
                    new parametro("in_nuporcentajedesc2", registros.nuporcentajedesc2),
                    new parametro("in_nuprecioventa", registros.nuprecioventa),
                    new parametro("in_nuimportesubtotal", registros.nuimportesubtotal),
                    new parametro("in_estado", registros.estado),
                    new parametro("in_p_inidserie", registros.p_inidserie)
                    //new parametro("in_chserie", registros.chserie)
              );
                contador++;
            }
            return valores;
        }
    }
}
