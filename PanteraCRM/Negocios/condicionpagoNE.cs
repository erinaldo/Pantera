using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class condicionpagoNE
    {
        public static List<condicionpago> ListaCondicionPago()
        {
            return condicionpagoDL.ListaCondicionPago();
        }
    }
}
