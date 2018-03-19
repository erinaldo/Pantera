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
            CargarTablaDetalle();
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
        private void CargarTablaDetalle()
        {
            int val = 0;
            val++;
            if (ListaPedidoContenido != null)
            {
                decimal importex = 0;
                decimal preciprodx = 0;
                int cantidadx = 0;
                decimal preciototalx = 0;
                decimal valorigvx = decimal.Parse("1.18");

                foreach (pedidodetallecontenido obj in ListaPedidoContenido)
                {
                    //producto productoM = productoNE.
                    string nombrecompuesto = obj.productoparaventa.chnombrecompuesto;
                    string codigo = obj.productoparaventa.chcodigoproducto;
                    int idproducto = obj.pedidodetalle.p_inidproducto;
                    int cantidad = Decimal.ToInt32(obj.pedidodetalle.nucantidad);
                    decimal stock = 0;// ProductoM.nustock;
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
                        idserie = obj.serie.p_inidserie;
                        codigoserie = obj.serie.chcodigoserie;
                    }
                    if (obj.estado == true)
                    {
                        //dgvListaPedidoDetalle.Rows.Add("1", "2", obj.orden, idproducto, codigo, cantidad, stock, nombrecompuesto, preunit, precio, desc1, desc2, importe, "15", idserie);
                        
                            importex += importe;
                            preciprodx = preunit;
                            cantidadx = cantidad;
                            preciototalx += (decimal.Round(cantidadx * preciprodx, 2) / valorigvx);
                       
                        
                    }
                }
                txtValorTotal.Text = string.Format("{0:0,0.00}", importex);
                decimal valorventax = decimal.Round(importex / valorigvx, 2);
                txtValorVenta.Text = string.Format("{0:0,0.00}", valorventax);
                decimal igv = importex - valorventax;
                txtIgv.Text = string.Format("{0:0,0.00}", igv);

                decimal tdescuentototal = decimal.Round(preciototalx - valorventax, 2);
                txtxDesc.Text = string.Format("{0:0,0.00}", tdescuentototal);
                txtSubTotal.Text = string.Format("{0:0,0.00}", decimal.Round(preciototalx, 2));
            }
        }
      
    }
}
