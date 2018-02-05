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
    }
}
