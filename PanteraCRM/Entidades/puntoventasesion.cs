using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class puntoventasesion
    {
        public int idpuntoventa { get; set; }
        public string prefijopresupuesto { get; set; }
        public string prefijofactura { get; set; }
        public puntoventasesion()
        {
            this.idpuntoventa = 0;
            this.prefijopresupuesto = string.Empty;
            this.prefijofactura = string.Empty;
        }
    }
}