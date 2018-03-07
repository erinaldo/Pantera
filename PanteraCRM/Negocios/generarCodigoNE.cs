using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class generarCodigoNE
    {
        public static string ObtenerUltimoCodigoPedido(int parametro)
        {
            return generarCodigoDL.ObtegerUltimocodigoPedido(parametro);
        }
        public static int ObtenerTipoCambio(string parametro)
        {
            return generarCodigoDL.ObetenertipoCambio(parametro);
        }
    }
}
