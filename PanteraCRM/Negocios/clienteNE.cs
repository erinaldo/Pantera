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
    }
}
