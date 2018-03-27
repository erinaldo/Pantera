using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class placobc
    {
        public int p_inidplacoc { get; set; }
        public string chcorreplacobc { get; set; }
        public string chfecha { get; set; }
        public decimal nuimporplamonenac { get; set; }
        public decimal nuimporplanomeex { get; set; }
        public string chreferencia { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public placobc()
        {
            this.p_inidplacoc = 0;
            this.chcorreplacobc = string.Empty;
            this.chfecha = string.Empty;
            this.nuimporplamonenac = 0;
            this.nuimporplanomeex = 0;
            this.chreferencia = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
        }
    }
}
