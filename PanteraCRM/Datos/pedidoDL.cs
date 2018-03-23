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
        public static int CabeceraCambiarEstado(int parametro, int codigo)
        {
            return conexion.executeScalar("fn_movimiento_cabecera_anular", CommandType.StoredProcedure, new parametro("in_p_inidpedidocabecera", parametro), new parametro("in_p_inidcodigo", codigo));

        }
        
             public static int IngresoRegistroVenta(RegistroVenta registros)
        {
            return conexion.executeScalar("fn_registro_venta_ingresar",
            CommandType.StoredProcedure,
            //this.p_inidregistroventa = 0;
            new parametro("in_p_inidpuntoventa", registros.p_inidpuntoventa ),
            new parametro("in_p_inidtipodocu", registros.p_inidtipodocu),
            new parametro("in_p_iniddocumento", registros.p_iniddocumento),
            new parametro("in_chcodigodocu", registros.chcodigodocu),
            new parametro("in_chfechadoc", registros.chfechadoc),
            new parametro("in_p_inidcliente", registros.p_inidcliente),
            new parametro("in_nucambioventa", registros.nucambioventa),
            new parametro("in_nuimporvtaafecta", registros.nuimporvtaafecta),
            new parametro("in_nuimportotdesc", registros.nuimportotdesc),
            new parametro("in_nuimporttotigv", registros.nuimporttotigv),
            new parametro("in_nuimportetotvta", registros.nuimportetotvta),
            new parametro("in_tipomovimiento", registros.tipomovimiento),
            new parametro("in_chfechaventa", registros.chfechaventa),
            new parametro("in_p_inidsituacionregistro", registros.p_inidsituacionregistro),
            new parametro("in_p_inidusuarioinsert", registros.p_inidusuarioinsert),
            new parametro("in_p_inidusuariodelete", registros.p_inidusuariodelete),
            new parametro("in_estado", registros.estado)
            );
        }
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
        public static int BusquedaMaximaVendida(int cliente, string fecha)
        {
            return conexion.executeScalar("fn_ventamaxima_busqueda",
            CommandType.StoredProcedure,
                    //new parametro("in_p_inidpedidocabecera", registros.p_inidpedidocabecera),
                    new parametro("in_p_inidcliente", cliente),
                    new parametro("chfechaini", fecha)
            );
        }
        public static int BusquedaMaximaVendida2(int cliente, string fecha)
        {
            return conexion.executeScalar("fn_ventamaxima_busqueda2",
            CommandType.StoredProcedure,
                    //new parametro("in_p_inidpedidocabecera", registros.p_inidpedidocabecera),
                    new parametro("in_p_inidcliente", cliente),
                    new parametro("chfechaini", fecha)
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
        public static List<RegistroVenta> BuscarRegistroVentasCliente(int clientecodigo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_registroventa_busqueda", CommandType.StoredProcedure, new parametro("in_parametro", clientecodigo)))
            {
                List < RegistroVenta > Listado = new List<RegistroVenta>();
                while (datareader.Read())
                {
                    RegistroVenta registro = new RegistroVenta();
                    registro.p_inidregistroventa = Convert.ToInt32(datareader["p_inidregistroventa"]);
                    registro.p_inidpuntoventa = Convert.ToInt32(datareader["p_inidpuntoventa"]);
                    registro.p_inidtipodocu = Convert.ToInt32(datareader["p_inidtipodocu"]);
                    registro.p_iniddocumento = Convert.ToInt32(datareader["p_iniddocumento"]);
                    registro.chcodigodocu = Convert.ToString(datareader["chcodigodocu"]).Trim();
                    registro.chfechadoc = Convert.ToString(datareader["chfechadoc"]).Trim();
                    registro.p_inidcliente = Convert.ToInt32(datareader["p_inidcliente"]);
                    registro.nucambioventa = Convert.ToDecimal(datareader["nucambioventa"]);
                    registro.nuimporvtaafecta = Convert.ToDecimal(datareader["nuimporvtaafecta"]);
                    registro.nuimportotdesc = Convert.ToDecimal(datareader["nuimportotdesc"]);
                    registro.nuimporttotigv = Convert.ToDecimal(datareader["nuimporttotigv"]);
                    registro.nuimportetotvta = Convert.ToDecimal(datareader["nuimportetotvta"]);
                    registro.tipomovimiento = Convert.ToString(datareader["tipomovimiento"]).Trim();
                    registro.chfechaventa = Convert.ToString(datareader["chfechaventa"]).Trim();
                    registro.p_inidsituacionregistro = Convert.ToInt32(datareader["p_inidsituacionregistro"]);
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    Listado.Add(registro);
                }
                return Listado;
            }

        }
        public static pedidoguicomp BuscarComprobantesFacturados(string registros, string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_pedidofact_busqueda", CommandType.StoredProcedure, new parametro("in_parametro", registros), new parametro("in_codigo", parametro)))
            {
                pedidoguicomp registro = new pedidoguicomp();
                while (datareader.Read())
                {
                    registro.p_inidpedidoguicomp = Convert.ToInt32(datareader["p_inidpedidoguicomp"]);
                    registro.chcodigopedido = Convert.ToString(datareader["chcodigopedido"]).Trim();
                    registro.chguiaremision = Convert.ToString(datareader["chguiaremision"]).Trim();
                    registro.chcomprobante = Convert.ToString(datareader["chcomprobante"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                }
                return registro;
            }

        }
        public static int IngresoComprobantesGenerado(pedidoguicomp registros)
        {
            return conexion.executeScalar("fn_pedidoguicomp_ingresar",
                    CommandType.StoredProcedure,

            //new parametro("in_p_inidpedidocabecera", registros.p_inidpedidoguicomp),
            new parametro("in_chcodigopedido", registros.chcodigopedido),
            new parametro("in_chguiaremision", registros.chguiaremision),
            new parametro("in_chcomprobante", registros.chcomprobante),
            new parametro("in_chtipocompro", registros.chtipocompro),
            new parametro("in_estado", registros.estado),
            new parametro("in_chobservacion", registros.chobservacion)
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
                    registro.nucantidad = Convert.ToDecimal(datareader["nucantidad"]);
                    registro.nuprecioproducto = Convert.ToDecimal(datareader["nuprecioproducto"]);
                    registro.nuporcentajedesc1 = Convert.ToDecimal(datareader["nuporcentajedesc1"]);
                    registro.nuporcentajedesc2 = Convert.ToDecimal(datareader["nuporcentajedesc2"]);
                    registro.nuprecioventa = Convert.ToDecimal(datareader["nuprecioventa"]);
                    registro.nuimportesubtotal = Convert.ToDecimal(datareader["nuimportesubtotal"]);
                    registro.nuimportetotal = Convert.ToDecimal(datareader["nuimportetotal"]);
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
