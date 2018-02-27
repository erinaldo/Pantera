using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class licencia
    {
        public int  p_inidlicencia {get;set;}
        public int p_inidcliente { get; set; }
        public string chlicencia { get; set; }
        public string fechavencimiento { get; set; }
        public bool estado { get; set; }
        public licencia()
        {
            this.p_inidlicencia = 0;
            this.p_inidcliente = 0;
            this.chlicencia = string.Empty;
            this.fechavencimiento = string.Empty;
            this.estado = false;
        }
    }
}
