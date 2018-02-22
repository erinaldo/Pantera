using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class valedetalle
    {
        public int p_inidvaledetalle { get; set; }
        public int p_inidvalecebecera { get; set; }
        public int p_inidproducto { get; set; }
        public string chcodigoproducto { get; set; }
        public string chnombrecompuesto { get; set; }
        public int p_inidserie { get; set; }
        public string chcodigoserie { get; set; }
        public int nucantidad { get; set; }
        public decimal nucosto { get; set; }
        public decimal nutotal { get; set; }
        public string chfecha { get; set; }
        public string chmedida { get; set; }
        public bool estado { get; set; }
        public valedetalle()
        {
            this.p_inidvaledetalle = 0;
            this.p_inidvalecebecera = 0;
            this.p_inidproducto = 0;
            this.chcodigoproducto = string.Empty;
            this.chnombrecompuesto = string.Empty;
            this.chcodigoserie = string.Empty;
            this.p_inidserie = 0;
            this.nucantidad = 0;
            this.nucosto = 0;
            this.nutotal = 0;
            this.chfecha = string.Empty;
            this.chmedida = string.Empty;
            this.estado = false;
        }
    }
}
