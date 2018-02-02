using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class presupuestodetalle
    {
        public decimal cantidad { get; set; }
        public string idmediarticulo { get; set; }
        public int idarticulo { get; set; }
        public string nombrearticulo { get; set; }
        public decimal precio { get; set; }
        public decimal subtotal { get; set; }

        public presupuestodetalle()
        {
            this.cantidad = 0;
            this.idmediarticulo = string.Empty;
            this.idarticulo = 0;
            this.nombrearticulo = string.Empty;
            this.precio = 0;
            this.subtotal = 0;
        }
    }
}
