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



    }
}
