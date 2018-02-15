using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class condicionpago
    {
        public int p_inidcondicionpago { get; set; }
        public string chnombrepago { get; set; }
        public int incantidaddias { get; set; }
        public int incantidaddiasaplasa { get; set; }
        public decimal nucantidadporcentajedesc { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public condicionpago()
        {
            this.p_inidcondicionpago = 0;
            this.chnombrepago = string.Empty;
            this.incantidaddias = 0;
            this.incantidaddiasaplasa = 0;
            this.nucantidadporcentajedesc = 0;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
    }

    }
}
