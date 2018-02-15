using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class transportista
    {
        public int p_inidtransportista { get; set; }
        public string chnombretransportista { get; set; }
        public string chnombrecomercial { get; set; }
        public string chruc { get; set; }
        public string chdireccionfiscal { get; set; }
        public transportista()
        {
            this.p_inidtransportista = 0;
            this.chnombrecomercial = string.Empty;
            this.chnombretransportista = string.Empty;
            this.chruc = string.Empty;
            this.chdireccionfiscal = string.Empty;
        }
    }
}
