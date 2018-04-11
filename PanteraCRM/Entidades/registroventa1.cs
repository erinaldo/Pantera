using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class registroventa1
    {
         public string  chfechadoc { get; set; }
        public string chnombredocumento { get; set; }
        public string chcodigodocu { get; set; }
        public decimal nuimportetotvta { get; set; }
        public decimal nuimporvtaafecta { get; set; }
        public decimal nuimporttotigv { get; set; }
        public string chcodigocliente { get; set; }
        public string tipodocu { get; set; }
        public string nrodocumento { get; set; }
        public string razon { get; set; }

        public registroventa1()
        {
            this.chfechadoc = string.Empty;
            this.chnombredocumento = string.Empty;
            this.chcodigodocu = string.Empty;
            this.nuimportetotvta = 0;
            this.nuimporvtaafecta = 0;
            this.nuimporttotigv = 0;
            this.chcodigocliente = string.Empty;
            this.tipodocu = string.Empty;
            this.nrodocumento = string.Empty;
            this.razon = string.Empty;
        }
                
    }
}
