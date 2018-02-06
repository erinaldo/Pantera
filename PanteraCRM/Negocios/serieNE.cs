using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocios
{
    public abstract class serieNE
    {
        public static bool verificarExistencia(string parametro)
        {
            return serieDL.verificarExistencias(parametro) ;
        }
    }
}
