using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class productostockminimo
    {
        public int p_inidproducto { get; set; }
        public string chcodigoproducto { get; set; }
        public string producto { get; set; }
        public int nustockactual { get; set; }
        public productostockminimo()
        {
            this.p_inidproducto = 0;
            this.chcodigoproducto = string.Empty;
            this.producto = string.Empty;
            this.nustockactual = 0;
        }
    }
}
