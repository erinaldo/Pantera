using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class perfil
    {
        
        public int idperfil { get; set; }
        public string descripcion { get; set; }
        public string comentarioperfil { get; set; }
        public bool estadoperfil { get; set; }

        public perfil()
        {
            this.idperfil = 0;
            this.descripcion = string.Empty;
            this.comentarioperfil = string.Empty;
            this.estadoperfil = true;
        }
    }
}
