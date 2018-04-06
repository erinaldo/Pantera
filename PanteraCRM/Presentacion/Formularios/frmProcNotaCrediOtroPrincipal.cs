using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Presentacion.Programas;
using Negocios;
namespace Presentacion
{
    public partial class frmProcNotaCrediOtroPrincipal : Form
    {
        public frmProcNotaCrediOtroPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmProcNotaCrediOtroPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            GenerarDatosCabecera();
        }
        private void GenerarDatosCabecera()
        {
            string correlativo = generarCodigoNE.ObtenerCorrelativoNotaCredito(sesion.SessionGlobal.p_inidpuntoventa);
            txtNotaCorrelativo.Text = correlativo;
            txtFecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            cboTipdoc.DataSource = tipodocumentoNE.ListarTipoDocumentosVentaParametro(true);
            cboTipdoc.ValueMember = "p_inidtipodocumento";
            cboTipdoc.DisplayMember = "chacrominodocumento";
            txtNotaDescuento.Text = "00.00";
            List<tipocambio> listado2 = tipocambioNE.busquedaValorTipoCambio(txtFecha.Text);
            if (listado2 != null)
            {
                foreach (tipocambio obj2 in listado2)
                {
                    txtTipoCambio.Text = string.Format("{0:0,0.00}", obj2.nucambioventa.ToString("N2")); ;
                }

            }
            else
            {
                txtTipoCambio.Text = "0.00";
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "G";
                if (basicas.validarAcceso(vBoton))
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        GrabarDatosCabecera();
                        this.Dispose();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Error de Acceso", "Mensaje de Sistema", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
        private void GrabarDatosCabecera()
        {
            notacreditocabecera RegistrosCabecera = new notacreditocabecera();
            RegistrosCabecera.chcorrelativo = txtNotaCorrelativo.Text;
            RegistrosCabecera.chfechanota = txtFecha.Text;
            RegistrosCabecera.p_inidpedido = pedCab.p_inidpedidocabecera;
            RegistrosCabecera.p_inidcliente = pedCab.p_inidcliente;
            RegistrosCabecera.p_iniddocreferencia = PedidoFacturado.p_inidpedidoguicomp;
            RegistrosCabecera.chfechareferencia = pedCab.chfechapedido;
            RegistrosCabecera.chobservacion = txtOtros.Text;
            RegistrosCabecera.chtiponotacredito = "O";
            RegistrosCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            RegistrosCabecera.p_inidusuariodelete = 0;
            RegistrosCabecera.estado = true;
            int codigocabecera = notasNE.NotaCabeceraIngresar(RegistrosCabecera);
            /*GENERAR CODIGO*/
            generarCodigoNE.GenerarCorrelativoNotaCredito(sesion.SessionGlobal.p_inidpuntoventa);
            /* INICIO :: AGREGAR AL REGISTRO DE VENTA*/
            RegistroVenta registrosVenta = new RegistroVenta();
            registrosVenta.p_inidpuntoventa = sesion.SessionGlobal.p_inidpuntoventa;
            registrosVenta.p_inidtipodocu = 4;
            registrosVenta.p_iniddocumento = pedCab.p_inidpedidocabecera;
            registrosVenta.chcodigodocu = txtNotaCorrelativo.Text;
            registrosVenta.chfechadoc = txtFechaCompro.Text;
            registrosVenta.p_inidcliente = pedCab.p_inidcliente;
            registrosVenta.nucambioventa = decimal.Parse(txtTipoCambio.Text);
            registrosVenta.nuimporvtaafecta = decimal.Parse(txtValorVenta.Text);
            registrosVenta.nuimportotdesc = decimal.Parse(txtxDesc.Text);
            registrosVenta.nuimporttotigv = decimal.Parse(txtIgv.Text);
            registrosVenta.nuimportetotvta = decimal.Parse(txtValorTotal.Text);
            registrosVenta.tipomovimiento = "H";
            registrosVenta.chfechaventa = txtFecha.Text;
            registrosVenta.p_inidsituacionregistro = 0;
            registrosVenta.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            registrosVenta.p_inidusuariodelete = 0;
            registrosVenta.estado = true;
            pedidoNE.IngresoRegistroVenta(registrosVenta);
            /* FIN :: AGREGAR AL REGISTRO DE VENTA*/
            //GrabarDatosDetalle(codigocabecera);
        }


        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TextoUsado = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (TextoUsado.Text.Length >= 10)
            {
                e.Handled = true;
            }
            if (TextoUsado.SelectionLength > 0)
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }

        private void txtNroDocumento_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { utilidades.SetTextBoxSelectAll((TextBox)sender); });
        }

        private void txtNroDocumento_Validated(object sender, EventArgs e)
        {
            TextBox TextoUsado = (TextBox)sender;
            utilidades.ValidarCampoDocumento(ref TextoUsado, e);
            ValidarComprobante();
        }
        private void ValidarComprobante()
        {
            if (cboTipdoc.Text == "FC")
            {
                busquedaDocumento("F");

            }
            else if (cboTipdoc.Text == "BV")
            {
                busquedaDocumento("B");
            }
            else
            {
                busquedaDocumento("NV");
            }
        }
        internal pedidoguicomp PedidoFacturado = null;
        private void busquedaDocumento(string parametro)
        {
            PedidoFacturado = pedidoNE.BuscarComprobantesFacturados(parametro, txtNroDocumento.Text);
            if (PedidoFacturado.chcodigopedido != "")
            {
                CargarDatosCabecera(PedidoFacturado.p_inidpedidoguicomp);
            }
            else
            {
                BalquearCampos();

            }
        }
        private void PonerVendedor(int codigo)
        {
            usuario usuario = usuarioNE.buscarPorCodigo(codigo);
            persona Persona = personaNE.PersonaBusquedaCodigo(usuario.p_inidpersona);
            if (Persona.p_inidpersona != 0)
            {
                txtVendedor.Text = Persona.chapellidopaterno + " " + Persona.chapellidomaterno + ", " + Persona.chnombres;
            }
            else
            {
                txtVendedor.Text = "NO ENCONTRADO";
            }
        }
        internal List<pedidodetallecontenido> ListaPedidoContenido;
        internal pedidocabecera pedCab;
        internal List<pedidodetalle> peddet;
        private void CargarDatosCabecera(int codigo)
        {
            btnGrabar.Enabled = true;
            pedCab = pedidoNE.PedidoCabeceraBusquedaCodigo(codigo);
            peddet = pedidoNE.PedidoDetalleBusquedaParametro(codigo);
            ListaPedidoContenido = new List<pedidodetallecontenido>();
            foreach (pedidodetalle obj in peddet)
            {
                pedidodetallecontenido RegistroPed = new pedidodetallecontenido();
                RegistroPed.orden = int.Parse(obj.chitem);
                RegistroPed.pedidodetalle = obj;
                serie registrosserie = serieNE.SerieBusquedaCodigo(obj.p_inidserie);
                if (registrosserie.p_inidserie == 0) { registrosserie = null; }
                RegistroPed.serie = registrosserie;
                producto prod = productoNE.ProductoBusquedaCodigo(obj.p_inidproducto);
                RegistroPed.productoparaventa = productoNE.ProductosVentaParametro(prod.chcodigoproducto);
                RegistroPed.estado = true;
                ListaPedidoContenido.Add(RegistroPed);
            }
            //sesion.pedidodetallecontenido = ListaPedidoContenido;
            Mcliente Registroscliente = clienteNE.ClienteBusquedaCodigo(pedCab.p_inidcliente);
            BuscarClienteCodigo(Registroscliente.chcodigocliente);
            txtFechaCompro.Text = pedCab.chfechapedido;
            PonerVendedor(pedCab.p_inidusuarioinsert);
            //CargarTablaDetalle();
        }

        private void BuscarClienteCodigo(string codigo)
        {
            clientebusqueda ClienteG = clienteNE.ClienteBusquedaCodigoSecundario(codigo);

            // MessageBox.Show(""+ClienteG1.p_inidcodigoclie, "Mensaje de Sistema", MessageBoxButtons.OK);
            if (ClienteG != null)
            {
                //ClienteG = ClienteG1;
                txtClieCodigo.Text = ClienteG.chcodigocliente;
                txtRazon.Text = ClienteG.razon;
                txtRuc.Text = ClienteG.nrodocumento;

            }
        }
        private void BalquearCampos()
        {
            
            txtValorTotal.Text = string.Empty;
            txtValorVenta.Text = string.Empty;
            txtxDesc.Text = string.Empty;
            txtVendedor.Text = string.Empty;
            txtIgv.Text = string.Empty;
            txtClieCodigo.Text = string.Empty;
            txtRazon.Text = string.Empty;
            txtRuc.Text = string.Empty;
            txtFechaCompro.Text = string.Empty;
            txtSubTotal.Text = string.Empty;
            btnGrabar.Enabled = false;
        }
        internal decimal importeG;
        internal decimal DescuentoG=0;
        private void CargarTablaDetalle()
        {
            int val = 0;
            val++;
            importeG = 0;
            if (ListaPedidoContenido != null)
            {                
                decimal valorigvx = decimal.Parse("1.18");

                foreach (pedidodetallecontenido obj in ListaPedidoContenido)
                {
                    importeG += obj.pedidodetalle.nuimportesubtotal * (DescuentoG)/100;                    
                }
                txtValorTotal.Text = string.Format("{0:0,0.00}", importeG);
                decimal valorventax = decimal.Round(importeG / valorigvx, 2);
                txtValorVenta.Text = string.Format("{0:0,0.00}", valorventax);
                decimal igv = importeG - valorventax;
                txtIgv.Text = string.Format("{0:0,0.00}", igv);
                txtxDesc.Text = "0.00";
                txtSubTotal.Text = string.Format("{0:0,0.00}", decimal.Round(valorventax, 2));
            }
        }
   
        private void txtNotaDescuento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MaskedTextBox TextoUsado = (MaskedTextBox)sender;
            decimal pordesc = 0;
            if (TextoUsado.Text.Length > 0)
            {
                pordesc = decimal.Parse(TextoUsado.Text);
            }
            DescuentoG = pordesc;
            CargarTablaDetalle();

        }
        private void txtNotaDescuento_Leave(object sender, EventArgs e)
        {
            MaskedTextBox TextoUsado = (MaskedTextBox)sender;
            decimal pordesc = 0;
            if (TextoUsado.Text.Length > 0)
            {
                pordesc = decimal.Parse(TextoUsado.Text);
            }
            DescuentoG = pordesc;
            CargarTablaDetalle();
        }      
    }
}
