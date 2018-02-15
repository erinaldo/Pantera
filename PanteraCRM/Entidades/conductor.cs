using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class conductor
    {
        public int p_inidtransportista { get; set; }
        public int p_inidcoductor { get; set; }
        public string chnombreconductor { get; set; }
        public string chbrevete { get; set; }
        public bool estado { get; set; }
        public conductor()
        {
            this.p_inidtransportista = 0;
            this.p_inidcoductor = 0;
            this.chnombreconductor = string.Empty;
            this.chbrevete = string.Empty;
            this.estado = false;
    }
    }
}
