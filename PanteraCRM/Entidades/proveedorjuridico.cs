using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class proveedorjuridico
    {
        public int p_inidproveedorjuridico { get; set; }
        public int p_inidempresa { get; set; }
        public int p_inidproveedor { get; set; }
        public proveedorjuridico()
        {
            this.p_inidproveedorjuridico = 0;
            this.p_inidempresa = 0;
            this.p_inidproveedor = 0;
        }
    }
}
