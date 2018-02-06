using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class usuario
    {
        public int idusuario { get; set; }
        public string nombre { get; set; }
        public string login { get; set; }
        public string clave { get; set; }
        public bool estadousuario { get; set; }
        public int idperfil { get; set; }
        public string descripcion { get; set; }
        public usuario()
        {
            this.idusuario = 0;
            this.nombre = string.Empty;
            this.login = string.Empty;
            this.clave = string.Empty;
            this.estadousuario = true;
            this.idperfil = 0;
            this.descripcion = string.Empty;
        }
    }
}
