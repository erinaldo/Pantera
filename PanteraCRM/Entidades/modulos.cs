using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class modulos

    {
        public int p_inidmenu { get; set; }
        public int chcodigomenu { get; set; }
        public string chdescripcionmenu { get; set; }
        public bool estado { get; set; }
        public modulos()
        {
            this.p_inidmenu = 0;
            this.chcodigomenu = 0;
            this.chdescripcionmenu = string.Empty;
            this.estado = false;
            
        }
    }
}
