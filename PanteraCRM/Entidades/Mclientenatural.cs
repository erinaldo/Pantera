using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mclientenatural
    {
        public int p_inidclientenatural { get; set; }
        public int p_inidcliente { get; set; }
        public int p_inidpersona { get; set; }
        public Mclientenatural()
        {
            this.p_inidclientenatural = 0;
            this.p_inidcliente = 0;
            this.p_inidpersona = 0;
        }
    }
}
