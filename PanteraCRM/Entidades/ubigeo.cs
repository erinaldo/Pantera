using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ubigeo
    {
        public string cod_ubigeo { get; set; }
        public string desc_departamento { get; set; }
        public string desc_provincia { get; set; }
        public string desc_distrito { get; set; }
        public ubigeo()
        {
            this.cod_ubigeo = string.Empty;
            this.desc_departamento = string.Empty;
            this.desc_provincia = string.Empty;
            this.desc_distrito = string.Empty;
        }
    }
}
