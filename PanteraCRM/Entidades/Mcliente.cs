using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mcliente
    {
        public int p_inidcliente { get; set; }
        public string chdireccionenvio { get; set; }
        public int p_inidtipovia { get; set; }
        public string chnombrevia { get; set; }
        public string chnumero { get; set; }
        public string chnumerointerior { get; set; }
        public int p_inidtipozona { get; set; }
        public string chnombrezona { get; set; }
        public bool estado { get; set; }
        public string chtelefono2 { get; set; }
        public string chtelefono3 { get; set; }
        public int inlimitecredito { get; set; }
        public int p_inidpais { get; set; }
        public string chcodigocliente { get; set; }
        public int p_inidtipocliente { get; set; }
        public Mcliente()
        {
            this.p_inidcliente = 0;
            this.chdireccionenvio = string.Empty;
            this.p_inidtipovia = 0;
            this.chnombrevia = string.Empty;
            this.chnumero = string.Empty;
            this.chnumerointerior = string.Empty;
            this.p_inidtipozona = 0;
            this.chnombrezona = string.Empty;
            this.estado = false;
            this.chtelefono2 = string.Empty;
            this.chtelefono3 = string.Empty;
            this.inlimitecredito = 0;
            this.p_inidpais = 0;
            this.chcodigocliente = string.Empty;
            this.p_inidtipocliente = 0;
        }
    }
}
