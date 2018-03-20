using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class notacreditodetalle
    {
        public int p_inidnotacreditod { get; set; }
        public int p_inidnotacreditoc { get; set; }
        public int initem { get; set; }
        public int p_inidproducto { get; set; }
        public int p_inidserie { get; set; }
        public decimal nucantidad { get; set; }
        public decimal nuprecio { get; set; }
        public decimal nudesc1 { get; set; }
        public decimal nudesc2 { get; set; }
        public decimal nuventa { get; set; }
        public decimal nuimporte { get; set; }
        public decimal nutotdesc { get; set; }
        public notacreditodetalle()
        {
            this.p_inidnotacreditod = 0;
            this.p_inidnotacreditoc = 0;
            this.initem = 0;
            this.p_inidproducto = 0;
            this.p_inidserie = 0;
            this.nucantidad = 0;
            this.nuprecio = 0;
            this.nudesc1 = 0;
            this.nudesc2 = 0;
            this.nuventa = 0;
            this.nuimporte = 0;
            this.nutotdesc = 0;
        }
    }
}
