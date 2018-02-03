using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class producto
    {
        private int p_inidproducto { get; set; }
        private int p_inidfamilia { get; set; }
        private int p_intipoproducto { get; set; }
        private int p_inidmarca { get; set; }
        private int p_inidcalibre { get; set; }
        private int p_inidmodelo { get; set; }
        private bool estado { get; set; }
        public producto()
        {
            this.p_inidproducto = 0;
            this.p_inidfamilia = 0;
            this.p_intipoproducto = 0;
            this.p_inidmarca = 0;
            this.p_inidcalibre = 0;
            this.p_inidmodelo = 0;
            this.p_inidproducto = 0;
            this.p_inidproducto = 0;
            this.estado = false;
        }
    }
}
