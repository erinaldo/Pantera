using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mclientejuridico
    {
        public int p_inidclientejuridico { get; set; }
        public int p_inidcliente { get; set; }
        public int p_inidempresa { get; set; }
        public Mclientejuridico()
        {
            this.p_inidclientejuridico = 0;
            this.p_inidcliente = 0;
            this.p_inidempresa = 0;
        }
    }
}
