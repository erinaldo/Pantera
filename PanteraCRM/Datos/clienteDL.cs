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
        public static int LicenciaIngresar(licencia registros)
        {
            return conexion.executeScalar("fn_licencia_ingresar",
            CommandType.StoredProcedure,
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
    }
}
