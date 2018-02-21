using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class movimientoproductoc
    {
        public int p_inidvalecebecera { get; set; }
        public int p_inidalamacen { get; set; }
        public int p_inidclase { get; set; }
        public string p_inidcorrevale { get; set; }
        public string chvalefecha { get; set; }
        public int p_inidtipomoneda { get; set; }
        public int p_inidproveedor { get; set; }
        public string chguiaremision { get; set; }
        public string chboletafactura { get; set; }
        public int p_inidtipomoviemiento { get; set; }
        public string chobservacion { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public int p_inidmovimiento { get; set; }
        public movimientoproductoc()
        {
            this.p_inidvalecebecera = 0;
            this.p_inidalamacen = 0;
            this.p_inidclase = 0;
            this.p_inidcorrevale = string.Empty;
            this.chvalefecha = string.Empty;
            this.p_inidtipomoneda = 0;
            this.p_inidproveedor = 0;
            this.chguiaremision = string.Empty;
            this.chboletafactura = string.Empty;
            this.p_inidtipomoviemiento = 0;
            this.chobservacion = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
            this.p_inidmovimiento = 0;
        }
    }
}
