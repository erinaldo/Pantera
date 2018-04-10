using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class registroventaexcel
    {
        public string razon { get; set; }
        public string tipoclie { get; set; }
        public string chlicencia { get; set; }

        public string chfechapedido { get; set; }
        public decimal nucantidad { get; set; }
        public int nucantporuni { get; set; }
        public string chcodigoserie { get; set; }
        public string chfamiliaproducto { get; set; }
        public string chtipoproducto { get; set; }

        public string chmarca { get; set; }
        public string chcalibre { get; set; }
        public string chdmodelo { get; set; }
        public registroventaexcel()
        {
            this.razon = string.Empty;
            this.tipoclie = string.Empty;
            this.chlicencia = string.Empty;
            this.razon = string.Empty;
            this.chfechapedido = string.Empty;
            this.nucantidad = 0;
            this.nucantporuni = 0;
            this.chcodigoserie = string.Empty;
            this.chfamiliaproducto = string.Empty;
            this.chtipoproducto =string.Empty;
            this.chmarca = string.Empty;
            this.chcalibre = string.Empty;
            this.chdmodelo = string.Empty;
        }
    }
}
