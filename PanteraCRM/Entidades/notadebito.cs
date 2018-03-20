using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class notadebito
    {
        public int p_inidnotadebito { get; set; }
        public string chcorrelativo { get; set; }
        public string chfecha { get; set; }
        public int p_inidcliente { get; set; }
        public int p_iniddocreferencia { get; set; }
        public string chfechareferencia { get; set; }
        public int p_inidsituacionnota { get; set; }
        public string chobservacion { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public notadebito()
        {
            this.p_inidnotadebito = 0;
            this.chcorrelativo = string.Empty;
            this.chfecha = string.Empty;
            this.p_inidcliente = 0;
            this.p_iniddocreferencia = 0;
            this.chfechareferencia = string.Empty;
            this.p_inidsituacionnota = 0;
            this.chobservacion = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
    }
    }
}
