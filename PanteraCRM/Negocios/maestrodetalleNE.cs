using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public abstract class maestrodetalleNE
    {
        public static List<maestrodetalle> buscarPorCodigoMaestro(int codigomaestro)
        {
            return maestrodetalleDL.buscarPorCodigoMaestro(codigomaestro);
        }
        public static List<categoria> ListarCategorias()
        {
            return maestrodetalleDL.ListarCategorias();
        }
        public static List<tipo> buscarTipoPorCategoria(string codigomaestro)
        {
            return maestrodetalleDL.buscarTipoPorCategoria(codigomaestro);
        }
        public static List<maestrocabecera> MaestroCabeceraListar()
        {
            return maestrodetalleDL.MaestroCabeceraListar();
        }
        public static List<maestrocabecera> MaestroCabeceraListarParametro(string parametro)
        {
            return maestrodetalleDL.MaestroCabeceraListarParametro(parametro);
        }
        
    }
}
