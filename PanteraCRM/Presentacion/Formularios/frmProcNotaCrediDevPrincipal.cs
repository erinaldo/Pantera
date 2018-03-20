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
using Negocios;
using Presentacion.Programas;
namespace Presentacion
{
    public partial class frmProcNotaCrediDevPrincipal : Form
    {
        public frmProcNotaCrediDevPrincipal()
        {
            InitializeComponent();
        }

        private void frmProcNotaCrediDevPrincipal_Load(object sender, EventArgs e)
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
            List<tipocambio> listado2 = tipocambioNE.busquedaValorTipoCambio(txtFecha.Text);
            if (listado2 != null)
            {
                foreach (tipocambio obj2 in listado2)
                {
                    txtTipoCambio.Text = string.Format("{0:0,0.00}", obj2.nucambioventa.ToString("N2"));;
                }

            }
            else
            {
                txtTipoCambio.Text = "0.00";
            }
            btnGrabar.Enabled = false;
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
            RegistrosCabecera.chobservacion = string.Empty;
            RegistrosCabecera.chtiponotacredito = "D";
            RegistrosCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            RegistrosCabecera.p_inidusuariodelete = 0;
            RegistrosCabecera.estado = true;
            int codigocabecera = notasNE.NotaCabeceraIngresar(RegistrosCabecera);
            /*GENERAR CODIGO*/
            generarCodigoNE.GenerarCorrelativoNotaCredito(sesion.SessionGlobal.p_inidpuntoventa);
            GrabarDatosDetalle(codigocabecera);
        }

        private void GrabarDatosDetalle(int codigoCabecera)
        {
            int val = 0;
            val++;
            if (ListaPedidoContenido != null)
            {
                foreach (pedidodetallecontenido obj in ListaPedidoContenido)
                {
                    //producto productoM = productoNE.
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
                        idserie = obj.serie.p_inidserie;
                        codigoserie = obj.serie.chcodigoserie;
                    }
                    if (obj.estado == true)
                    {
                        notacreditodetalle RegistrosDetalle = new notacreditodetalle();
                        RegistrosDetalle.p_inidnotacreditoc = codigoCabecera;
                        RegistrosDetalle.initem = obj.orden;
                        RegistrosDetalle.p_inidproducto = idproducto;
                        RegistrosDetalle.p_inidserie = idserie;
                        RegistrosDetalle.nucantidad = cantidad;
                        RegistrosDetalle.nuprecio = preunit;
                        RegistrosDetalle.nudesc1 = desc1;
                        RegistrosDetalle.nudesc2 = desc2;
                        RegistrosDetalle.nuventa = precio;
                        RegistrosDetalle.nuimporte = importe;
                        RegistrosDetalle.nutotdesc = decimal.Parse(txtxDesc.Text);
                        int codigocabecera = notasNE.NotaDetalleIngresar(RegistrosDetalle);
                       // dgvListaPedidoDetalle.Rows.Add("1", "2", obj.orden, idproducto, codigo, cantidad, stock, nombrecompuesto, preunit, precio, desc1, desc2, importe, "15", idserie);
                    }
                }
            }
        }      
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListaPedidoDetalle.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }

            foreach (pedidodetallecontenido obj in ListaPedidoContenido)
            {
                if (obj.orden == (int)dgvListaPedidoDetalle.CurrentRow.Cells["CHITEM"].Value )
                {
                    obj.estado = false;
                }
            }
            CargarTablaDetalle();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListaPedidoDetalle.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            frmProcNotaCrediDevModificar f = new frmProcNotaCrediDevModificar();
            foreach (pedidodetallecontenido obj in ListaPedidoContenido)
            {
                if (obj.orden == (int)dgvListaPedidoDetalle.CurrentRow.Cells["CHITEM"].Value)
                {
                    f.PedidoDetalleContenido = obj;
                    break;
                }
            }
            f.PasadoDetalle += new frmProcNotaCrediDevModificar.PasarDetalleModificado(ModificarRegistroTabla);
            f.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void txtNroDocumento_Validated(object sender, EventArgs e)
        {
            TextBox TextoUsado = (TextBox)sender;
            utilidades.ValidarCampoDocumento(ref TextoUsado,e);
            ValidarComprobante();
        }

        private void txtNroDocumento_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { utilidades.SetTextBoxSelectAll((TextBox)sender); });
        }
        private void ModificarRegistroTabla(pedidodetallecontenido PedidoContenido, int orden)
        {
            foreach (pedidodetallecontenido obj in ListaPedidoContenido)
            {
                if (obj.orden == orden)
                {
                    obj.pedidodetalle = PedidoContenido.pedidodetalle;
                    break;
                }
            }
            CargarTablaDetalle();
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
        private void ValidarComprobante()
        {
            if (cboTipdoc.Text == "FC")
            {
                busquedaDocumento("F");
                
            }else if (cboTipdoc.Text == "BV")
            {
                busquedaDocumento("B");
            }
            else
            {
                busquedaDocumento("NV");
            }
        }
        internal pedidoguicomp PedidoFacturado = null;
        private void busquedaDocumento(string parametro){
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

            dgvListaPedidoDetalle.Rows.Clear();
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
                dgvListaPedidoDetalle.Rows.Clear();
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
                        dgvListaPedidoDetalle.Rows.Add("1", "2", obj.orden, idproducto, codigo, cantidad, stock, nombrecompuesto, preunit, precio, desc1, desc2, importe, "15", idserie);
                    }
                }
                GenerarTotales();
            }
        }
        public void GenerarTotales()
        {
            if (dgvListaPedidoDetalle.RowCount > 0)
            {
                decimal importe = 0;
                decimal preciprod = 0;
                int cantidad = 0;
                decimal preciototal = 0;
                decimal valorigv = decimal.Parse("1.18");
                List<pedidodetalle> listado = new List<pedidodetalle>();
                for (int i = 0; i < dgvListaPedidoDetalle.RowCount; i++)
                {
                    //precio += decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["CHPRECIO"].Value.ToString());
                    importe += decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUIMPORTE"].Value.ToString());
                    preciprod = decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUPRECIOVENTA"].Value.ToString());
                    cantidad = int.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUCANTIDAD"].Value.ToString());
                    preciototal += (decimal.Round(cantidad * preciprod, 2) / valorigv);
                    //(100+ decimal.Parse(cboigv.Text))/100)
                }

                txtValorTotal.Text = string.Format("{0:0,0.00}", importe);
                decimal valorventa = decimal.Round(importe / valorigv, 2);
                txtValorVenta.Text = string.Format("{0:0,0.00}", valorventa);
                decimal igv = importe - valorventa;
                txtIgv.Text = string.Format("{0:0,0.00}", igv);

                decimal tdescuentototal = decimal.Round(preciototal - valorventa, 2);
                txtxDesc.Text = string.Format("{0:0,0.00}", tdescuentototal);
                txtSubTotal.Text = string.Format("{0:0,0.00}", decimal.Round(preciototal, 2));
            }
            else{
                txtValorTotal.Text = "0.00";
                txtValorVenta.Text = "0.00";
                txtxDesc.Text = "0.00";
                txtIgv.Text = "0.00";
                txtSubTotal.Text = "0.00";
                btnGrabar.Enabled = false;
            }
        }


    }
}
