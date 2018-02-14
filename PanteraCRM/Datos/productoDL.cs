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
        // LISTAR PRODUCTOS
        
             public static List<producto> productoListarBusqueda(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_producto_listar_busqueda", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
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
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
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
                    registro.req_serie = Convert.ToBoolean(datareader["o_req_serie"]);
                    registro.chsituacion = Convert.ToString(datareader["chsituacion"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
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
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
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
                    registro.req_serie = Convert.ToBoolean (datareader["o_req_serie"]);
                    registro.chsituacion = Convert.ToString(datareader["chsituacion"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        //PRODUCTO BUSCADO LISTAR
        public static List<productobuscado> productobuscadoListar(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_producto_buscar_codigo_o_nombre", CommandType.StoredProcedure,
                new parametro("in_parametro", parametro)))
            {
                List<productobuscado> listado = new List<productobuscado>();
                while (datareader.Read())
                {
                    productobuscado registro = new productobuscado();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.chnombrecompuesto = Convert.ToString(datareader["chnombrecompuesto"]).Trim();
                    registro.p_inidunidadmedidaproducto = Convert.ToInt32(datareader["p_inidunidadmedidaproducto"]);
                    registro.chunidadmedidaproducto = Convert.ToString(datareader["chunidadmedidaproducto"]).Trim();
                    registro.p_inidsituacion = Convert.ToInt32(datareader["p_inidsituacion"]);
                    registro.chsituacion = Convert.ToString(datareader["chsituacion"]).Trim();
                    registro.nuprecio = Convert.ToDecimal(datareader["nuprecio"]);
                    registro.req_serie = Convert.ToBoolean(datareader["req_serie"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        //INGRESAR PRODUCTOS
        public static int productoInsertar(producto producto)
        {
            return conexion.executeScalar ("fn_ProductoIngresar",
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
            new parametro("in_p_inidsituacion", producto.p_inidsituacion),
            new parametro("in_req_serie", producto.req_serie));

        }
        //MODIFICAR PRODUCTOS
        public static int ProductoActualizar(producto producto)
        {
            {
                return conexion.executeScalar("fn_ProductosActualizar",
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
            new parametro("in_p_inidsituacion", producto.p_inidsituacion),
            new parametro("in_p_inidproducto", producto.p_inidproducto),
            new parametro("in_req_serie", producto.req_serie)
            );
            }
        }
        //BUSCAR PRODUCTO PARA AGREGAR PRECIO
        
         public static List<productobuscado> productobuscadoListaPrecio(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_producto_Lista_Precio", CommandType.StoredProcedure,
                new parametro("in_parametro", parametro)))
            {
                List<productobuscado> listado = new List<productobuscado>();
                while (datareader.Read())
                {
                    productobuscado registro = new productobuscado();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.chnombrecompuesto = Convert.ToString(datareader["chnombrecompuesto"]).Trim();
                    registro.chunidadmedidaproducto = Convert.ToString(datareader["chunidadmedidaproducto"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<productobuscado> ListaPreciosLista()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_lista_precio_listar", CommandType.StoredProcedure))
            {
                List<productobuscado> listado = new List<productobuscado>();
                while (datareader.Read())
                {
                    productobuscado registro = new productobuscado();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.chnombrecompuesto = Convert.ToString(datareader["chnombrecompuesto"]).Trim();
                    registro.chunidadmedidaproducto = Convert.ToString(datareader["chunidadmedidaproducto"]).Trim();
                    registro.nuprecio = decimal.Round(Convert.ToDecimal(datareader["nuprecio"]),2);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        //INGRESAR PRECIO A PRODUCTO
        public static int productoPrecioInsertar(productobuscado producto)
        {
            return conexion.executeScalar("fn_ProductoprecioIngresar",
            CommandType.StoredProcedure,
              new parametro("in_p_inidproducto", producto.p_inidproducto),
            new parametro("in_nuprecio", producto.nuprecio)
            );

        }
        
            public static List<productoparaventa> ProductosVentaParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_producto_buscar_venta_cabecera", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                List<productoparaventa> listado = new List<productoparaventa>();
                while (datareader.Read())
                {
                    productoparaventa registro = new productoparaventa();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.chnombrecompuesto = Convert.ToString(datareader["chnombrecompuesto"]).Trim();
                    registro.chunidadmedidaproducto = Convert.ToString(datareader["chunidadmedidaproducto"]).Trim();
                    registro.nuprecio = decimal.Round(Convert.ToDecimal(datareader["nuprecio"]), 2);
                    registro.p_inidsaldoalmancen = Convert.ToInt32(datareader["p_inidsaldoalmancen"]);
                    registro.nustockactual = Convert.ToInt32(datareader["nustockactual"]);
                    registro.req_serie = Convert.ToBoolean(datareader["req_serie"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<productoparaventa> ListaProductosVentaParametro(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_producto_buscar_venta_series", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                List<productoparaventa> listado = new List<productoparaventa>();
                while (datareader.Read())
                {
                    productoparaventa registro = new productoparaventa();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.chnombrecompuesto = Convert.ToString(datareader["chnombrecompuesto"]).Trim();
                    registro.chunidadmedidaproducto = Convert.ToString(datareader["chunidadmedidaproducto"]).Trim();
                    registro.nuprecio = decimal.Round(Convert.ToDecimal(datareader["nuprecio"]), 2);
                    registro.p_inidserie = Convert.ToInt32(datareader["p_inidserie"]);
                    registro.chserie = Convert.ToString(datareader["chserie"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<productobuscado> ListaPreciosListaParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_lista_precio_listar_parametro", CommandType.StoredProcedure,  new parametro("in_parametro", parametro)))
            {
                List<productobuscado> listado = new List<productobuscado>();
                while (datareader.Read())
                {
                    productobuscado registro = new productobuscado();
                    registro.p_inidproducto = Convert.ToInt32(datareader["p_inidproducto"]);
                    registro.chcodigoproducto = Convert.ToString(datareader["chcodigoproducto"]).Trim();
                    registro.chnombrecompuesto = Convert.ToString(datareader["chnombrecompuesto"]).Trim();
                    registro.chunidadmedidaproducto = Convert.ToString(datareader["chunidadmedidaproducto"]).Trim();
                    registro.nuprecio = decimal.Round(Convert.ToDecimal(datareader["nuprecio"]), 2);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        
    }
}
