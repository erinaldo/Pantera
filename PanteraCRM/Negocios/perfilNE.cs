using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public abstract class perfilNE
    {
        public static List<perfil> perfilListar()
        {
            return perfilDL.perfilListar();
        }
        public static int perfilInsertar(perfil perfil)
        {
            return perfilDL.perfilInsertar(perfil);
        }
        public static int perfilActualizar(perfil perfil)
        {
            return perfilDL.perfilActualizar(perfil);
        }
    }
}
