using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class sessionglobal
    {
        public int p_inidpuntoventa { get; set; }
        public string chpuntoventa { get; set; }
        public int p_inidalmacen { get; set; }
        public string chalamacen { get; set; }
        public int p_inidusuario { get; set; }
        public string chnombrepersona { get; set; }
        public string chusuario { get; set; }
        public int p_inidpersona { get; set; }
        public int p_inidperfil { get; set; }
        public bool estado { get; set; }
        public sessionglobal()
        {
            this.p_inidpuntoventa = 0;
            this.chpuntoventa = string.Empty;
            this.p_inidalmacen = 0;
            this.chalamacen = string.Empty;
            this.p_inidusuario = 0;
            this.chnombrepersona = string.Empty;
            this.chusuario = string.Empty;
            this.p_inidpersona = 0;
            this.p_inidperfil = 0;
            this.estado = false;
        }
    }
}
