using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class persona
    {
        public int idpersona { get; set; }
        public string dni { get; set; }
        public string ubigeo { get; set; }
        public string ape_paterno { get; set; }
        public string ape_materno { get; set; }
        public string nombres { get; set; }
        public string fecha_nac { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public persona()
            {
            this.idpersona = 0;
            this.dni = string.Empty;
            this.ubigeo = string.Empty;
            this.ape_paterno = string.Empty;
            this.ape_materno = string.Empty;
            this.nombres = string.Empty;
            this.fecha_nac = string.Empty;
            this.sexo = string.Empty;
            this.telefono = string.Empty;
            this.direccion = string.Empty;
        }
    }
}
