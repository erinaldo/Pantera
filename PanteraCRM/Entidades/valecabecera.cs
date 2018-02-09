using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class valecabecera
    {
        public int p_inidvalecebecera { get; set; }
        public int p_inidalamacen { get; set; }
        public string chalamacen { get; set; }
        public int p_inidclase { get; set; }
        public string chclase { get; set; }
        public int p_inidcorrevale { get; set; }
        public string chvalefecha { get; set; }
        public int p_inidtipomoneda { get; set; }
        public string chtipomoneda { get; set; }
        public int p_inidproveedor { get; set; }
        public string chcodigoproveedor { get; set; }
        public string chguiaremision { get; set; }
        public string chboletafactura { get; set; }
        public int p_inidtipomoviemiento { get; set; }
        public string chtipomoviemiento { get; set; }
        public string chobservacion { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public string chusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public string chusuariodelete { get; set; }
        public bool estado { get; set; }
        public valecabecera() {
            this.p_inidvalecebecera = 0;
            this.p_inidalamacen = 0;
            this.chalamacen = string.Empty;
            this.p_inidclase = 0;
            this.chclase = string.Empty;
            this.p_inidcorrevale = 0;
            this.chvalefecha = string.Empty;
            this.p_inidtipomoneda = 0;
            this.chtipomoneda = string.Empty;
            this.p_inidproveedor = 0;
            this.chcodigoproveedor = string.Empty;
            this.chguiaremision = string.Empty;
            this.chboletafactura = string.Empty;
            this.p_inidtipomoviemiento = 0;
            this.chtipomoviemiento = string.Empty;
            this.chobservacion = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.chusuarioinsert = string.Empty;
            this.p_inidusuariodelete = 0;
            this.chusuariodelete = string.Empty;
            this.estado = false;
        }
    }
}
