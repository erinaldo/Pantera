using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class kardexdetalle
    {
        public string chfechamovi { get; set; }
        public int p_inidtipomovimiento { get; set; }
        public int p_inidproducto { get; set; }
        public decimal nucantidad { get; set; }
        public int p_inidmovimiento { get; set; }
        public int chrefnombre1 { get; set; }
        public int chrefnombre1 { get; set; }
        public int chrefnombre1 { get; set; }
        public int chrefnombre1 { get; set; }
        public int chrefnombre1 { get; set; }
        public int chrefnombre1 { get; set; }
        public int chrefnombre1 { get; set; }
        public int chrefnombre1 { get; set; }
        /*select  a.chvalefecha,a.p_inidtipomoviemiento, a.p_inidcorrevale, a.p_inidmovimiento,
 b.nucantidad from movimientoproductoc a
inner join movimientoproductod b on a.p_inidvalecebecera = b.p_inidvalecebecera
where p_inidproducto=269*/
    }
}
