using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocios
{
    public abstract class tipocambioNE
    {
        public static int IngresarTipoCambio(tipocambio registro)
        {
            return tipocambioDL.TipocambioIngresar(registro);
        }
        public static List<tipocambio> busquedaValorTipoCambio(string parametro)
        {
            return tipocambioDL.busquedaValorTipoCambio(parametro);
        }
    }
}
