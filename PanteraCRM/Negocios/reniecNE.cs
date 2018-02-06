using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public abstract class reniecNE
    {
        public static persona buscaPorDNI(string dni)
        {
            try
            {
                return reniecDL.buscarPorDNI(dni);
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
