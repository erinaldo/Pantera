using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class notacreditocabecera
    {
        public int p_inidnotacreditoc { get; set; }
        public string chcorrelativo { get; set; }
        public string chfechanota { get; set; }
        public int p_inidpedido { get; set; }
        public int p_inidcliente { get; set; }
        public int p_iniddocreferencia { get; set; }
        public string chfechareferencia { get; set; }
        public string chobservacion { get; set; }
        public string chtiponotacredito { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public notacreditocabecera()
        {
            this.p_inidnotacreditoc = 0;
            this.chcorrelativo = string.Empty;
            this.chfechanota = string.Empty;
            this.p_inidpedido = 0;
            this.p_inidcliente = 0;
            this.p_iniddocreferencia = 0;
            this.chfechareferencia = string.Empty;
            this.chobservacion = string.Empty;
            this.chtiponotacredito = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
        }
    }
}
