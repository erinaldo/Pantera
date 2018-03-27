using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class placobd
    {
        public int p_inidplacod { get; set; }
        public int p_inidplacoc { get; set; }
        public string chcorreplacobc { get; set; }
        public string chcorrerecibo { get; set; }
        public int initem { get; set; }
        public int p_inidcliente { get; set; }
        public int p_inidtipodoc { get; set; }
        public string chcorredocumento { get; set; }
        public string chfecha { get; set; }
        public decimal nuimporpendiente { get; set; }
        public int p_inidmoneda { get; set; }
        public int p_inidmonedapag { get; set; }
        public decimal nuimporpagmonenac { get; set; }
        public decimal nuimporpagmoneext { get; set; }
        public decimal nuimporcamvta { get; set; }
        public int p_inidtipopag { get; set; }
        public string chobservacion { get; set; }
        public int p_inidtipomov { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public placobd()
        {
            this.p_inidplacod = 0;
            this.p_inidplacoc = 0;
            this.chcorreplacobc = string.Empty;
            this.chcorrerecibo = string.Empty;
            this.initem = 0;
            this.p_inidcliente = 0;
            this.p_inidtipodoc = 0;
            this.chcorredocumento = string.Empty;
            this.chfecha = string.Empty;
            this.nuimporpendiente = 0;
            this.p_inidmoneda = 0;
            this.p_inidmonedapag = 0;
            this.nuimporpagmonenac = 0;
            this.nuimporpagmoneext = 0;
            this.nuimporcamvta = 0;
            this.p_inidtipopag = 0;
            this.chobservacion = string.Empty;
            this.p_inidtipomov = 0;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
    }
    }
}
