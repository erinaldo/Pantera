using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class kardexdetalle
    {
        public string chfechamovi { get; set; }
        public int p_inidtipomovimiento { get; set; }
        public string chcorrelativo { get; set; }
        public int p_inidproducto { get; set; }
        public decimal nucantidad { get; set; }
        public int p_inidmovimiento { get; set; }
        public string chreftip1 { get; set; }
        public string chrefnombre1 { get; set; }
        public string chreftip2 { get; set; }
        public string chrefnombre2 { get; set; }
        public string chreftip3 { get; set; }
        public string chrefnombre3 { get; set; }
        public string chreftip4 { get; set; }
        public string chrefnombre4 { get; set; }
        public kardexdetalle()
        {
            this.chfechamovi = string.Empty;
            this.p_inidtipomovimiento = 0;
            this.chcorrelativo = string.Empty;
            this.p_inidproducto = 0;
            this.nucantidad = 0;
            this.p_inidmovimiento = 0;
            this.chreftip1 =string.Empty;
            this.chrefnombre1 = string.Empty;
            this.chreftip2 = string.Empty;
            this.chrefnombre2 = string.Empty;
            this.chreftip3 = string.Empty;
            this.chrefnombre3 = string.Empty;
            this.chreftip4 = string.Empty;
            this.chrefnombre4 = string.Empty;
        }     
    }
}
