using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class movimientosDL
    {
        public static int MovimientoProductoCabeceraIngresar(movimientoproductoc registros)
        {
            return conexion.executeScalar("fn_moviproductocabecera_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidalamacen", registros.p_inidalamacen),
            new parametro("in_p_inidclase", registros.p_inidclase),
            new parametro("in_p_inidcorrevale", registros.p_inidcorrevale),
            new parametro("in_chvalefecha", registros.chvalefecha),
            new parametro("in_p_inidtipomoneda", registros.p_inidtipomoneda),
            new parametro("in_p_inidproveedor", registros.p_inidproveedor),
            new parametro("in_chguiaremision", registros.chguiaremision),
            new parametro("in_chboletafactura", registros.chboletafactura),
            new parametro("in_p_inidtipomoviemiento", registros.p_inidtipomoviemiento),
            new parametro("in_chobservacion", registros.chobservacion),
            new parametro("in_p_inidusuarioinsert", registros.p_inidusuarioinsert),
            new parametro("in_p_inidusuariodelete", registros.p_inidusuariodelete),
            new parametro("in_estado", registros.estado),
            new parametro("in_p_inidmovimiento", registros.p_inidmovimiento ),
            new parametro("in_chtipref1", registros.chtipref1),
            new parametro("in_chref1", registros.chref1),
            new parametro("in_chnref1", registros.chnref1),
            new parametro("in_chtipref2", registros.chtipref2),
            new parametro("in_chref2", registros.chref2),
            new parametro("in_chnref2", registros.chnref2),
            new parametro("in_chtipref3", registros.chtipref3),
            new parametro("in_chref3", registros.chref3),
            new parametro("in_chnref3", registros.chnref3),
            new parametro("in_chtipref4", registros.chtipref4),
            new parametro("in_chref4", registros.chref4),
            new parametro("in_chnref4", registros.chnref4),
            new parametro("in_chtipref5", registros.chtipref5),
            new parametro("in_chref5", registros.chref5 ),
            new parametro("in_chnref5", registros.chnref5 )
            );
        }

        public static int MovimientoProductoCabeceraModificar(movimientoproductoc registros)
        {
            return conexion.executeScalar("fn_moviproductocabecera_modificar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidvalecebecera", registros.p_inidvalecebecera),
            new parametro("in_p_inidalamacen", registros.p_inidalamacen),
            new parametro("in_p_inidclase", registros.p_inidclase),
            new parametro("in_p_inidcorrevale", registros.p_inidcorrevale),
            new parametro("in_chvalefecha", registros.chvalefecha),
            new parametro("in_p_inidtipomoneda", registros.p_inidtipomoneda),
            new parametro("in_p_inidproveedor", registros.p_inidproveedor),
            new parametro("in_chguiaremision", registros.chguiaremision),
            new parametro("in_chboletafactura", registros.chboletafactura),
            new parametro("in_p_inidtipomoviemiento", registros.p_inidtipomoviemiento),
            new parametro("in_chobservacion", registros.chobservacion),
            new parametro("in_p_inidusuarioinsert", registros.p_inidusuarioinsert),
            new parametro("in_p_inidusuariodelete", registros.p_inidusuariodelete),
            new parametro("in_estado", registros.estado),
            new parametro("in_p_inidmovimiento", registros.p_inidmovimiento));

        }
        public static int MovimientoProductoDetalleFalsear(int parametro)
        {
            return conexion.executeScalar("fn_movimiento_detalle_falsear", CommandType.StoredProcedure, new parametro("in_p_inidvalecebecera", parametro));
        }
        public static int MovimientoProductoCabeceraFalsear(int parametro)
        {
            return conexion.executeScalar("fn_movimiento_cabecera_falsear", CommandType.StoredProcedure, new parametro("in_p_inidvalecebecera", parametro));
        }
        public static List<valedetalle> MovimientoProductoDetalleBusqueda(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_movimiento_detalle_busqueda", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                List<valedetalle> listado = new List<valedetalle>();
                while (datareader.Read())
                {
                    valedetalle registro = new valedetalle();
                    registro.p_inidvaledetalle = Convert.ToInt32(datareader["p_inidvaledetalle"]);
                    registro.p_inidvalecebecera = Convert.ToInt32(datareader["p_inidvalecebecera"]);
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.chnombrecompuesto = Convert.ToString(datareader["chnombrecompuesto"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.nucantidad = Convert.ToInt32(datareader["nucantidad"]);
                    registro.nucosto = Convert.ToDecimal(datareader["nucosto"]);
                    registro.nutotal = Convert.ToDecimal(datareader["nutotal"]);
                    registro.chmedida = Convert.ToString(datareader["chunidadmedidaproducto"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static int MovimientoProductoDetalleIngresar(movimientoproductod registros)
        {
            return conexion.executeScalar("fn_moviproductodetalle_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidvalecebecera", registros.p_inidvalecebecera),
            new parametro("in_p_inidproducto", registros.p_inidproducto),
            new parametro("in_nucantidad", registros.nucantidad),
            new parametro("in_nucosto", registros.nucosto),
            new parametro("in_nutotal", registros.nutotal));

        }
        public static movimientoproductoc MovimientoProductoCabeceraBusqueda(int codigoMovimiento)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_movimiento_cabecera_busqueda",
            CommandType.StoredProcedure, new parametro("in_parametro", codigoMovimiento)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }

        private static movimientoproductoc convertirRegistro(IDataReader datareader)
        {
            movimientoproductoc registro = new movimientoproductoc();
            registro.p_inidvalecebecera = Convert.ToInt32(datareader["p_inidvalecebecera"]);
            registro.p_inidalamacen = Convert.ToInt32(datareader["p_inidalamacen"]);
            registro.p_inidclase = Convert.ToInt32(datareader["p_inidclase"]);
            registro.p_inidcorrevale = Convert.ToString(datareader["p_inidcorrevale"]);
            registro.chvalefecha = Convert.ToString(datareader["chvalefecha"]).Trim();
            registro.p_inidtipomoneda = Convert.ToInt32(datareader["p_inidtipomoneda"]);
            registro.p_inidproveedor = Convert.ToInt32(datareader["p_inidproveedor"]);
            registro.chguiaremision = Convert.ToString(datareader["chguiaremision"]).Trim();
            registro.chboletafactura = Convert.ToString(datareader["chboletafactura"]).Trim();
            registro.p_inidtipomoviemiento = Convert.ToInt32(datareader["p_inidtipomoviemiento"]);
            registro.chobservacion = Convert.ToString(datareader["chobservacion"]).Trim();
            registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
            registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]); ;
            registro.estado = Convert.ToBoolean(datareader["estado"]);
            registro.p_inidmovimiento = Convert.ToInt32(datareader["p_inidmovimiento"]);

            registro.chtipref1 = Convert.ToString(datareader["chtipref1"]).Trim();
            registro.chref1 = Convert.ToString(datareader["chref1"]).Trim();
            registro.chnref1 = Convert.ToString(datareader["chnref1"]).Trim();
            registro.chtipref2 = Convert.ToString(datareader["chtipref2"]).Trim();
            registro.chref2 = Convert.ToString(datareader["chref2"]).Trim();
            registro.chnref2 = Convert.ToString(datareader["chnref2"]).Trim();
            registro.chtipref3 = Convert.ToString(datareader["chtipref3"]).Trim();
            registro.chref3 = Convert.ToString(datareader["chref3"]).Trim();
            registro.chnref3 = Convert.ToString(datareader["chnref3"]).Trim();
            registro.chtipref4 = Convert.ToString(datareader["chtipref4"]).Trim();
            registro.chref4 = Convert.ToString(datareader["chref4"]).Trim(); 
            registro.chnref4 = Convert.ToString(datareader["chnref4"]).Trim();
            registro.chtipref5 = Convert.ToString(datareader["chtipref5"]).Trim();
            registro.chref5 = Convert.ToString(datareader["chref5"]).Trim();
            registro.chnref5 = Convert.ToString(datareader["chnref5"]).Trim();
            return registro;
        }
        public static List<kardexdetalle> ListarKardexBusquedaCodigo(int codigo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_kardex_listar_codigo", CommandType.StoredProcedure, new parametro("in_codigo", codigo)))
            {
                List<kardexdetalle> listado = new List<kardexdetalle>();
                while (datareader.Read())
                {
                    kardexdetalle registro = new kardexdetalle();
                    registro.chfechamovi = Convert.ToString(datareader["chvalefecha"]).Trim();
                    registro.p_inidtipomovimiento = Convert.ToInt32(datareader["p_inidtipomovimiento"]);
                    registro.chcorrelativo = Convert.ToString(datareader["chcorrelativo"]).Trim();
                    registro.nucantidad = Convert.ToInt32(datareader["nucantidad"]);
                    registro.p_inidmovimiento = Convert.ToInt32(datareader["p_inidmovimiento"]);
                    registro.chreftip1 = Convert.ToString(datareader["chreftip1"]).Trim();
                    registro.chrefnombre1 = Convert.ToString(datareader["chrefnombre1"]).Trim();
                    registro.chreftip2 = Convert.ToString(datareader["chreftip2"]).Trim();
                    registro.chrefnombre2 = Convert.ToString(datareader["chrefnombre2"]).Trim();
                    registro.chreftip3 = Convert.ToString(datareader["chreftip3"]).Trim();
                    registro.chrefnombre3 = Convert.ToString(datareader["chrefnombre3"]).Trim();
                    registro.chreftip4 = Convert.ToString(datareader["chreftip4"]).Trim();
                    registro.chrefnombre4 = Convert.ToString(datareader["chrefnombre4"]).Trim();                    
                    listado.Add(registro);
                }
                return listado;
            }
        }
        
        public static tipomovimiento TipoMovimientoBusqueda(int codigo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_tipomovimiento_buqueda_codigo", CommandType.StoredProcedure, new parametro("in_parametro", codigo)))
            {
                tipomovimiento registro = new tipomovimiento();
                while (datareader.Read())
                {
                    registro.p_inidtipomovimiento = Convert.ToInt32(datareader["p_inidtipomovimiento"]);
                    registro.p_inidmovimiento = Convert.ToInt32(datareader["p_inidmovimiento"]);
                    registro.chnombremovimiento = Convert.ToString(datareader["chnombremovimiento"]).Trim();
                    registro.chnref1 = Convert.ToString(datareader["chnref1"]).Trim();
                    registro.chtipref1 = Convert.ToString(datareader["chtipref1"]).Trim();
                    registro.chnref2 = Convert.ToString(datareader["chnref2"]).Trim();
                    registro.chtipref2 = Convert.ToString(datareader["chtipref2"]).Trim();
                    registro.chnref3 = Convert.ToString(datareader["chnref3"]).Trim();
                    registro.chtipref3 = Convert.ToString(datareader["chtipref3"]).Trim();
                    registro.chnref4 = Convert.ToString(datareader["chnref4"]).Trim();
                    registro.chtipref4 = Convert.ToString(datareader["chtipref4"]).Trim();
                    registro.chnref5 = Convert.ToString(datareader["chnref5"]).Trim();
                    registro.chtipref5 = Convert.ToString(datareader["chtipref5"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                }
                return registro;
            }
        }
        public static List<tipomovimiento> ListarTipomovimientos(int codigo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_tipomovimiento_listar_codigo", CommandType.StoredProcedure, new parametro("in_parametro", codigo)))
            {
                List<tipomovimiento> listado = new List<tipomovimiento>();
                while (datareader.Read())
                {
                    tipomovimiento registro = new tipomovimiento();
                    registro.p_inidtipomovimiento = Convert.ToInt32(datareader["p_inidtipomovimiento"]);
                    registro.p_inidmovimiento = Convert.ToInt32(datareader["p_inidmovimiento"]);
                    registro.chnombremovimiento = Convert.ToString(datareader["chnombremovimiento"]).Trim();
                    registro.chnref1 = Convert.ToString(datareader["chnref1"]).Trim();
                    registro.chtipref1 = Convert.ToString(datareader["chtipref1"]).Trim();
                    registro.chnref2 = Convert.ToString(datareader["chnref2"]).Trim();
                    registro.chtipref2 = Convert.ToString(datareader["chtipref2"]).Trim();
                    registro.chnref3 = Convert.ToString(datareader["chnref3"]).Trim();
                    registro.chtipref3 = Convert.ToString(datareader["chtipref3"]).Trim();
                    registro.chnref4 = Convert.ToString(datareader["chnref4"]).Trim();
                    registro.chtipref4 = Convert.ToString(datareader["chtipref4"]).Trim();
                    registro.chnref5 = Convert.ToString(datareader["chnref5"]).Trim();
                    registro.chtipref5 = Convert.ToString(datareader["chtipref5"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }

    }
}
