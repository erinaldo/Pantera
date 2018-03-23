using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class banco
    {
        public int p_inidbanco { get; set; }
        public string chnombrebanco { get; set; }
        public string chtipocuenbanco { get; set; }
        public string chcuentaban { get; set; }
        public string chcuentacon { get; set; }
        public string chcuentqamon { get; set; }
        public string chcuentatel { get; set; }
        public string chnomsec { get; set; }
        public int chusuarioinsert { get; set; }
        public int chusuariodelete { get; set; }
        public bool estado { get; set; }
        public banco()
        {
            this.p_inidbanco = 0;
            this.chnombrebanco = string.Empty;
            this.chtipocuenbanco = string.Empty;
            this.chcuentaban = string.Empty;
            this.chcuentacon = string.Empty;
            this.chcuentqamon = string.Empty;
            this.chcuentatel = string.Empty;
            this.chnomsec = string.Empty;
            this.chusuarioinsert = 0;
            this.chusuariodelete = 0;
            this.estado = false;
    }
    }
}
