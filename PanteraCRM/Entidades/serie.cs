using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class serie
    {
        public int p_inidserie { get; set; }
        public string chcodigoserie { get; set; }
        public bool estado { get; set; }
        public int p_inidproducto { get; set; }
        public string chadicional { get; set; }
        public string chfecha { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public int p_inidmovimientod { get; set; }
        public int p_inidpedidod{ get; set; }

        public serie()
        {
            this.p_inidserie = 0;
            this.chcodigoserie = string.Empty;
            this.estado = false;
            this.p_inidproducto = 0;
            this.chadicional = string.Empty;
            this.chfecha = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.p_inidmovimientod = 0;
            this.p_inidpedidod = 0;
    }
    }
}
