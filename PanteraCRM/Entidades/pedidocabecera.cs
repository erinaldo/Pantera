using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class pedidocabecera
    {
        public int p_inidpedidocabecera { get; set; }
        public int p_inidpuntoventa { get; set; }
        public string chcodigopedido { get; set; }
        public string chfechapedido { get; set; }
        public string tmhorapedido { get; set; }
        public int p_inidtipodocumento { get; set; }
        public int p_inidcliente { get; set; }
        public int p_inmotivotransaccion { get; set; }
        public int p_inidcompromisopago { get; set; }
        public decimal nuporcenatajedesc { get; set; }
        public string chordencompra { get; set; }
        public int p_inidalmacen { get; set; }
        public int p_inidtransportista { get; set; }
        public int p_inidconductor { get; set; }
        public string chplacavehiculo { get; set; }
        public string chfechainiciotransporte { get; set; }
        public string chpuntopartida { get; set; }
        public string chpuntollegada { get; set; }
        public decimal nuventaafectamonnacional { get; set; }
        public string chmotivotransaccion { get; set; }
        public int p_inidmoneda { get; set; }
        public int p_inidigv { get; set; }
        public bool boafectoigv { get; set; }
        public decimal nuimportecambioventa { get; set; }
        public int p_inidvendedor { get; set; }
        public string chtiempoentrega { get; set; }
        public decimal nuventainafectamonnacional { get; set; }
        public decimal nutotaldescmonnacional { get; set; }
        public decimal nutotaligvmonnacional { get; set; }
        public decimal nutotalventamonnacional { get; set; }
        public decimal nuventaafectamonextra { get; set; }
        public decimal nuventainafectamonextra { get; set; }
        public decimal nutotaldescmonextra { get; set; }
        public decimal nutotaligvmonextra { get; set; }
        public decimal nutotalventamonextra { get; set; }
        public int p_inidsituacionpedido { get; set; }
        public string chobservacion { get; set; }
        public int p_inidusuarioinsert { get; set; }
        public int p_inidusuariodelete { get; set; }
        public bool estado { get; set; }
        public int p_inidvehiculo { get; set; }
        public int p_inidlicencia { get; set; }
        public int p_inidtarjeta { get; set; }
        public pedidocabecera()
        {
            this.p_inidpedidocabecera = 0;
            this.p_inidpuntoventa = 0;
            this.chcodigopedido = string.Empty;
            this.chfechapedido = string.Empty;
            this.tmhorapedido = string.Empty;
            this.p_inidtipodocumento = 0;
            this.p_inidcliente = 0;
            this.p_inmotivotransaccion = 0;
            this.p_inidcompromisopago = 0;
            this.nuporcenatajedesc = 0;
            this.chordencompra = string.Empty;
            this.p_inidalmacen = 0;
            this.p_inidtransportista = 0;
            this.p_inidconductor = 0;
            this.chplacavehiculo = string.Empty;
            this.chfechainiciotransporte = string.Empty;
            this.chpuntopartida = string.Empty;
            this.chpuntollegada = string.Empty;
            this.nuventaafectamonnacional = 0;
            this.chmotivotransaccion = string.Empty;
            this.p_inidmoneda = 0;
            this.p_inidigv = 0;
            this.boafectoigv = false;
            this.nuimportecambioventa = 0;
            this.p_inidvendedor = 0;
            this.chtiempoentrega = string.Empty;
            this.nuventainafectamonnacional = 0;
            this.nutotaldescmonnacional = 0;
            this.nutotaligvmonnacional = 0;
            this.nutotalventamonnacional = 0;
            this.nuventaafectamonextra = 0;
            this.nuventainafectamonextra = 0;
            this.nutotaldescmonextra = 0;
            this.nutotaligvmonextra = 0;
            this.nutotalventamonextra = 0;
            this.p_inidsituacionpedido = 0;
            this.chobservacion = string.Empty;
            this.p_inidusuarioinsert = 0;
            this.p_inidusuariodelete = 0;
            this.estado = false;
            this.p_inidvehiculo = 0;
            this.p_inidlicencia = 0;
            this.p_inidtarjeta = 0;
    }
    }
}
