using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class articulopresupuesto
    {
        public int idarticulo { get; set; }
        public string codigoarticulo { get; set; }
        public string nombrearticulo { get; set; }
        public string idtipoarticulo { get; set; }
        public string idmediarticulo { get; set; }
        public decimal precio { get; set; }
        public articulopresupuesto()
        {
            this.idarticulo = 0;
            this.codigoarticulo = string.Empty;
            this.nombrearticulo = string.Empty;
            this.idtipoarticulo = string.Empty;
            this.idmediarticulo = string.Empty;
            this.precio = 0;
        }
    }
}
