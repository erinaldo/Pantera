using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class empresas
    {
        public int p_inidempresa { get; set; }
        public string chrazonsocial { get; set; }
        public string chruc { get; set; }
        public string chtelefono { get; set; }
        public string chdirecfiscal { get; set; }
        public string chobservacion { get; set; }
        public bool estado { get; set; }
        public string chnombrecomercial { get; set; }
        public int p_inidubigeo { get; set; }
        public empresas()
        {
            this.p_inidempresa = 0;
            this.chrazonsocial = string.Empty;
            this.chruc = string.Empty;
            this.chtelefono = string.Empty;
            this.chdirecfiscal = string.Empty;
            this.chobservacion = string.Empty;
            this.estado = false;
            this.chnombrecomercial = string.Empty;
            this.p_inidubigeo = 0;
        }
    }
}
