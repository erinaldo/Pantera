using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class recibo
    {
        public int p_inidrecibo { get; set; }
        public int p_inidpagocomprocabecera { get; set; }
        public string chcodigorecibo { get; set; }
        public string chfecharecibo { get; set; }
        public int p_inidtipopago { get; set; }
        public decimal nuimporterecalculo { get; set; }
        public decimal nuimporteinteres { get; set; }
        public int p_inidcliente { get; set; }
        public int p_inidmoneda { get; set; }
        public int p_inidbanco { get; set; }
        public int p_inidsituacionregistro { get; set; }
        public int p_inidtipomovimiento { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidurusariodelete { get; set; }
        public bool estado { get; set; }
        public string chcheque { get; set; }
        public recibo()
        {
            this.p_inidrecibo = 0;
            this.p_inidpagocomprocabecera = 0;
            this.chcodigorecibo = string.Empty;
            this.chfecharecibo = string.Empty;
            this.p_inidtipopago = 0;
            this.nuimporterecalculo = 0;
            this.nuimporteinteres = 0;
            this.p_inidcliente = 0;
            this.p_inidmoneda = 0;
            this.p_inidbanco = 0;
            this.p_inidsituacionregistro = 0;
            this.p_inidtipomovimiento = 0;
            this.p_inidusuarioinsert = 0;
            this.p_inidurusariodelete = 0;
            this.estado = false;
            this.chcheque = string.Empty;
        }
    }
}
