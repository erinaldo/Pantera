using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class maestrodetalle
    {
        public int idmaestrodetalle { get; set; }
        public int idmaestro { get; set; }
        public string codigoitem { get; set; }
        public string nombreitem { get; set; }
        public string libre { get; set; }
        public maestrodetalle()
        {
            this.idmaestrodetalle = 0;
            this.idmaestro =0;
            this.codigoitem = string.Empty;
            this.nombreitem = string.Empty;
            this.libre = string.Empty;
        }
    }
}