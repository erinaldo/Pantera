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
    }
}
