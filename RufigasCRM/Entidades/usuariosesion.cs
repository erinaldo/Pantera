using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class usuariosesion
    {
        public int idusuario { get; set; }
        public string nombre { get; set; }
        public string login { get; set; }
        public int idperfil { get; set; }
        public usuariosesion()
        {
            this.idusuario = 0;
            this.nombre = string.Empty;
            this.login = string.Empty;
            this.idperfil = 0;
        }
    }
}
