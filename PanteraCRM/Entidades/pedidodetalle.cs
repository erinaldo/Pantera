using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class pedidodetalle
    {
        public int p_inidpedidodetalle { get; set; }
        public int p_inidpedidocabecera { get; set; }
        public string chitem { get; set; }
        public int p_inidproducto { get; set; }
        public string  chcodigoproducto { get; set; }
        public decimal nucantidad { get; set; }
        public decimal nustock { get; set; }
        public string chnombrecompuesto { get; set; }
        public decimal nuprecioproducto { get; set; }
        public decimal nuporcentajedesc1 { get; set; }
        public decimal nuporcentajedesc2 { get; set; }
        public decimal nuprecioventa { get; set; }
        public decimal nuimportesubtotal { get; set; }
        public bool estado { get; set; }
        public int p_inidserie { get; set; }
        public string chserie { get; set; }
        
        public pedidodetalle()
        {
            this.p_inidpedidodetalle = 0;
            this.p_inidpedidocabecera = 0;
            this.chitem = string.Empty;
            this.p_inidproducto = 0;
            this.chcodigoproducto = string.Empty;
            this.nucantidad = 0;
            this.nustock = 0;
            this.chnombrecompuesto =string.Empty;
            this.nuprecioproducto = 0;
            this.nuporcentajedesc1 = 0;
            this.nuporcentajedesc2 = 0;
            this.nuprecioventa = 0;
            this.nuimportesubtotal = 0;
            this.estado = false;
            this.p_inidserie = 0;
            this.chserie=string.Empty;

    }
    }
}
