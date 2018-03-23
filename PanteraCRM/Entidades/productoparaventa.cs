using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class productoparaventa
    {
        public int p_inidproducto { get; set; }
        public string chcodigoproducto { get; set; }
        public string chnombrecompuesto { get; set; }
        public string chunidadmedidaproducto { get; set; }
        public decimal nuprecio { get; set; }
        public int p_inidsaldoalmancen { get; set; }
        public decimal nustockactual { get; set; }
        public bool req_serie { get; set; }
        public int p_inidserie { get; set; }
        public string chserie { get; set; }
        public int p_inidcategoria { get; set; }

        public productoparaventa()
        {
            this.p_inidproducto = 0;
            this.chcodigoproducto = string.Empty;
            this.chnombrecompuesto = string.Empty;
            this.chunidadmedidaproducto = string.Empty;
            this.nuprecio = 0;
            this.p_inidsaldoalmancen = 0;
            this.nustockactual = 0;
            this.req_serie = false;
            this.p_inidserie = 0;
            this.chserie = string.Empty;
            this.p_inidcategoria = 0;
        }
    }
}
