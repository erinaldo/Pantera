using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class pedidoNE
    {
        public static int IngresoPedidoCabecera(pedidocabecera registros)
        {
            return pedidoDL.IngresoPedidoCabecera(registros);
        }
        public static int IngresoPedidoDetalle(pedidodetalle listado)
        {
            return pedidoDL.IngresoPedidoDetalle(listado);
        }
    }
}
