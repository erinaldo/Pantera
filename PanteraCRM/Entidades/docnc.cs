using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class docnc
    {
        public int p_iniddocnc { get; set; }
        public string chcorreladoc { get; set; }
        public string chfechacancel { get; set; }
        public int p_inidnotacredito { get; set; }
        public string chcorrelanota { get; set; }
        public string chfechanota { get; set; }
        public int p_inidmoneda { get; set; }
        public decimal nuimporcancela { get; set; }
        public int p_inidsituacion { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public docnc()
        {
            this.p_iniddocnc = 0;
            this.chcorreladoc = string.Empty;
            this.chfechacancel = string.Empty;
            this.p_inidnotacredito = 0;
            this.chcorrelanota = string.Empty;
            this.chfechanota = string.Empty;
            this.p_inidmoneda = 0;
            this.nuimporcancela = 0;
            this.p_inidsituacion = 0;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;

    }
}
}
