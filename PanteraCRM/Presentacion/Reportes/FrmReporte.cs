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
        internal string  codigopedido;
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
            CargarDatosCorrelativos();
        }
        private void CargarDatosCorrelativos()
        {
            txtfecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            txtCorrePedi.Text = codigopedido;
            if (tipocomprobante == "BV")
            {
                lblCorrePrimario.Text = "BV";
                txtCorrePrimario.Text = generarCodigoNE.ObtenerCorrelativoBoleta(sesion.SessionGlobal.p_inidpuntoventa);
                lblCorreSecundario.Visible = false;
                txtCorreSecundario.Visible = false;
            }else
            {
                if (tipocomprobante == "FC")
                {
                    lblCorrePrimario.Text = "FC";
                    txtCorrePrimario.Text = generarCodigoNE.ObtenercorrelativoFactura(sesion.SessionGlobal.p_inidpuntoventa);
                    lblCorreSecundario.Visible = false;
                    txtCorreSecundario.Visible = false;
                }
                else
                {
                    if (tipocomprobante == "FG")
                    {
                        lblCorrePrimario.Text = "FC";
                        txtCorrePrimario.Text = generarCodigoNE.ObtenercorrelativoFactura(sesion.SessionGlobal.p_inidpuntoventa);
                        lblCorreSecundario.Text = "GR";
                        txtCorreSecundario.Text = generarCodigoNE.ObtenerCorrelativoGuia(sesion.SessionGlobal.p_inidpuntoventa);                        
                    }
                    else
                    {
                        if (tipocomprobante == "BG")
                        {
                            lblCorrePrimario.Text = "BV";
                            txtCorrePrimario.Text = generarCodigoNE.ObtenerCorrelativoBoleta(sesion.SessionGlobal.p_inidpuntoventa);
                            lblCorreSecundario.Text = "GR";
                            txtCorreSecundario.Text = generarCodigoNE.ObtenerCorrelativoGuia(sesion.SessionGlobal.p_inidpuntoventa);
                        }
                        else
                        {
                            if (tipocomprobante == "GR")
                            {
                                lblCorrePrimario.Visible = false;
                                txtCorrePrimario.Visible = false;
                                lblCorreSecundario.Text = "GR";
                                txtCorreSecundario.Text = generarCodigoNE.ObtenerCorrelativoGuia(sesion.SessionGlobal.p_inidpuntoventa);

                            }
                            else
                            {
                                if (tipocomprobante == "NV")
                                {
                                    lblCorrePrimario.Text = "NV";
                                    txtCorrePrimario.Text = generarCodigoNE.ObtenerCorrelativoNotaVenta(sesion.SessionGlobal.p_inidpuntoventa);
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
        private void GrabarPedidoGenerado(string pedido,string guia,string compro)
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
                if (cc > 0 )
                {
                    MessageBox.Show("Error al generar comprobantes" +cc, "Mensaje de Sistema", MessageBoxButtons.OK);
                }
            }
        }
    }
}
