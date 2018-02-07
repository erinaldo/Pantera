using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class tipo
    {
        public int p_inidtipo { get; set; }
        public int p_inidcategoria { get; set; }
        public string chtipo { get; set; }
        public bool estado { get; set; }
        public tipo()
        {
            this.p_inidtipo = 0;
            this.p_inidcategoria = 0;
            this.chtipo = string.Empty;
            this.estado = false;
        }
    }
}
