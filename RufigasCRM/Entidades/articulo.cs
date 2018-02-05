using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class articulo
    {
        public int p_inidproducto { get; set; }
        public string chcodigoproducto { get; set; }
        public string p_inidtipoproducto { get; set; }
        public string p_inidmarca { get; set; }
        public string p_inidunidadmedidaproducto { get; set; }
        public string p_inidfamiliaproducto { get; set; }
        public string p_inidcalibre { get; set; }
        public string p_inidmodelo { get; set; }

        public bool estado { get; set; }

        public articulo()
        {
            this.p_inidproducto = 0;
            this.chcodigoproducto = string.Empty;
            this.p_inidtipoproducto = string.Empty;
            this.p_inidmarca = string.Empty;
            this.p_inidunidadmedidaproducto = string.Empty;
            this.p_inidfamiliaproducto = string.Empty;
            this.p_inidcalibre = string.Empty;
            this.p_inidmodelo = string.Empty;
            this.estado = true;
        }
    }
}
