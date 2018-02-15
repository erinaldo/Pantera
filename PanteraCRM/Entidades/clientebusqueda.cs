using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clientebusqueda
    {
        public int p_inidcliente { get; set; }
        public string chcodigocliente { get; set; }
        public string chnombrecliente { get; set; }
        public string chtipodocumento { get; set; }
        public string chnumerodocumento { get; set; }
        public string chdirecionfiscal { get; set; }
        public clientebusqueda()
        {
            this.p_inidcliente = 0;
            this.chcodigocliente = string.Empty;
            this.chnombrecliente = string.Empty;
            this.chtipodocumento = string.Empty;
            this.chnumerodocumento = string.Empty;
            this.chdirecionfiscal = string.Empty;

    }
    }
}
