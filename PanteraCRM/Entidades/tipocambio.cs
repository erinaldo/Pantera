using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class tipocambio
    {
        public int p_inidtipocambio { get; set; }
        public string chfechacambio { get; set; }
        public int p_inidmoneda { get; set; }
        public decimal nucambiocompra { get; set; }
        public decimal nucambioventa { get; set; }
        public decimal nucambiopon { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete  { get;set; }
        public bool   estado { get; set; }
        public tipocambio()
        {
            this.p_inidtipocambio = 0;
            this.chfechacambio = string.Empty;
            this.p_inidmoneda = 0;
            this.nucambiocompra = 0;
            this.nucambioventa = 0;
            this.nucambiopon =0;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
        }
    }
}
