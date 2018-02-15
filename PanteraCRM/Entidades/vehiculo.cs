using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class vehiculo
    {
        public int p_inidvehiculo { get; set; }
        public string chplacavehiculo { get; set; }
        public string chmarcavehiculo { get; set; }
        public vehiculo()
        {
            this.p_inidvehiculo = 0;
            this.chplacavehiculo = string.Empty;
            this.chmarcavehiculo = string.Empty;
        }
    }
}
