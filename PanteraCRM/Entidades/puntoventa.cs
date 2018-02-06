using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class puntoventa
    {
        public int idpuntoventa { get; set; }
        public int idempresa { get; set; }
        public int idalmacen { get; set; }
        public string nombrepuntaventa { get; set; }
        public string prefijopresupuesto { get; set; }
        public int numeropresupuesto { get; set; }
        public string prefijofactura { get; set; }
        public int numerofactura { get; set; }
        public string situacionpuntoventa { get; set; }
        public bool estadopuntoventa { get; set; }
        public puntoventa()
        {
            this.idpuntoventa = 0;
            this.idempresa = 0;
            this.idalmacen = 0;
            this.nombrepuntaventa = string.Empty;
            this.prefijopresupuesto = string.Empty;
            this.numeropresupuesto = 0;
            this.prefijofactura = string.Empty;
            this.numerofactura= 0;
            this.situacionpuntoventa= string.Empty;
            this.estadopuntoventa = true;
        }
    }
}
