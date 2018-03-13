using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class pedidoguicomp
    {
        public int p_inidpedidoguicomp { get; set; }
        public string chcodigopedido { get; set; }
        public string chguiaremision { get; set; }
        public string chcomprobante { get; set; }
        public string chtipocompro { get; set; }
        public bool estado { get; set; }
        public string chobservacion { get; set; }
        public pedidoguicomp()
        {
            this.p_inidpedidoguicomp = 0;
            this.chcodigopedido = string.Empty;
            this.chguiaremision = string.Empty;
            this.chcomprobante = string.Empty;
            this.chtipocompro = string.Empty;
            this.estado = false;
            this.chobservacion = string.Empty;
        }
    }
}
