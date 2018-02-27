using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class tarjetapropiedad
    {
        public int p_inidtarjeta { get; set; }
        public int p_inidcliente { get; set; }
        public string chtarjeta { get; set; }
        public string fechavencimiento { get; set; }
        public bool estado { get; set; }
        public tarjetapropiedad()
        {
            this.p_inidtarjeta = 0;
            this.p_inidcliente = 0;
            this.chtarjeta = string.Empty;
            this.fechavencimiento = string.Empty;
            this.estado = false;
        }
    }
}
