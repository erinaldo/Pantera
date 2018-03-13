using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class tipomovimiento
    {
        public int p_inidtipomovimiento { get; set; }
        public int p_inidmovimiento { get; set; }
        public string chnombremovimiento { get; set; }
        public string chnref1 { get; set; }
        public string chtipref1 { get; set; }
        public string chnref2 { get; set; }
        public string chtipref2 { get; set; }
        public string chnref3 { get; set; }
        public string chtipref3 { get; set; }
        public string chnref4 { get; set; }
        public string chtipref4 { get; set; }
        public string chnref5 { get; set; }
        public string chtipref5 { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public tipomovimiento()
        {
            this.p_inidtipomovimiento = 0;
            this.p_inidmovimiento = 0;
            this.chnombremovimiento = string.Empty;
            this.chnref1 = string.Empty;
            this.chtipref1 = string.Empty;
            this.chnref2 = string.Empty;
            this.chtipref2 = string.Empty;
            this.chnref3 = string.Empty;
            this.chtipref3 = string.Empty;
            this.chnref4 = string.Empty;
            this.chtipref4 = string.Empty;
            this.chnref5 = string.Empty;
            this.chtipref5 = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
    }
    }
}
