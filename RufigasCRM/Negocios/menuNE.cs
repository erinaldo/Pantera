using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public abstract class menuNE
    {
        public static List<menu> obtieneEstructura()
        {
            try
            {
                return usuariomenuDL.obtieneEstructura();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
