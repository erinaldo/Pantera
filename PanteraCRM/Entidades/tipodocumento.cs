using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class tipodocumento
    {
        public int p_inidtipodocumento { get; set; }
        public string chnombredocumento { get; set; }
        public string chacrominodocumento { get; set; }
        public string chserieunica { get; set; }
        public bool boventa { get; set; }
        public bool boconta { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public tipodocumento()
        {
            this.p_inidtipodocumento = 0;
            this.chnombredocumento = string.Empty;
            this.chacrominodocumento = string.Empty;
            this.chserieunica = string.Empty;
            this.boventa = false;
            this.boconta = false;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
    }
    }
}
