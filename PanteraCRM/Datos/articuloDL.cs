using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class articuloDL
    {
        public static List<articulo> articuloListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_articulo_listar", CommandType.StoredProcedure))
            {
                List<articulo> listado = new List<articulo>();
                while (datareader.Read())
                {
                    articulo registro = new articulo();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.p_inidtipoproducto = Convert.ToString(datareader["chtipoproducto"]).Trim();
                    registro.p_inidmarca = Convert.ToString(datareader["chmarca"]).Trim();
                    registro.p_inidcalibre = Convert.ToString(datareader["chcalibre"]).Trim();
                    registro.p_inidmodelo = Convert.ToString(datareader["chmodelo"]).Trim();
                    registro.p_inidfamiliaproducto = Convert.ToString(datareader["chfamiliaproducto"]).Trim();
                    registro.p_inidunidadmedidaproducto = Convert.ToString(datareader["chunidadmedidaproducto"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<articulopresupuesto> articuloListarPresupuesto()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_articulo_listar_presupuesto", CommandType.StoredProcedure))
            {
                List<articulopresupuesto> listado = new List<articulopresupuesto>();
                while (datareader.Read())
                {
                    articulopresupuesto registro = new articulopresupuesto();
                    registro.idarticulo = Convert.ToInt32(datareader["idarticulo"]);
                    registro.codigoarticulo = Convert.ToString(datareader["codigoarticulo"]).Trim();
                    registro.nombrearticulo = Convert.ToString(datareader["nombrearticulo"]).Trim();
                    registro.idtipoarticulo = Convert.ToString(datareader["idtipoarticulo"]).Trim();
                    registro.idmediarticulo = Convert.ToString(datareader["idmediarticulo"]).Trim();
                    registro.precio = Convert.ToDecimal(datareader["precio"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        //public static string obtenerNumero(int idtipoarticulo, int idcatearticulo)
        //{
        //    {
        //        return conexion.executeScalarStr("fn_articulo_obtener_numero",
        //        CommandType.StoredProcedure,
        //        new parametro("in_idtipoarticulo", idtipoarticulo),
        //        new parametro("in_idcatearticulo", idcatearticulo));
        //    }
        //}
        public static int articuloInsertar(articulo articulo)
        {
            return 0;
            //return conexion.executeScalar("fn_articulo_insertar",
            //CommandType.StoredProcedure,
            //new parametro("in_codigoarticulo", articulo.codigoarticulo),
            //new parametro("in_nombrearticulo", articulo.nombrearticulo),
            ////new parametro("in_idtipoarticulo", articulo.idtipoarticulo),
            //new parametro("in_idcatearticulo", articulo.idcatearticulo),
            //new parametro("in_idmediarticulo", articulo.idmediarticulo),
            //new parametro("in_fechacreacion", articulo.fechacreacion),
            //new parametro("in_precio", articulo.precio),
            //new parametro("in_idusuario", articulo.idusuario),
            //new parametro("in_idsituarticulo", articulo.idsituarticulo),
            ////new parametro("in_estadoarticulo", articulo.estadoarticulo));
        }
        public static int articuloActualizar(producto producto)
        {
            //return 0;
            return conexion.executeScalar("fn_producto_insertar",
            CommandType.StoredProcedure,
            new parametro("in_chcodigoproducto", producto.chcodigoproducto),
            new parametro("in_p_inidtipoproducto", producto.p_inidtipoproducto),
            new parametro("in_p_inidmarca", producto.p_inidmarca),
            new parametro("in_p_inidunidadmedidaproducto", producto.p_inidunidadmedidaproducto),
            new parametro("in_chfechacreacion", producto.chfechacreacion),
            new parametro("in_estado", producto.estado),
            new parametro("in_p_inidfamiliaproducto", producto.p_inidfamiliaproducto),
            new parametro("in_p_inidcalibre", producto.p_inidcalibre),
            new parametro("in_p_inidmodelo", producto.p_inidmodelo),
            new parametro("in_chcodigoproductoantes", producto.chcodigoproductoantes),
            new parametro("in_chdescripcionproducto", producto.chdescripcionproducto),
            new parametro("in_p_inidusuarioinsert", producto.p_inidusuarioinsert),
            new parametro("in_p_inidusuariodelete", producto.p_inidusuariodelete),
            new parametro("in_nuprecio", producto.nuprecio),
            new parametro("in_p_inidsituacion", producto.p_inidsituacion));

            
        }
        private static articulo convertirRegistro(IDataReader datareader)
        {
            //articulo registro = new articulo();
            //registro.idusuario = Convert.ToInt32(datareader["idusuario"]);
            //registro.codigoarticulo = Convert.ToString(datareader["codigoarticulo"]);
            //registro.nombrearticulo = Convert.ToString(datareader["nombrearticulo"]);
            //registro.idtipoarticulo = Convert.ToString(datareader["idtipoarticulo"]);
            //registro.tipoarticulo = Convert.ToString(datareader["tipoarticulo"]);
            //registro.idcatearticulo = Convert.ToString(datareader["idcatearticulo"]);
            //registro.catearticulo = Convert.ToString(datareader["catearticulo"]);
            //registro.idmediarticulo = Convert.ToString(datareader["idmediarticulo"]);
            //registro.fechacreacion = Convert.ToString(datareader["fechacreacion"]);
            //registro.precio = Convert.ToDecimal(datareader["precio"]);
            //registro.idusuario = Convert.ToInt32(datareader["idusuario"]);
            //registro.idsituarticulo = Convert.ToString(datareader["idsituarticulo"]);
            //registro.estadoarticulo = Convert.ToBoolean(datareader["estadoarticulo"]);
            return null;
        }

        public static DataTable articuloReporteTotalCantidadPorVendedor(int idusuario,string fechaini ,string fechafin)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_articulo_reporte_totalcantidad_por_vendedor", 
                CommandType.StoredProcedure, new parametro("in_idusuario", idusuario), new parametro("in_fechaini", fechaini)
                , new parametro("in_fechafin", fechafin)))
                {
                DataTable dtCursor = new DataTable("ArticuloVendido");
                dtCursor.Columns.Add("codigoarticulo", System.Type.GetType("System.String"));
                dtCursor.Columns.Add("nombrearticulo", System.Type.GetType("System.String"));
                dtCursor.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
                dtCursor.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));

                while (datareader.Read())
                {
                    DataRow Renglon;
                    Renglon = dtCursor.NewRow();

                    Renglon[0] = Convert.ToString(datareader["codigoarticulo"]);
                    Renglon[1] = Convert.ToString(datareader["nombrearticulo"]);
                    Renglon[2] = Convert.ToInt32(datareader["cantidad"]);
                    Renglon[3] = Convert.ToDecimal(datareader["subtotal"]);
                    dtCursor.Rows.Add(Renglon);
                }
                return dtCursor;
            }
        }
        public static DataTable articuloReporteTotalCantidadTodos(string fechaini, string fechafin)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_articulo_reporte_totalcantidad_todos",
                CommandType.StoredProcedure, new parametro("in_fechaini", fechaini)
                , new parametro("in_fechafin", fechafin)))
            {
                DataTable dtCursor = new DataTable("ArticuloVendido");
                dtCursor.Columns.Add("codigoarticulo", System.Type.GetType("System.String"));
                dtCursor.Columns.Add("nombrearticulo", System.Type.GetType("System.String"));
                dtCursor.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
                dtCursor.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));

                while (datareader.Read())
                {
                    DataRow Renglon;
                    Renglon = dtCursor.NewRow();

                    Renglon[0] = Convert.ToString(datareader["codigoarticulo"]);
                    Renglon[1] = Convert.ToString(datareader["nombrearticulo"]);
                    Renglon[2] = Convert.ToInt32(datareader["cantidad"]);
                    Renglon[3] = Convert.ToDecimal(datareader["subtotal"]);
                    dtCursor.Rows.Add(Renglon);
                }
                return dtCursor;
            }
        }
    }
}
