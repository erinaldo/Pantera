using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clientebusqueda
    {
        public int p_inidcodigoclie { get; set; }
        public string chcodigocliente { get; set; }
        public string razon { get; set; }
        public string tipodocu { get; set; }
        public string nrodocumento { get; set; }
        public string chdireccion { get; set; }
        public string tipoclie { get; set; }
        public string telefono { get; set; }
        public clientebusqueda()
        {
            this.p_inidcodigoclie = 0;
            this.chcodigocliente = string.Empty;
            this.razon = string.Empty;
            this.tipodocu = string.Empty;
            this.nrodocumento = string.Empty;
            this.chdireccion = string.Empty;
            this.tipoclie = string.Empty;
            this.telefono = string.Empty;

        }
    }
}
