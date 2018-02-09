using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class productobuscado
    {
        public int p_inidproducto { get; set; }
        public string chcodigoproducto { get; set; }
        public string chnombrecompuesto { get; set; }
        public int p_inidunidadmedidaproducto { get; set; }
        public string chunidadmedidaproducto { get; set; }
        public int p_inidsituacion { get; set; }
        public string chsituacion { get; set; }
        public decimal nuprecio { get; set; }
        public bool req_serie { get; set; }
        public productobuscado()
        {
            this.p_inidproducto = 0;
            this.chcodigoproducto = string.Empty;
            this.chnombrecompuesto = string.Empty;
            this.p_inidunidadmedidaproducto = 0;
            this.chunidadmedidaproducto = string.Empty;
            this.p_inidsituacion = 0;
            this.chsituacion = string.Empty;
            this.nuprecio = 0;
            this.req_serie = false;
        }

    }
}
