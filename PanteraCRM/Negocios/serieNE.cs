using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Negocios
{
    public abstract class serieNE
    {
        public static bool verificarExistencia(string parametro)
        {
            return serieDL.verificarExistencias(parametro) ;
        }
        public static int seriesIngresar(serie serie)
        {
            return serieDL.seriesIngresar(serie);
        }
    }
}
