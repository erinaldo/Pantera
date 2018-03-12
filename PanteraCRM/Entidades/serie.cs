using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class serie
    {
        public int p_inidserie { get; set; }
        public string chcodigoserie { get; set; }
        public bool estado { get; set; }
        public int p_inidproducto { get; set; }
        public string chadicional { get; set; }
        public string chfecha { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public int p_inidmovimientod { get; set; }
        public int p_inidpedidod{ get; set; }
        public bool boexhibicion { get; set; }
        public string chinforme { get; set; }
        public string chinformeobs { get; set; }
        public string chinformefecha { get; set; }
        public string chidentificador { get; set; }
       

        public serie()
        {
            this.p_inidserie = 0;
            this.chcodigoserie = string.Empty;
            this.estado = false;
            this.p_inidproducto = 0;
            this.chadicional = string.Empty;
            this.chfecha = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.p_inidmovimientod = 0;
            this.p_inidpedidod = 0;
            this.boexhibicion = false;
            this.chinforme = string.Empty;
            this.chinformeobs = string.Empty;
            this.chinformefecha = string.Empty;
            this.chidentificador = string.Empty;
        }
    }
}
