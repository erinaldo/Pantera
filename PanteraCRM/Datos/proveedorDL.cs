using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
namespace Datos
{
    public class proveedorDL
    {
        public static List<proveedor> proveedorListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_proveedor_listar", CommandType.StoredProcedure))
            {
                List<proveedor> listado = new List<proveedor>();
                while (datareader.Read())
                {
                    proveedor registro = new proveedor();
                    registro.p_inidcodigoclie = Convert.ToInt32(datareader["p_inidcodigoclie"]);
                    registro.razon = Convert.ToString(datareader["razon"]).Trim();
                    registro.tipodocu = Convert.ToString(datareader["tipodocu"]).Trim();
                    registro.nrodocumento = Convert.ToString(datareader["nrodocumento"]).Trim();
                    registro.chdireccion = Convert.ToString(datareader["chdireccion"]).Trim();
                    registro.tipoclie = Convert.ToString(datareader["tipoclie"]).Trim();
                    registro.telefono = Convert.ToString(datareader["telefono"]).Trim();
                    registro.chcodigoproveedor = Convert.ToString(datareader["chcodigoproveedor"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<proveedor> ProveedorListarParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_proveedor_listar_parametro", CommandType.StoredProcedure, new parametro ("in_parametro",parametro)))
            {
                List<proveedor> listado = new List<proveedor>();
                while (datareader.Read())
                {
                    proveedor registro = new proveedor();
                    registro.p_inidcodigoclie = Convert.ToInt32(datareader["p_inidcodigoclie"]);
                    registro.razon = Convert.ToString(datareader["razon"]).Trim();
                    registro.tipodocu = Convert.ToString(datareader["tipodocu"]).Trim();
                    registro.nrodocumento = Convert.ToString(datareader["nrodocumento"]).Trim();
                    registro.chdireccion = Convert.ToString(datareader["chdireccion"]).Trim();
                    registro.tipoclie = Convert.ToString(datareader["tipoclie"]).Trim();
                    registro.telefono = Convert.ToString(datareader["telefono"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        
        public static int ProveedorIngresar(proveedores registros)
        {
            return conexion.executeScalar("fn_proveedor_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inactividad", registros.p_inactividad),            
            new parametro("in_p_incodzona", registros.p_incodzona),
            new parametro("in_chnombrezona", registros.chnombrezona),
            new parametro("in_chtelefono2", registros.chtelefono1),
            new parametro("in_chtelefono3", registros.chtelefono2),
            new parametro("in_p_incodpais", registros.p_incodpais),
            new parametro("in_estado", registros.estado),
            new parametro("in_p_inidtipovia", registros.p_inidtipovia),
            new parametro("in_chtipovia", registros.chtipovia),
            new parametro("in_chnumero", registros.chnumero),
            new parametro("in_chinterior", registros.chinterior));

        }
        public static int ProveedorModificar(proveedores registros)
        {
            return conexion.executeScalar("fn_proveedor_modificar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidproveedor", registros.p_inidproveedor),
            new parametro("in_p_inactividad", registros.p_inactividad),
            new parametro("in_p_incodzona", registros.p_incodzona),
            new parametro("in_chnombrezona", registros.chnombrezona),
            new parametro("in_chtelefono2", registros.chtelefono1),
            new parametro("in_chtelefono3", registros.chtelefono2),
            new parametro("in_p_incodpais", registros.p_incodpais),
            new parametro("in_estado", registros.estado),
            new parametro("in_p_inidtipovia", registros.p_inidtipovia),
            new parametro("in_chtipovia", registros.chtipovia),
            new parametro("in_chnumero", registros.chnumero),
            new parametro("in_chinterior", registros.chinterior));

        }
        
        public static List<proveedor> ProveedorBusquedaParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_proveedor_busqueda_parametro", CommandType.StoredProcedure,
                 new parametro("in_parametro", parametro)))
            {
                List<proveedor> listado = new List<proveedor>();
                while (datareader.Read())
                {
                    proveedor registro = new proveedor();
                    registro.p_inidcodigoclie = Convert.ToInt32(datareader["p_inidcodigoclie"]);
                    registro.razon = Convert.ToString(datareader["razon"]).Trim();
                    registro.tipodocu = Convert.ToString(datareader["tipodocu"]).Trim();
                    registro.nrodocumento = Convert.ToString(datareader["nrodocumento"]).Trim();
                    registro.chdireccion = Convert.ToString(datareader["chdireccion"]).Trim();
                    registro.tipoclie = Convert.ToString(datareader["tipoclie"]).Trim();
                    registro.telefono = Convert.ToString(datareader["telefono"]).Trim();
                    registro.chcodigoproveedor = Convert.ToString(datareader["chcodigoproveedor"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static proveedores ProveedorBusquedaCodigo(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_proveedor_busqueda_codigo2", CommandType.StoredProcedure,
                 new parametro("in_p_inidproveedor", parametro)))
            {
                proveedores registro = new proveedores();
                while (datareader.Read())
                {
                    registro.p_inidproveedor = Convert.ToInt32(datareader["p_inidproveedor"]);
                    registro.p_inactividad = Convert.ToInt32(datareader["p_inactividad"]);
                    registro.p_incodzona = Convert.ToInt32(datareader["p_incodzona"]);
                    registro.chnombrezona = Convert.ToString(datareader["chnombrezona"]).Trim();
                    registro.chtelefono1 = Convert.ToString(datareader["chtelefono1"]).Trim();
                    registro.chtelefono2 = Convert.ToString(datareader["chtelefono2"]).Trim();
                    registro.p_incodpais = Convert.ToInt32(datareader["p_incodpais"]);
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.chcodigoproveedor = Convert.ToString(datareader["chcodigoproveedor"]).Trim();
                    registro.p_inidtipovia = Convert.ToInt32(datareader["p_inidtipovia"]);
                    registro.chtipovia = Convert.ToString(datareader["chtipovia"]).Trim();
                    registro.chnumero = Convert.ToString(datareader["chnumero"]).Trim();
                    registro.chinterior = Convert.ToString(datareader["chinterior"]).Trim();
                    
                }
                return registro;
            }
        }
        public static proveedorjuridico ProveedorJuridicoBusqueda(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_proveedorjuridico_busqueda_codigo", CommandType.StoredProcedure,
                 new parametro("in_p_inidproveedor", parametro)))
            {
                proveedorjuridico registro = new proveedorjuridico();
                while (datareader.Read())
                {
                    registro.p_inidproveedorjuridico = Convert.ToInt32(datareader["p_inidproveedorjuridico"]);
                    registro.p_inidempresa = Convert.ToInt32(datareader["p_inidempresa"]);
                    registro.p_inidproveedor = Convert.ToInt32(datareader["p_inidproveedor"]);
                    
                }
                return registro;
            }
        }
        

        public static proveedor ProveedorBusquedaRuc(string ruc)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_proveedor_busqueda_codigo3",
            CommandType.StoredProcedure, new parametro("in_chcodigoproveedor", ruc)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }

        private static proveedor convertirRegistro(IDataReader datareader)
        {
            proveedor registro = new proveedor();
            registro.p_inidcodigoclie = Convert.ToInt32(datareader["p_inidcodigoclie"]);
            registro.razon = Convert.ToString(datareader["razon"]).Trim();
            registro.tipodocu = Convert.ToString(datareader["tipodocu"]).Trim();
            registro.nrodocumento = Convert.ToString(datareader["nrodocumento"]).Trim();
            registro.chdireccion = Convert.ToString(datareader["chdireccion"]).Trim();
            registro.tipoclie = Convert.ToString(datareader["tipoclie"]).Trim();
            registro.telefono = Convert.ToString(datareader["telefono"]).Trim();
            registro.chcodigoproveedor = Convert.ToString(datareader["chcodigoproveedor"]).Trim();
            return registro;
        }
        public static string BuscarProveedorPorCodigo(int codigo)
        {
            return conexion.executeScalarStr("fn_proveedor_busqueda_codigo", CommandType.StoredProcedure, new parametro("in_p_inidcodigo", codigo));
        }



    }
}
