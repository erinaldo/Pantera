using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RegistroVenta
    {
        public int p_inidregistroventa { get; set; }
        public int p_inidpuntoventa { get; set; }
        public int p_inidtipodocu { get; set; }
        public int p_iniddocumento { get; set; }
        public string chcodigodocu { get; set; }
        public string chfechadoc { get; set; }
        public int p_inidcliente { get; set; }
        public decimal nucambioventa { get; set; }
        public decimal nuimporvtaafecta { get; set; }
        public decimal nuimportotdesc { get; set; }
        public decimal nuimporttotigv { get; set; }
        public decimal nuimportetotvta { get; set; }
        public string tipomovimiento { get; set; }
        public string chfechaventa { get; set; }
        public int p_inidsituacionregistro { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public RegistroVenta()
        {
            this.p_inidregistroventa = 0;
            this.p_inidpuntoventa = 0;
            this.p_inidtipodocu = 0;
            this.p_iniddocumento = 0;
            this.chcodigodocu = string.Empty;
            this.chfechadoc = string.Empty;
            this.p_inidcliente = 0;
            this.nucambioventa = 0;
            this.nuimporvtaafecta = 0;
            this.nuimportotdesc = 0;
            this.nuimporttotigv = 0;
            this.nuimportetotvta = 0;
            this.tipomovimiento = string.Empty;
            this.chfechaventa = string.Empty;
            this.p_inidsituacionregistro = 0;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
        }
    }
}
