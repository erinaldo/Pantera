using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class proveedores
    {
        public int p_inidproveedor { get; set; }
        public int p_inactividad { get; set; }
        public int p_incodzona { get; set; }
        public string chnombrezona { get; set; }
        public string chtelefono1 { get; set; }
        public string chtelefono2 { get; set; }
        public int p_incodpais { get; set; }
        public bool estado { get; set; }
        public string chcodigoproveedor { get; set; }
        public int p_inidtipovia { get; set; }
        public string chtipovia { get; set; }
        public string chnumero { get; set; }
        public string chinterior { get; set; }
        public proveedores()
        {
            this.p_inidproveedor = 0;
            this.p_inactividad = 0;
            this.p_incodzona = 0;
            this.chnombrezona = string.Empty;
            this.chtelefono1 = string.Empty;
            this.chtelefono2 = string.Empty;
            this.p_incodpais = 0;
            this.estado = false;
            this.chcodigoproveedor = string.Empty;
            this.p_inidtipovia = 0;
            this.chtipovia = string.Empty;
            this.chnumero = string.Empty;
            this.chinterior = string.Empty;

        }
    }
}
