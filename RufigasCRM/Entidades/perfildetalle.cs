using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class perfildetalle
    {
            public int idmenu { get; set; }
            public string descripcion { get; set; }
            public bool seleccion { get; set; }
            public perfildetalle()
            {
                this.idmenu = 0;
                this.descripcion = string.Empty;
                this.seleccion = true;
            }
        
    }
}
