using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public abstract class perfildetalleNE
    {
        public static List<perfildetalle> perfildetalleListar(int idperfil)
        {
            return perfildetalleDL.perfildetalleListar(idperfil);
        }
        public static int perfildetalleInsertar(int idperfil, perfildetalle perfildetalle)
        {
            return perfildetalleDL.perfildetalleInsertar(idperfil, perfildetalle);
        }
        public static int perfildetalleEliminar(int idperfil)
        {
            return perfildetalleDL.perfildetalleEliminar(idperfil);
        }
        public static int validarModulo(int idperfil, int idmenu)
        {
            return perfildetalleDL.validarModulo(idperfil, idmenu);
        }
    }
}
