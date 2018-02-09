using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class seriebuscada
    {
        public int p_inidserie { get; set; }
        public string chserie { get; set; }
        public string chnombreproductocompuesto { get; set; }
        public string chobservacion { get; set; }
        public seriebuscada()
        {
            this.p_inidserie = 0;
            this.chserie = string.Empty;
            this.chnombreproductocompuesto = string.Empty;
            this.chobservacion = string.Empty;
        }

    }
}
