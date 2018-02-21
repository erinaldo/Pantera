using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class movimientoproductod
    {
        public int p_inidvaledetalle { get; set; }
        public int p_inidvalecebecera { get; set; }
        public int p_inidproducto { get; set; }
        public decimal nucantidad { get; set; }
        public decimal nucosto { get; set; }
        public decimal nutotal { get; set; }
        public movimientoproductod()
        {
            this.p_inidvaledetalle = 0;
            this.p_inidvalecebecera = 0;
            this.p_inidproducto = 0;
            this.nucantidad = 0;
            this.nucosto = 0;
            this.nutotal = 0;
        }
    }
}
