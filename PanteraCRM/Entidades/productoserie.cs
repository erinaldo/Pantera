using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class productoserie
    {
        public int p_inidproducto { get; set; }
        public string chcodigoproducto { get; set; }
        public string chdescripcion { get; set; }
        public int p_inidserie { get; set; }
        public string chcodigoserie { get; set; }
        public bool estado { get; set; }
        public bool boexhibicion { get; set; }
        public string chinforme { get; set; }
        public string chinformeobs { get; set; }
        public string chinformefecha { get; set; }
        public string chcodigo { get; set; }
        public string identificador { get; set; }
        public productoserie()
        {
            this.p_inidproducto = 0;
            this.chcodigoproducto = string.Empty;
            this.chdescripcion = string.Empty;
            this.p_inidserie = 0;
            this.chcodigoserie = string.Empty;
            this.estado = false;
            this.boexhibicion = false;
            this.chinforme = string.Empty;
            this.chinformeobs = string.Empty;
            this.chinformefecha = string.Empty;
            this.chcodigo = string.Empty;
            this.identificador = string.Empty;
        }
    }
}
