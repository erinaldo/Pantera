using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class productobuscadocodigo
    {
        public string codigoproducto { get; set; }
        public int p_inidproducto { get; set; }
        public string nombrecompuesto { get; set; }
        public int p_inidserie { get; set; }
        public decimal nupreciounit { get; set; }
        public bool boreq_serie { get; set; }
        public int instock { get; set; }
        public string chmedida { get; set;}
    }
}
