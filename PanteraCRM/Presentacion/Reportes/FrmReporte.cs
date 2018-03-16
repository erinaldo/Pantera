using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using Entidades;
using Negocios;
namespace Presentacion.Reportes
{
    public partial class FrmReporte : Form
    {

        public CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        internal string codigopedido;
        internal string tipocomprobante;
        internal int p_inidcodigopedido;
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            this.CrpViewer.ReportSource = Rpt;
            CargarDatosCorrelativos(tipocomprobante);
        }
        private void CargarDatosCorrelativos(string tipocomprobante1)
        {
            txtfecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            txtCorrePedi.Text = codigopedido;
            if (tipocomprobante1 == "BV")
            {
                lblCorrePrimario.Text = "BV";
                txtCorrePrimario.Text = generarCodigoNE.ObtenerCorrelativoBoleta(sesion.SessionGlobal.p_inidpuntoventa);
                lblCorreSecundario.Text = "";
                txtCorreSecundario.Text = "";
                lblCorreSecundario.Visible = false;
                txtCorreSecundario.Visible = false;
            }
            else
            {
                if (tipocomprobante1 == "FC")
                {
                    lblCorrePrimario.Text = "FC";
                    txtCorrePrimario.Text = generarCodigoNE.ObtenercorrelativoFactura(sesion.SessionGlobal.p_inidpuntoventa);
                    lblCorreSecundario.Text = "";
                    txtCorreSecundario.Text = "";
                    lblCorreSecundario.Visible = false;
                    txtCorreSecundario.Visible = false;
                }
                else
                {
                    if (tipocomprobante1 == "FG")
                    {
                        lblCorrePrimario.Text = "FC";
                        txtCorrePrimario.Text = generarCodigoNE.ObtenercorrelativoFactura(sesion.SessionGlobal.p_inidpuntoventa);
                        lblCorreSecundario.Text = "GR";
                        txtCorreSecundario.Text = generarCodigoNE.ObtenerCorrelativoGuia(sesion.SessionGlobal.p_inidpuntoventa);                        
                    }
                    else
                    {
                        if (tipocomprobante1 == "BG")
                        {
                            lblCorrePrimario.Text = "BV";
                            txtCorrePrimario.Text = generarCodigoNE.ObtenerCorrelativoBoleta(sesion.SessionGlobal.p_inidpuntoventa);
                            lblCorreSecundario.Text = "GR";
                            txtCorreSecundario.Text = generarCodigoNE.ObtenerCorrelativoGuia(sesion.SessionGlobal.p_inidpuntoventa);
                        }
                        else
                        {
                            if (tipocomprobante1 == "GR")
                            {
                                lblCorrePrimario.Visible = false;
                                txtCorrePrimario.Visible = false;
                                lblCorrePrimario.Text = "";
                                txtCorrePrimario.Text = "";
                                lblCorreSecundario.Text = "GR";
                                txtCorreSecundario.Text = generarCodigoNE.ObtenerCorrelativoGuia(sesion.SessionGlobal.p_inidpuntoventa);

                            }
                            else
                            {
                                if (tipocomprobante1 == "NV")
                                {
                                    lblCorrePrimario.Text = "NV";
                                    txtCorrePrimario.Text = generarCodigoNE.ObtenerCorrelativoNotaVenta(sesion.SessionGlobal.p_inidpuntoventa);
                                    lblCorreSecundario.Text = "";
                                    txtCorreSecundario.Text = "";
                                    lblCorreSecundario.Visible = false;
                                    txtCorreSecundario.Visible = false;
                                }
                                else
                                {
                                    lblCorrePrimario.Text = "";
                                    txtCorrePrimario.Text = "";
                                    lblCorreSecundario.Text = "";
                                    txtCorreSecundario.Text = "";
                                    btnGenerar.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de generar "+tipocomprobante+"-"+txtCorrePrimario.Text+"?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //MessageBox.Show("Comprobantes Generados", "Mensaje de Sistema", MessageBoxButtons.OK);
                string pedido = "";
                string comprobate = "";
                string guia = "";
                pedido = txtCorrePedi.Text;
                comprobate = txtCorrePrimario.Text;
                guia = txtCorreSecundario.Text;
                GrabarPedidoGenerado(pedido,comprobate,guia);
                this.Dispose();
                
            }
            else
            {
                this.Dispose();
            }
        }
        private void GrabarPedidoGenerado(string pedido,string compro, string guia)
        {
            pedidoguicomp Pedidogui = new pedidoguicomp();
            //Pedidogui.p_inidpedidoguicomp = 0;
            Pedidogui.chcodigopedido = pedido;
            Pedidogui.chguiaremision = guia;
            Pedidogui.chcomprobante = compro;
            Pedidogui.chtipocompro = tipocomprobante ;
            Pedidogui.estado = true;
            Pedidogui.chobservacion = "";
            int cod = pedidoNE.IngresoComprobantesGenerado(Pedidogui);
            
            if (cod <= 0)
            {
                MessageBox.Show("Error al generar comprobantes", "Mensaje de Sistema", MessageBoxButtons.OK);
            }else
            {
                int cc = pedidoNE.CabeceraCambiarEstado(p_inidcodigopedido, 87);
                GenerarCorrelativosComprobante(tipocomprobante);
                CargarDatos(p_inidcodigopedido, pedido,  guia,  compro);
            }
        }
        private void GenerarCorrelativosComprobante(string tipocomprobante23)
        {
            if (tipocomprobante23 == "BV")
            {
                generarCodigoNE.GenerarCorrelativoBoleta(sesion.SessionGlobal.p_inidpuntoventa);
            }
            else
            {
                if (tipocomprobante23 == "FC")
                {
                    generarCodigoNE.GenerarCorrelativoFactura(sesion.SessionGlobal.p_inidpuntoventa);
                }
                else
                {
                    if (tipocomprobante23 == "FG")
                    {
                        generarCodigoNE.GenerarCorrelativoFactura(sesion.SessionGlobal.p_inidpuntoventa);
                        generarCodigoNE.GenerarCorrelativoGuia(sesion.SessionGlobal.p_inidpuntoventa);
                    }
                    else
                    {
                        if (tipocomprobante23 == "BG")
                        {
                            generarCodigoNE.GenerarCorrelativoBoleta(sesion.SessionGlobal.p_inidpuntoventa);
                            generarCodigoNE.GenerarCorrelativoGuia(sesion.SessionGlobal.p_inidpuntoventa);
                        }
                        else
                        {
                            if (tipocomprobante23 == "GR")
                            {
                                generarCodigoNE.GenerarCorrelativoGuia(sesion.SessionGlobal.p_inidpuntoventa);
                            }
                            else
                            {
                                if (tipocomprobante23 == "NV")
                                {
                                    generarCodigoNE.GenerarCorrelativoNotaVenta(sesion.SessionGlobal.p_inidpuntoventa);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void CargarDatos( int CodigoPedidoCabecera, string pedido, string guia, string compro)
        {
            pedidocabecera pedCab = pedidoNE.PedidoCabeceraBusquedaCodigo(CodigoPedidoCabecera);
            List<tipodocumento> ListaTipdoc = tipodocumentoNE.ListarDocumentosVenta();

            Mcliente Registroscliente = clienteNE.ClienteBusquedaCodigo(pedCab.p_inidcliente);
            clientebusqueda ClienteG = clienteNE.ClienteBusquedaCodigoSecundario(Registroscliente.chcodigocliente);

           

            /*INICIO CABECERA*/
            movimientoproductoc registrosCabecera = new movimientoproductoc();
            registrosCabecera.p_inidalamacen = sesion.SessionGlobal.p_inidalmacen;
            registrosCabecera.p_inidclase = 1;
            registrosCabecera.p_inidcorrevale = valeNE.CorrelativoMovimientoSalida(sesion.SessionGlobal.p_inidalmacen);
            registrosCabecera.chvalefecha = txtfecha.Text;
            registrosCabecera.p_inidtipomoneda = pedCab.p_inidmoneda;
            registrosCabecera.p_inidproveedor = 0;
            registrosCabecera.p_inidtipomoviemiento = 8;
            registrosCabecera.chobservacion = "";
            registrosCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            registrosCabecera.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
            registrosCabecera.estado = true;
            registrosCabecera.p_inidmovimiento = 19;
            registrosCabecera.chtipref1 = "";
            registrosCabecera.chref1 = ClienteG.chcodigocliente;
            registrosCabecera.chnref1 = "CLIENTE";
            registrosCabecera.chtipref2 = "";
            registrosCabecera.chref2 = guia ;
            registrosCabecera.chnref2 = "GUIA";
            registrosCabecera.chtipref3 = "";
            registrosCabecera.chref3 = pedido;
            registrosCabecera.chnref3 = "PEDIDO";
            registrosCabecera.chtipref4 = "";
            registrosCabecera.chref4 = compro;
            registrosCabecera.chnref4 = "FACTURA";
            registrosCabecera.chtipref5 = "";
            registrosCabecera.chref5 = "";
            registrosCabecera.chnref5 = "";
            int codigoCabecera = movimientosNE.MovimientoProductoCabeceraIngresar(registrosCabecera);
            int gorrelativo = valeNE.GenerarCorrelativoMovimientoSalida(sesion.SessionGlobal.p_inidalmacen);
            /*FIN CABECERA*/



            if (sesion.pedidodetallecontenido != null)
            {
                //dgvListaPedidoDetalle.Rows.Clear();
                foreach (pedidodetallecontenido obj in sesion.pedidodetallecontenido)
                {
                    producto productoM = productoNE.ProductoBusquedaCodigo(obj.pedidodetalle.p_inidproducto);
                    string nombrecompuesto = obj.productoparaventa.chnombrecompuesto;
                    string codigo = obj.productoparaventa.chcodigoproducto;
                    int idproducto = obj.pedidodetalle.p_inidproducto;
                    decimal cantidad = obj.pedidodetalle.nucantidad;
                    decimal precio = obj.pedidodetalle.nuprecioventa;
                    decimal desc1 = obj.pedidodetalle.nuporcentajedesc1;
                    decimal desc2 = obj.pedidodetalle.nuporcentajedesc2;
                    decimal importe = obj.pedidodetalle.nuimportesubtotal;
                    decimal preunit = obj.pedidodetalle.nuprecioproducto;
                    int idserie = 0;
                    string codigoserie = "-";
                    if (obj.serie != null)
                    {
                        cantidad = 1;
                    }

                    /*INICIO*/
                    movimientoproductod registrosDetalle = new movimientoproductod();
                    //registrosDetalle.p_inidvaledetalle = 0;
                    registrosDetalle.p_inidvalecebecera = codigoCabecera;
                    registrosDetalle.p_inidproducto = obj.pedidodetalle.p_inidproducto;
                    registrosDetalle.nucantidad = cantidad;
                    registrosDetalle.nucosto = precio;
                    registrosDetalle.nutotal = obj.pedidodetalle.nuimportesubtotal;
                    int codigoDetalle = movimientosNE.MovimientoProductoDetalleIngresar(registrosDetalle);
                    int cantidad1 = int.Parse(""+cantidad)  * (-1);
                    int cantidad2 = int.Parse("" + cantidad) * (-1);
                    almacenNE.CambiarSaldoComprometido(sesion.SessionGlobal.p_inidalmacen, obj.pedidodetalle.p_inidproducto, cantidad2);
                    int entero = almacenNE.SaldoAlmacenAdiconar(sesion.SessionGlobal.p_inidalmacen, obj.pedidodetalle.p_inidproducto, cantidad2);
                     /*FIN*/       
                   
                    
                }
            }
        }
        private void GenerarMovimientoSalida()
        {
            movimientoproductoc registrosCabecera = new movimientoproductoc();
            //registrosCabecera.p_inidvalecebecera = 0;
            registrosCabecera.p_inidalamacen = sesion.SessionGlobal.p_inidalmacen;
            registrosCabecera.p_inidclase = 1;
            registrosCabecera.p_inidcorrevale = valeNE.CorrelativoMovimientoSalida(sesion.SessionGlobal.p_inidalmacen);
            registrosCabecera.chvalefecha = txtfecha.Text;
            registrosCabecera.p_inidtipomoneda = 0;
            registrosCabecera.p_inidproveedor = 0;
            //registrosCabecera.chguiaremision = txtGuiaRem.Text;
            //registrosCabecera.chboletafactura = txtFacBol.Text;
            registrosCabecera.p_inidtipomoviemiento = 10;
            registrosCabecera.chobservacion = "";
            registrosCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            registrosCabecera.estado = true;
            registrosCabecera.p_inidmovimiento = 19;
            //ingreso de cabecera


            registrosCabecera.chtipref1 = "";
            registrosCabecera.chref1 = "";
            registrosCabecera.chnref1 = "";
            registrosCabecera.chtipref2 = "";
            registrosCabecera.chref2 = "";
            registrosCabecera.chnref2 = "";
            registrosCabecera.chtipref3 = "";
            registrosCabecera.chref3 = "";
            registrosCabecera.chnref3 = "";
            registrosCabecera.chtipref4 = "";
            registrosCabecera.chref4 = "";
            registrosCabecera.chnref4 = "";
            registrosCabecera.chtipref5 = "";
            registrosCabecera.chref5 = "";
            registrosCabecera.chnref5 = "";
            int codigoCabecera = movimientosNE.MovimientoProductoCabeceraIngresar(registrosCabecera);
            int gorrelativo = valeNE.GenerarCorrelativoMovimientoSalida(sesion.SessionGlobal.p_inidalmacen);
            if (codigoCabecera <= 0 && gorrelativo <= 0)
            {

                MessageBox.Show("error Cabecera", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            else
            {
                List<movimientoproductoaccion> ListaMovimeintoDetalle = sesion.movprodaccion;
                foreach (movimientoproductoaccion RegistrosMovimeintoDetalle in ListaMovimeintoDetalle)
                {

                    if (RegistrosMovimeintoDetalle.valedet.estado == true)
                    {



                        movimientoproductod registrosDetalle = new movimientoproductod();
                        //registrosDetalle.p_inidvaledetalle = 0;
                        registrosDetalle.p_inidvalecebecera = codigoCabecera;
                        registrosDetalle.p_inidproducto = RegistrosMovimeintoDetalle.valedet.p_inidproducto;
                        registrosDetalle.nucantidad = RegistrosMovimeintoDetalle.valedet.nucantidad;
                        registrosDetalle.nucosto = RegistrosMovimeintoDetalle.valedet.nucosto;
                        registrosDetalle.nutotal = RegistrosMovimeintoDetalle.valedet.nutotal;



                        int codigoDetalle = movimientosNE.MovimientoProductoDetalleIngresar(registrosDetalle);

                        int cantidad = RegistrosMovimeintoDetalle.valedet.nucantidad * (-1);
                        int cantidad2 = RegistrosMovimeintoDetalle.valedet.nucantidad * (-1);
                        almacenNE.CambiarSaldoComprometido(sesion.SessionGlobal.p_inidalmacen, RegistrosMovimeintoDetalle.valedet.p_inidproducto, cantidad2);
                        int entero = almacenNE.SaldoAlmacenAdiconar(sesion.SessionGlobal.p_inidalmacen, RegistrosMovimeintoDetalle.valedet.p_inidproducto, cantidad);                       
                    }
                }
            }
        }      
    }
}
