using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class marca
    {
        public int idmarca { get; set; }
        public string codigomarca { get; set; }
        public string nombremarca { get; set; }
        public bool estadomarca { get; set; }

        public marca()
        {
            this.idmarca = 0;
            this.codigomarca = string.Empty;
            this.nombremarca = string.Empty;
            this.estadomarca = true;
        }
    }
}
