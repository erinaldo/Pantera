using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class clienteNE
    {
        public static List<cliente> clienteListar()
        {
            return clienteDL.clienteListar();
        }
        public static List<clientebusqueda> ClienteListarParametro(string parametro)
        {
            return clienteDL.ClienteListarParametro(parametro);
        }
        public static List<clientebusqueda> ClienteBusquedaParametro(string parametro)
        {
            return clienteDL.ClienteBusquedaParametro(parametro);
        }
        public static int ClienteIngresar(Mcliente registros)
        {
            return clienteDL.ClienteIngresar(registros);
        }
        public static int ClienteJuridicoIngresar(Mclientejuridico registros)
        {
            return clienteDL.ClienteJuridicoIngresar(registros);
        }
        public static int ClienteNaturalIngresar(Mclientenatural registros)
        {
            return clienteDL.ClienteNaturalIngresar(registros);
        }
        public static int LicenciaIngresar(licencia registros)
        {
            return clienteDL.LicenciaIngresar(registros);
        }
        public static int TarjetaIngresar(tarjetapropiedad registros)
        {
            return clienteDL.TarjetaIngresar(registros);
        }
    }
}
