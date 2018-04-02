using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class puntoventa
    {
        public int idpuntoventa { get; set; }
        public string nombrepuntaventa { get; set; }
        public puntoventa()
        {
            this.idpuntoventa = 0;
            this.nombrepuntaventa = string.Empty;
        }
    }
}
