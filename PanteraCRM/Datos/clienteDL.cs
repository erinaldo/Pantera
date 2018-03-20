using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class clienteDL
    {
        public static List<cliente> clienteListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_cliente_listar", CommandType.StoredProcedure))
            {
                List<cliente> listado = new List<cliente>();
                while (datareader.Read())
                {
                    cliente registro = new cliente();
                    registro.p_inidcodigoclie = Convert.ToInt32(datareader["p_inidcodigoclie"]);
                    registro.chcodigo = Convert.ToString(datareader["chcodigo"]).Trim();
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
        public static List<cliente> ClienteListarParametro2(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_cliente_listar_parametro2", CommandType.StoredProcedure, new parametro ("in_parametro", parametro)))
            {
                List<cliente> listado = new List<cliente>();
                while (datareader.Read())
                {
                    cliente registro = new cliente();
                    registro.p_inidcodigoclie = Convert.ToInt32(datareader["p_inidcodigoclie"]);
                    registro.chcodigo = Convert.ToString(datareader["chcodigo"]).Trim();
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
        
        public static List<clientebusqueda> ClienteListarParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_cliente_listar_parametro", CommandType.StoredProcedure,
                new parametro("in_parametro", parametro)))
            {
                List<clientebusqueda> listado = new List<clientebusqueda>();
                while (datareader.Read())
                {
                    clientebusqueda registro = new clientebusqueda();
                    registro.p_inidcodigoclie = Convert.ToInt32(datareader["p_inidcodigoclie"]);
                    registro.chcodigocliente = Convert.ToString(datareader["chcodigocliente"]).Trim();
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
        public static Mcliente ClienteBusquedaCodigo(int codigo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_cliente_buqueda_codigo", CommandType.StoredProcedure,
                new parametro("in_p_inidcliente", codigo)))
            {
                Mcliente registro = new Mcliente();
                while (datareader.Read())
                {
                    registro.p_inidcliente = Convert.ToInt32(datareader["p_inidcliente"]);
                    registro.chdireccionenvio = Convert.ToString(datareader["chdireccionenvio"]).Trim();
                    registro.p_inidtipovia = Convert.ToInt32(datareader["p_inidtipovia"]);
                    registro.chnombrevia = Convert.ToString(datareader["chnombrevia"]).Trim();
                    registro.chnumero = Convert.ToString(datareader["chnumero"]).Trim();
                    registro.chnumerointerior = Convert.ToString(datareader["chnumerointerior"]).Trim();
                    registro.p_inidtipozona = Convert.ToInt32(datareader["p_inidtipozona"]);
                    registro.chnombrezona = Convert.ToString(datareader["chnombrezona"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.chtelefono2 = Convert.ToString(datareader["chtelefono2"]).Trim();
                    registro.chtelefono3 = Convert.ToString(datareader["chtelefono3"]).Trim();
                    registro.inlimitecredito = Convert.ToInt32(datareader["inlimitecredito"]);
                    registro.p_inidpais = Convert.ToInt32(datareader["p_inidpais"]);
                    registro.chcodigocliente = Convert.ToString(datareader["chcodigocliente"]).Trim();
                    registro.p_inidtipocliente = Convert.ToInt32(datareader["p_inidtipocliente"]);
                    registro.p_inidjurinat = Convert.ToInt32(datareader["p_inidjurinat"]);

                }
                return registro;
            }
        }
        public static Mclientejuridico ClienteJuridicoBusquedaCodigo(int codigo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_clientejuridico_buqueda_codigo", CommandType.StoredProcedure,
                new parametro("in_p_inidcliente", codigo)))
            {
                Mclientejuridico registro = new Mclientejuridico();
                while (datareader.Read())
                {
                    registro.p_inidclientejuridico = Convert.ToInt32(datareader["p_inidclientejuridico"]);
                    registro.p_inidcliente = Convert.ToInt32(datareader["p_inidcliente"]);
                    registro.p_inidempresa = Convert.ToInt32(datareader["p_inidempresa"]);                  

                }
                return registro;
            }
        }
        public static Mclientenatural ClienteNaturalBusquedaCodigo(int codigo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_clientenatural_buqueda_codigo", CommandType.StoredProcedure,
                new parametro("in_p_inidcliente", codigo)))
            {
                Mclientenatural registro = new Mclientenatural();
                while (datareader.Read())
                {

                    registro.p_inidclientenatural = Convert.ToInt32(datareader["p_inidclientenatural"]);
                    registro.p_inidcliente = Convert.ToInt32(datareader["p_inidcliente"]);
                    registro.p_inidpersona = Convert.ToInt32(datareader["p_inidpersona"]);

                }
                return registro;
            }
        }
        public static List<licencia> LicenciaBusquedaCodigo(int codigo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_licencia_buqueda_codigo", CommandType.StoredProcedure,
                new parametro("in_p_inidcliente", codigo)))
            {
                List<licencia> listado = new List<licencia>();
                while (datareader.Read())
                {
                    licencia registro = new licencia();
                    registro.p_inidlicencia = Convert.ToInt32(datareader["p_inidlicencia"]);
                    registro.p_inidcliente = Convert.ToInt32(datareader["p_inidcliente"]);
                    registro.chlicencia = Convert.ToString(datareader["chlicencia"]).Trim();
                    registro.fechavencimiento = Convert.ToString(datareader["chfechavencimiento"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static List<tarjetapropiedad> TarjetaPropiedadBusquedaCodigo(int codigo)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_tarjeta_buqueda_codigo", CommandType.StoredProcedure,
                new parametro("in_p_inidcliente", codigo)))
            {
                List<tarjetapropiedad> listado = new List<tarjetapropiedad>();
                while (datareader.Read())
                {
                    tarjetapropiedad registro = new tarjetapropiedad();
                    registro.p_inidtarjeta = Convert.ToInt32(datareader["p_inidtarjeta"]);
                    registro.p_inidcliente = Convert.ToInt32(datareader["p_inidcliente"]);
                    registro.chtarjeta = Convert.ToString(datareader["chtarjeta"]).Trim();
                    registro.fechavencimiento = Convert.ToString(datareader["fechavencimiento"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);                    
                    listado.Add(registro);
                }
                return listado;
            }
        }

        public static List<clientebusqueda> ClienteBusquedaParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_cliente_busqueda_parametro", CommandType.StoredProcedure,
                new parametro("in_parametro", parametro)))
            {
                List<clientebusqueda> listado = new List<clientebusqueda>();
                while (datareader.Read())
                {
                    clientebusqueda registro = new clientebusqueda();
                    registro.p_inidcodigoclie = Convert.ToInt32(datareader["p_inidcodigoclie"]);
                    registro.chcodigocliente = Convert.ToString(datareader["chcodigocliente"]).Trim();
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
        public static clientebusqueda ClienteBusquedaCodigoSecundario(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_cliente_busqueda_codigo_secundario", CommandType.StoredProcedure,
                new parametro("in_chcodigocliente", parametro)))
            {
                clientebusqueda registro = new clientebusqueda();
                while (datareader.Read())
                {
                    registro.p_inidcodigoclie = Convert.ToInt32(datareader["p_inidcodigoclie"]);
                    registro.chcodigocliente = Convert.ToString(datareader["chcodigocliente"]).Trim();
                    registro.razon = Convert.ToString(datareader["razon"]).Trim();
                    registro.tipodocu = Convert.ToString(datareader["tipodocu"]).Trim();
                    registro.nrodocumento = Convert.ToString(datareader["nrodocumento"]).Trim();
                    registro.chdireccion = Convert.ToString(datareader["chdireccion"]).Trim();
                    registro.tipoclie = Convert.ToString(datareader["tipoclie"]).Trim();
                    registro.telefono = Convert.ToString(datareader["telefono"]).Trim();
                }
                return registro;
            }
        }
        public static int ClienteIngresar(Mcliente registros)
        {
            return conexion.executeScalar("fn_cliente_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_chdireccionenvio", registros.chdireccionenvio ),
            new parametro("in_p_inidtipovia", registros.p_inidtipovia),
            new parametro("in_chnombrevia", registros.chnombrevia),
            new parametro("in_chnumero", registros.chnumero),
            new parametro("in_chnumerointerior", registros.chnumerointerior),
            new parametro("in_p_inidtipozona", registros.p_inidtipozona),
            new parametro("in_chnombrezona", registros.chnombrezona),
            new parametro("in_estado", registros.estado),
            new parametro("in_chtelefono2", registros.chtelefono2),
            new parametro("in_chtelefono3", registros.chtelefono3),
            new parametro("in_p_inidpais", registros.p_inidpais),
            new parametro("in_p_inidjurinat", registros.p_inidjurinat),
            new parametro("in_p_inidtipocliente", registros.p_inidtipocliente)
                );

        }
        public static int ClienteModificar(Mcliente registros)
        {
            return conexion.executeScalar("fn_cliente_modificar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidcliente", registros.p_inidcliente),
            new parametro("in_chdireccionenvio", registros.chdireccionenvio),
            new parametro("in_p_inidtipovia", registros.p_inidtipovia),
            new parametro("in_chnombrevia", registros.chnombrevia),
            new parametro("in_chnumero", registros.chnumero),
            new parametro("in_chnumerointerior", registros.chnumerointerior),
            new parametro("in_p_inidtipozona", registros.p_inidtipozona),
            new parametro("in_chnombrezona", registros.chnombrezona),
            new parametro("in_estado", registros.estado),
            new parametro("in_chtelefono2", registros.chtelefono2),
            new parametro("in_chtelefono3", registros.chtelefono3),
            new parametro("in_p_inidpais", registros.p_inidpais),
            new parametro("in_p_inidjurinat", registros.p_inidjurinat),
            new parametro("in_p_inidtipocliente", registros.p_inidtipocliente)
                );

        }
        public static int ClienteJuridicoIngresar(Mclientejuridico registros)
        {
            return conexion.executeScalar("fn_clientejuridico_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidcliente", registros.p_inidcliente),
            new parametro("in_p_inidempresa", registros.p_inidempresa));

        }
        public static int ClienteNaturalIngresar(Mclientenatural registros)
        {
            return conexion.executeScalar("fn_clientenatural_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidcliente", registros.p_inidcliente),
            new parametro("in_p_inidpersona", registros.p_inidpersona));

        }
        public static int ClienteJuridicoModificar(Mclientejuridico registros)
        {
            return conexion.executeScalar("fn_clientejuridico_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidcliente", registros.p_inidclientejuridico),
            new parametro("in_p_inidcliente", registros.p_inidcliente),
            new parametro("in_p_inidempresa", registros.p_inidempresa));

        }
        public static int ClienteNaturalModificar(Mclientenatural registros)
        {
            return conexion.executeScalar("fn_clientenatural_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidcliente", registros.p_inidclientenatural),
            new parametro("in_p_inidcliente", registros.p_inidcliente),
            new parametro("in_p_inidpersona", registros.p_inidpersona));

        }
        public static int LicenciaIngresar(licencia registros)
        {
            return conexion.executeScalar("fn_licencia_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidcliente", registros.p_inidcliente),
            new parametro("in_chnumerolicencia", registros.chlicencia),
            new parametro("in_chfechavencimiento", registros.fechavencimiento),
            new parametro("in_estado", registros.estado));

        }
        public static int LicenciaModificar(licencia registros)
        {
            return conexion.executeScalar("fn_licencia_modificar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidlicencia", registros.p_inidlicencia),
            new parametro("in_p_inidcliente", registros.p_inidcliente),
            new parametro("in_chnumerolicencia", registros.chlicencia),
            new parametro("in_chfechavencimiento", registros.fechavencimiento),
            new parametro("in_estado", registros.estado));

        }
        
        public static int TarjetaIngresar(tarjetapropiedad registros)
        {
            return conexion.executeScalar("fn_tarjeta_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidcliente", registros.p_inidcliente),
            new parametro("in_chtarjeta", registros.chtarjeta),
            new parametro("in_fechavencimiento", registros.fechavencimiento ),
            new parametro("in_estado", registros.estado ));

        }
        public static int TarjetaFalsear(int registros)
        {
            return conexion.executeScalar("fn_tarjeta_falsear",
            CommandType.StoredProcedure,
            new parametro("in_p_inidtarjeta", registros));

        }
        public static int LicenciaFalsear(int registros)
        {
            return conexion.executeScalar("fn_licencia_falsear",
            CommandType.StoredProcedure,
            new parametro("in_p_inidlicencia", registros));

        }
        
    }
}
