using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class saldoalmacen
    {
        public int p_inidsaldoalmancen { get; set; }
        public decimal nustockactual { get; set; }
        public decimal nustockcomprpmetido { get; set; }
        public decimal nustockminima { get; set; }
        public bool estado { get; set; }
        public int p_inidalmacen { get; set; }
        public int p_inidproducto { get; set; }
        public string chnombrecompuesto { get; set; }
        public string chcodigo { get; set; }
        public saldoalmacen()
        {
            this.p_inidsaldoalmancen = 0;
            this.nustockactual = 0;
            this.nustockcomprpmetido = 0;
            this.nustockminima = 0;
            this.estado = false;
            this.p_inidalmacen = 0;
            this.p_inidproducto = 0;
            this.chcodigo = string.Empty;
            this.chnombrecompuesto = string.Empty ;
        }
    }
}
