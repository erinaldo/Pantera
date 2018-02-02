using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class presupuesto
    {
        public int idpresupuesto { get; set; }
        public int idempresa { get; set; }
        public int idpuntoventa { get; set; }
        public string codigoserie { get; set; }
        public string numeropresupuesto { get; set; }
        public string placa { get; set; }
        public int idpersona { get; set; }
        public string dni { get; set; }
        public string nombres { get; set; }
        public string fechapresupuesto { get; set; }
        public string fecharq { get; set; }
        public string fechara { get; set; }
        public int idmarca { get; set; }
        public int idmodelo { get; set; }
        public decimal total { get; set; }
        public string observacion { get; set; }
        public string idsitupresupuesto { get; set; }
        public bool estadopresupuesto { get; set; }
        public presupuesto()
        {
            this.idpresupuesto = 0;
            this.idempresa = 0;
            this.idpuntoventa = 0;
            this.codigoserie = string.Empty;
            this.numeropresupuesto = string.Empty;
            this.dni = string.Empty;
            this.nombres = string.Empty;
            this.placa= string.Empty;
            this.idpersona = 0;
            this.fechapresupuesto = string.Empty;
            this.fecharq = string.Empty;
            this.fechara = string.Empty;
            this.idmarca = 0;
            this.idmodelo = 0;
            this.total = 0;
            this.observacion = string.Empty;
            this.idsitupresupuesto = string.Empty;
            this.estadopresupuesto = true;
        }
    }
}