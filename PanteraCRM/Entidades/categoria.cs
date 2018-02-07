using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class categoria
    {
        public int p_inidcategoria { get; set; }
        public string chcategoria { get; set; }
        public bool estado { get; set; }
        public categoria()
        {
            this.p_inidcategoria = 0;
            this.chcategoria = string.Empty;
            this.estado = false;
        }
    }
}
