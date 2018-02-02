using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class modelo
    {
        public int idmodelo { get; set; }
        public string codigomodelo { get; set; }
        public string nombremodelo { get; set; }
        public int idmarca { get; set; }
        public string nombremarca { get; set; }
        public bool estadomodelo { get; set; }

        public modelo()
        {
            this.idmarca = 0;
            this.codigomodelo = string.Empty;
            this.nombremodelo = string.Empty;
            this.idmarca = 0;
            this.nombremarca = string.Empty;
            this.estadomodelo = true;
        }
    }
}
