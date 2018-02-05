using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class producto
    {
        public int p_inidproducto { get; set; }
        public string chcodigoproducto { get; set; }
        public int p_inidtipoproducto { get; set; }
        public int p_inidmarca { get; set; }
        public int p_inunidadmedidaproducto { get; set; }
        public string chfechacreacion { get; set; }
        public bool estado { get; set; }
        public string tmhoracreacion { get; set; }
        public int p_inidfamiliaproducto { get; set; }
        public int p_inidcalibre { get; set; }
        public int p_inidmodelo { get; set; }
        public string chcodigoproductoantes { get; set; }
        public string chdescripcionproducto { get; set; }
        public producto()
        {
            this.p_inidproducto = 0;
            this.chcodigoproducto = string.Empty;
            this.p_inidtipoproducto = 0;
            this.p_inidmarca = 0;
            this.p_inunidadmedidaproducto = 0;
            this.chfechacreacion = string.Empty;
            this.estado = false;
            this.tmhoracreacion = string.Empty;
            this.p_inidfamiliaproducto = 0;
            this.p_inidcalibre = 0;
            this.p_inidmodelo = 0;
            this.chcodigoproductoantes = string.Empty;
            this.chdescripcionproducto = string.Empty;

        }
    }
}
