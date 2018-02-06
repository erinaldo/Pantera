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
        public string chtipoproducto { get; set; }
        public int p_inidmarca { get; set; }
        public string chmarca { get; set; }
        public int p_inidunidadmedidaproducto { get; set; }
        public string chunidadmedidaproducto { get; set; }
        public string chfechacreacion { get; set; }
        public bool estado { get; set; }
        public int p_inidfamiliaproducto { get; set; }
        public string chfamiliaproducto { get; set; }
        public int p_inidcalibre { get; set; }
        public string chcalibre { get; set; }
        public int p_inidmodelo { get; set; }
        public string chdmodelo { get; set; }
        public string chcodigoproductoantes { get; set; }
        public string chdescripcionproducto { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public string chusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public string chusuariodelete { get; set; }
        public float nuprecio { get; set; }
        public int p_inidsituacion { get; set; }
        public string chsituacion { get; set; }
        public producto()
        {
            this.p_inidproducto = 0;
            this.chcodigoproducto = string.Empty;
            this.p_inidtipoproducto = 0;
            this.chtipoproducto = string.Empty;
            this.p_inidmarca = 0;
            this.chmarca = string.Empty;
            this.p_inidunidadmedidaproducto = 0;
            this.chunidadmedidaproducto = string.Empty;
            this.chfechacreacion = string.Empty;
            this.estado = false;
            this.p_inidfamiliaproducto = 0;
            this.chfamiliaproducto = string.Empty;
            this.p_inidcalibre = 0;
            this.chcalibre = string.Empty;
            this.p_inidmodelo = 0;
            this.chdmodelo = string.Empty;
            this.chcodigoproductoantes = string.Empty;
            this.chdescripcionproducto = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.chusuarioinsert = string.Empty;
            this.p_inidusuariodelete = 0;
            this.chusuariodelete = string.Empty;
            this.nuprecio = 0;
            this.p_inidsituacion = 0;
            this.chsituacion = string.Empty;

        }
    }
}
