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
            return conexion.executeScalar("fn_pedidocabecera_ingresar",
            CommandType.StoredProcedure,
                    //new parametro("in_p_inidpedidocabecera", registros.p_inidpedidocabecera),
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
                    new parametro("in_p_inidvehiculo", registros.p_inidvehiculo),
                    new parametro("in_p_inidtarjeta", registros.p_inidtarjeta),
                    new parametro("in_p_inidlicencia", registros.p_inidlicencia)
            );
        }
        public static int IngresoPedidoDetalle(pedidodetalle registros)
        {
            return conexion.executeScalar("fn_pedidodetalle_ingresar",
                    CommandType.StoredProcedure,
            new parametro("in_p_inidpedidocabecera", registros.p_inidpedidocabecera),
            new parametro("in_chitem", registros.chitem),
            new parametro("in_p_inidproducto", registros.p_inidproducto),
            new parametro("in_nucantidad", registros.nucantidad),
            new parametro("in_nuprecioproducto", registros.nuprecioproducto),
            new parametro("in_nuporcentajedesc1", registros.nuporcentajedesc1),
            new parametro("in_nuporcentajedesc2", registros.nuporcentajedesc2),
            new parametro("in_nuprecioventa", registros.nuprecioventa),
            new parametro("in_nuimportesubtotal", registros.nuimportesubtotal),
            new parametro("in_nuimportetotal", registros.nuimportetotal),
            new parametro("in_estado", registros.estado),
            new parametro("in_p_inidserie", registros.p_inidserie),
            new parametro("in_p_inidalmacen", registros.p_inidpedidodetalle)
              );
         
        }
        
        public static List<pedidocabecera> PedidoCabeceraBusquedaParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_pedidocabecera_listar_parametro", CommandType.StoredProcedure, new parametro ("in_parametro",parametro)))
            {
                List<pedidocabecera> listado = new List<pedidocabecera>();
                while (datareader.Read())
                {
                    pedidocabecera registro = new pedidocabecera();
                    registro.p_inidpedidocabecera = Convert.ToInt32(datareader["p_inidpedidocabecera"]);
                    registro.p_inidpuntoventa = Convert.ToInt32(datareader["p_inidpuntoventa"]);
                    registro.chcodigopedido = Convert.ToString(datareader["chcodigopedido"]).Trim();
                    registro.chfechapedido = Convert.ToString(datareader["chfechapedido"]).Trim();
                    registro.tmhorapedido = Convert.ToString(datareader["tmhorapedido"]).Trim();
                    registro.p_inidtipodocumento = Convert.ToInt32(datareader["p_inidtipodocumento"]);
                    registro.p_inidcliente = Convert.ToInt32(datareader["p_inidcliente"]);
                    registro.p_inmotivotransaccion = Convert.ToInt32(datareader["p_inmotivotransaccion"]);
                    registro.p_inidcompromisopago = Convert.ToInt32(datareader["p_inidcompromisopago"]);
                    registro.nuporcenatajedesc = Convert.ToInt32(datareader["nuporcenatajedesc"]);
                    registro.chordencompra = Convert.ToString(datareader["chordencompra"]).Trim();
                    registro.p_inidalmacen = Convert.ToInt32(datareader["p_inidalmacen"]);
                    registro.p_inidtransportista = Convert.ToInt32(datareader["p_inidtransportista"]);
                    registro.p_inidconductor = Convert.ToInt32(datareader["p_inidconductor"]);
                    registro.chplacavehiculo = Convert.ToString(datareader["chplacavehiculo"]).Trim();
                    registro.chfechainiciotransporte = Convert.ToString(datareader["chfechainiciotransporte"]).Trim();
                    registro.chpuntopartida = Convert.ToString(datareader["chpuntopartida"]).Trim();
                    registro.chpuntollegada = Convert.ToString(datareader["chpuntollegada"]).Trim();
                    registro.nuventaafectamonnacional = Convert.ToDecimal(datareader["nuventaafectamonnacional"]);
                    registro.chmotivotransaccion = Convert.ToString(datareader["chmotivotransaccion"]).Trim();
                    registro.p_inidmoneda = Convert.ToInt32(datareader["p_inidmoneda"]);
                    registro.p_inidigv = Convert.ToInt32(datareader["p_inidigv"]);
                    registro.boafectoigv = Convert.ToBoolean(datareader["boafectoigv"]);
                    registro.nuimportecambioventa = Convert.ToDecimal(datareader["nuimportecambioventa"]);
                    registro.p_inidvendedor = Convert.ToInt32(datareader["p_inidvendedor"]);
                    registro.chtiempoentrega = Convert.ToString(datareader["chtiempoentrega"]).Trim();
                    registro.nuventainafectamonnacional = Convert.ToDecimal(datareader["nuventainafectamonnacional"]);
                    registro.nutotaldescmonnacional = Convert.ToDecimal(datareader["nutotaldescmonnacional"]);
                    registro.nutotaligvmonnacional = Convert.ToDecimal(datareader["nutotaligvmonnacional"]);
                    registro.nutotalventamonnacional = Convert.ToDecimal(datareader["nutotalventamonnacional"]);
                    registro.nuventaafectamonextra = Convert.ToDecimal(datareader["nuventaafectamonextra"]);
                    registro.nuventainafectamonextra = Convert.ToDecimal(datareader["nuventainafectamonextra"]);
                    registro.nutotaldescmonextra = Convert.ToDecimal(datareader["nutotaldescmonextra"]);
                    registro.nutotaligvmonextra = Convert.ToDecimal(datareader["nutotaligvmonextra"]);
                    registro.nutotalventamonextra = Convert.ToDecimal(datareader["nutotalventamonextra"]);
                    registro.p_inidsituacionpedido = Convert.ToInt32(datareader["p_inidsituacionpedido"]);
                    registro.chobservacion = Convert.ToString(datareader["chobservacion"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.p_inidvehiculo = Convert.ToInt32(datareader["p_inidvehiculo"]);
                    registro.p_inidlicencia = Convert.ToInt32(datareader["p_inidlicencia"]);
                    registro.p_inidtarjeta = Convert.ToInt32(datareader["p_inidtarjeta"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        
            public static List<pedidodetalle> PedidoDetalleBusquedaParametro(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_pedidodetalle_busqueda_codigo_cabecera", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                List<pedidodetalle> listado = new List<pedidodetalle>();
                while (datareader.Read())
                {
                    pedidodetalle registro = new pedidodetalle();
                    registro.p_inidpedidodetalle = Convert.ToInt32(datareader["p_inidpedidodetalle"]);
                    registro.p_inidpedidocabecera = Convert.ToInt32(datareader["p_inidpedidocabecera"]);
                    registro.chitem = Convert.ToString(datareader["chitem"]).Trim();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.nucantidad = Convert.ToInt32(datareader["nucantidad"]);
                    registro.nuprecioproducto = Convert.ToInt32(datareader["nuprecioproducto"]);
                    registro.nuporcentajedesc1 = Convert.ToInt32(datareader["nuporcentajedesc1"]);
                    registro.nuporcentajedesc2 = Convert.ToInt32(datareader["nuporcentajedesc2"]);
                    registro.nuprecioventa = Convert.ToInt32(datareader["nuprecioventa"]);
                    registro.nuimportesubtotal = Convert.ToInt32(datareader["nuimportesubtotal"]);
                    registro.nuimportetotal = Convert.ToInt32(datareader["nuimportetotal"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.p_inidserie = Convert.ToInt32(datareader["p_inidserie"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static pedidocabecera PedidoCabeceraBusquedaCodigo(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_pedidocabecera_busqueda_codigo", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                pedidocabecera registro = new pedidocabecera();
                while (datareader.Read())
                {
                    registro.p_inidpedidocabecera = Convert.ToInt32(datareader["p_inidpedidocabecera"]);
                    registro.p_inidpuntoventa = Convert.ToInt32(datareader["p_inidpuntoventa"]);
                    registro.chcodigopedido = Convert.ToString(datareader["chcodigopedido"]).Trim();
                    registro.chfechapedido = Convert.ToString(datareader["chfechapedido"]).Trim();
                    registro.tmhorapedido = Convert.ToString(datareader["tmhorapedido"]).Trim();
                    registro.p_inidtipodocumento = Convert.ToInt32(datareader["p_inidtipodocumento"]);
                    registro.p_inidcliente = Convert.ToInt32(datareader["p_inidcliente"]);
                    registro.p_inmotivotransaccion = Convert.ToInt32(datareader["p_inmotivotransaccion"]);
                    registro.p_inidcompromisopago = Convert.ToInt32(datareader["p_inidcompromisopago"]);
                    registro.nuporcenatajedesc = Convert.ToInt32(datareader["nuporcenatajedesc"]);
                    registro.chordencompra = Convert.ToString(datareader["chordencompra"]).Trim();
                    registro.p_inidalmacen = Convert.ToInt32(datareader["p_inidalmacen"]);
                    registro.p_inidtransportista = Convert.ToInt32(datareader["p_inidtransportista"]);
                    registro.p_inidconductor = Convert.ToInt32(datareader["p_inidconductor"]);
                    registro.chplacavehiculo = Convert.ToString(datareader["chplacavehiculo"]).Trim();
                    registro.chfechainiciotransporte = Convert.ToString(datareader["chfechainiciotransporte"]).Trim();
                    registro.chpuntopartida = Convert.ToString(datareader["chpuntopartida"]).Trim();
                    registro.chpuntollegada = Convert.ToString(datareader["chpuntollegada"]).Trim();
                    registro.nuventaafectamonnacional = Convert.ToDecimal(datareader["nuventaafectamonnacional"]);
                    registro.chmotivotransaccion = Convert.ToString(datareader["chmotivotransaccion"]).Trim();
                    registro.p_inidmoneda = Convert.ToInt32(datareader["p_inidmoneda"]);
                    registro.p_inidigv = Convert.ToInt32(datareader["p_inidigv"]);
                    registro.boafectoigv = Convert.ToBoolean(datareader["boafectoigv"]);
                    registro.nuimportecambioventa = Convert.ToDecimal(datareader["nuimportecambioventa"]);
                    registro.p_inidvendedor = Convert.ToInt32(datareader["p_inidvendedor"]);
                    registro.chtiempoentrega = Convert.ToString(datareader["chtiempoentrega"]).Trim();
                    registro.nuventainafectamonnacional = Convert.ToDecimal(datareader["nuventainafectamonnacional"]);
                    registro.nutotaldescmonnacional = Convert.ToDecimal(datareader["nutotaldescmonnacional"]);
                    registro.nutotaligvmonnacional = Convert.ToDecimal(datareader["nutotaligvmonnacional"]);
                    registro.nutotalventamonnacional = Convert.ToDecimal(datareader["nutotalventamonnacional"]);
                    registro.nuventaafectamonextra = Convert.ToDecimal(datareader["nuventaafectamonextra"]);
                    registro.nuventainafectamonextra = Convert.ToDecimal(datareader["nuventainafectamonextra"]);
                    registro.nutotaldescmonextra = Convert.ToDecimal(datareader["nutotaldescmonextra"]);
                    registro.nutotaligvmonextra = Convert.ToDecimal(datareader["nutotaligvmonextra"]);
                    registro.nutotalventamonextra = Convert.ToDecimal(datareader["nutotalventamonextra"]);
                    registro.p_inidsituacionpedido = Convert.ToInt32(datareader["p_inidsituacionpedido"]);
                    registro.chobservacion = Convert.ToString(datareader["chobservacion"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.p_inidvehiculo = Convert.ToInt32(datareader["p_inidvehiculo"]);
                    registro.p_inidlicencia = Convert.ToInt32(datareader["p_inidlicencia"]);
                    registro.p_inidtarjeta = Convert.ToInt32(datareader["p_inidtarjeta"]);
                }
                return registro;
            }
        }
        public static List<pedidocabecera> PedidoCabeceraListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_pedidocabecera_listar", CommandType.StoredProcedure))
            {
                List<pedidocabecera> listado = new List<pedidocabecera>();
                while (datareader.Read())
                {
                    pedidocabecera registro = new pedidocabecera();
                    registro.p_inidpedidocabecera = Convert.ToInt32(datareader["p_inidpedidocabecera"]);
                    registro.p_inidpuntoventa = Convert.ToInt32(datareader["p_inidpuntoventa"]);
                    registro.chcodigopedido = Convert.ToString(datareader["chcodigopedido"]).Trim();
                    registro.chfechapedido = Convert.ToString(datareader["chfechapedido"]).Trim();
                    registro.tmhorapedido = Convert.ToString(datareader["tmhorapedido"]).Trim();
                    registro.p_inidtipodocumento = Convert.ToInt32(datareader["p_inidtipodocumento"]);
                    registro.p_inidcliente = Convert.ToInt32(datareader["p_inidcliente"]);
                    registro.p_inmotivotransaccion = Convert.ToInt32(datareader["p_inmotivotransaccion"]);
                    registro.p_inidcompromisopago = Convert.ToInt32(datareader["p_inidcompromisopago"]);
                    registro.nuporcenatajedesc = Convert.ToInt32(datareader["nuporcenatajedesc"]);
                    registro.chordencompra = Convert.ToString(datareader["chordencompra"]).Trim();
                    registro.p_inidalmacen = Convert.ToInt32(datareader["p_inidalmacen"]);
                    registro.p_inidtransportista = Convert.ToInt32(datareader["p_inidtransportista"]);
                    registro.p_inidconductor = Convert.ToInt32(datareader["p_inidconductor"]);
                    registro.chplacavehiculo = Convert.ToString(datareader["chplacavehiculo"]).Trim();
                    registro.chfechainiciotransporte = Convert.ToString(datareader["chfechainiciotransporte"]).Trim();
                    registro.chpuntopartida = Convert.ToString(datareader["chpuntopartida"]).Trim();
                    registro.chpuntollegada = Convert.ToString(datareader["chpuntollegada"]).Trim();
                    registro.nuventaafectamonnacional = Convert.ToDecimal(datareader["nuventaafectamonnacional"]);
                    registro.chmotivotransaccion = Convert.ToString(datareader["chmotivotransaccion"]).Trim();
                    registro.p_inidmoneda = Convert.ToInt32(datareader["p_inidmoneda"]);
                    registro.p_inidigv = Convert.ToInt32(datareader["p_inidigv"]);
                    registro.boafectoigv = Convert.ToBoolean(datareader["boafectoigv"]);
                    registro.nuimportecambioventa = Convert.ToDecimal(datareader["nuimportecambioventa"]);
                    registro.p_inidvendedor = Convert.ToInt32(datareader["p_inidvendedor"]);
                    registro.chtiempoentrega = Convert.ToString(datareader["chtiempoentrega"]).Trim();
                    registro.nuventainafectamonnacional = Convert.ToDecimal(datareader["nuventainafectamonnacional"]);
                    registro.nutotaldescmonnacional = Convert.ToDecimal(datareader["nutotaldescmonnacional"]);
                    registro.nutotaligvmonnacional = Convert.ToDecimal(datareader["nutotaligvmonnacional"]);
                    registro.nutotalventamonnacional = Convert.ToDecimal(datareader["nutotalventamonnacional"]);
                    registro.nuventaafectamonextra = Convert.ToDecimal(datareader["nuventaafectamonextra"]);
                    registro.nuventainafectamonextra = Convert.ToDecimal(datareader["nuventainafectamonextra"]);
                    registro.nutotaldescmonextra = Convert.ToDecimal(datareader["nutotaldescmonextra"]);
                    registro.nutotaligvmonextra = Convert.ToDecimal(datareader["nutotaligvmonextra"]);
                    registro.nutotalventamonextra = Convert.ToDecimal(datareader["nutotalventamonextra"]);
                    registro.p_inidsituacionpedido = Convert.ToInt32(datareader["p_inidsituacionpedido"]);
                    registro.chobservacion = Convert.ToString(datareader["chobservacion"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.p_inidvehiculo = Convert.ToInt32(datareader["p_inidvehiculo"]);
                    registro.p_inidlicencia = Convert.ToInt32(datareader["p_inidlicencia"]);
                    registro.p_inidtarjeta = Convert.ToInt32(datareader["p_inidtarjeta"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        
    }
}
