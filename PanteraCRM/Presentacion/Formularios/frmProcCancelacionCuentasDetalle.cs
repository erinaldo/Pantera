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
    public partial class frmProcCancelacionCuentasDetalle : Form
    {

        public delegate void pasar(int varible);
        public event pasar pasado;
        internal string RazonG;
        internal string NroDocG;
        internal string codigoG;
        internal int p_inidCliente;
        internal recibo ReciboG;
        internal placobc PlacobCabeceraG;
        internal placobd PlacobDetalleG;
        public frmProcCancelacionCuentasDetalle()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmProcCancelacionCuentasDetalle_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            CargarDatosRegistros();
            TotalesDgvPediente();
            TotalesDgvSeleccion();
        }
        private void CargarDatosRegistros()
        {
            rbtcancela.Checked = true;
            txtRazon.Text = RazonG;
            txtnroDocu.Text = NroDocG;
            txtCodigo.Text = codigoG;
            txtfecharegi.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            cboBanco.DataSource =bancoNE.BancoListar();
            cboBanco.ValueMember = "p_inidbanco";
            cboBanco.DisplayMember = "chnombrebanco";
            cboMoneda.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(13);
            cboMoneda.ValueMember = "idmaestrodetalle";
            cboMoneda.DisplayMember = "nombreitem";
            cbotipoPago.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(24);
            cbotipoPago.ValueMember = "idmaestrodetalle";
            cbotipoPago.DisplayMember = "nombreitem";
            txtImport.Text = "0.00";
            txtInter.Text = "0.00";
            int index3 = cbotipoPago.FindString("PAGO EN EFECTIVO");
            cbotipoPago.SelectedIndex = index3;
            //string correlativo = generarCodigoNE.ObtenerCorrelativo(sesion.SessionGlobal.p_inidpuntoventa);
           
            List<tipocambio> listado2 = tipocambioNE.busquedaValorTipoCambio(txtfecharegi.Text);
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
        internal bool validacionNC = true;
        internal bool validacionCV = true;
        private void CargarDatosTabla()
        {
            validacionNC = true;
            validacionCV = true;
            dgvDocumentosPendientes.Rows.Clear();
            dgvDocumentosSeleccionados.Rows.Clear();
            List<RegistroVenta> RegistroVenta = new List<RegistroVenta>();
            RegistroVenta = pedidoNE.BuscarRegistroVentasCliente(p_inidCliente);
            foreach (RegistroVenta Registros in RegistroVenta)
            {
                if ( Registros.p_inidtipodocu == 4)
                {
                    decimal montoencontra = pedidoNE.BuscarDocNCCodigo(Registros.chcodigodocu);
                    if ((Registros.nuimportetotvta - montoencontra) > 0)
                    {
                        dgvDocumentosPendientes.Rows.Add(Registros.p_inidregistroventa ,Registros.p_inidtipodocu, DevolverNombrecomprobante(Registros.p_inidtipodocu), Registros.chcodigodocu, "", Registros.chfechadoc, "S/.", (-1) * (Registros.nuimportetotvta - montoencontra));
                    }
                    
                }
                else
                {
                    decimal montoencontra = pedidoNE.BuscarMontoEncontra(Registros.p_inidtipodocu, Registros.chcodigodocu, Registros.p_inidcliente);
                    if ((Registros.nuimportetotvta - montoencontra)>0)
                    {
                        dgvDocumentosPendientes.Rows.Add(Registros.p_inidregistroventa,Registros.p_inidtipodocu, DevolverNombrecomprobante(Registros.p_inidtipodocu), Registros.chcodigodocu, "", Registros.chfechadoc, "S/.", Registros.nuimportetotvta- montoencontra);
                    }
                    
                }

            }
        }
        private decimal ValidarRegistrosVentaPagados( )
        {
            return 1;

        }
        private string DevolverNombrecomprobante(int codigo)
        {
            tipodocumento tipodocumentos = tipodocumentoNE.documentoVentaBusquedacodigo(codigo);
            return tipodocumentos.chacrominodocumento;
        }
        
        private void dgvDocumentosPendientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (rbtcancela.Checked)
            {
                if (dgvDocumentosPendientes.CurrentRow.Cells["CHTIPO"].Value.ToString() != "NC")
                {
                    dgvDocumentosSeleccionados.Rows.Add(
                        dgvDocumentosPendientes.CurrentRow.Cells["CODVTA"].Value,
                        dgvDocumentosPendientes.CurrentRow.Cells["CODTIPO"].Value,
                                dgvDocumentosPendientes.CurrentRow.Cells["CHTIPO"].Value,
                                dgvDocumentosPendientes.CurrentRow.Cells["CHDOC"].Value,
                                dgvDocumentosPendientes.CurrentRow.Cells["CHREN"].Value,
                                dgvDocumentosPendientes.CurrentRow.Cells["CHFECHA"].Value,
                                dgvDocumentosPendientes.CurrentRow.Cells["CHMONE"].Value,
                                dgvDocumentosPendientes.CurrentRow.Cells["NUMONTO"].Value);
                    dgvDocumentosPendientes.Rows.RemoveAt(e.RowIndex);
                    TotalesDgvPediente();
                    TotalesDgvSeleccion();
                }else
                {
                    MessageBox.Show("No se permite cancelar una Nota de Credito", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                }

            }
            if(rbtCanje.Checked)
            {
                if ((decimal)dgvDocumentosPendientes.CurrentRow.Cells["NUMONTO"].Value < 0 )
                {
                    if (validacionNC)
                    {
                        dgvDocumentosSeleccionados.Rows.Add(
                            dgvDocumentosPendientes.CurrentRow.Cells["CODVTA"].Value,
                            dgvDocumentosPendientes.CurrentRow.Cells["CODTIPO"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["CHTIPO"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["CHDOC"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["CHREN"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["CHFECHA"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["CHMONE"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["NUMONTO"].Value);
                        dgvDocumentosPendientes.Rows.RemoveAt(e.RowIndex);
                        TotalesDgvPediente();
                        TotalesDgvSeleccion();
                        validacionNC = false;
                    }else
                    {
                        MessageBox.Show("Solo se puede canjear un documento de venta ", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (validacionCV)
                    {
                        dgvDocumentosSeleccionados.Rows.Add(
                            dgvDocumentosPendientes.CurrentRow.Cells["CODVTA"].Value,
                            dgvDocumentosPendientes.CurrentRow.Cells["CODTIPO"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["CHTIPO"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["CHDOC"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["CHREN"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["CHFECHA"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["CHMONE"].Value,
                                    dgvDocumentosPendientes.CurrentRow.Cells["NUMONTO"].Value);
                        dgvDocumentosPendientes.Rows.RemoveAt(e.RowIndex);
                        TotalesDgvPediente();
                        TotalesDgvSeleccion();
                        validacionCV = false;
                    }else
                    {
                        MessageBox.Show("Solo se puede canjear un documento de venta ", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    }
                }                
            }           
        }

        private void dgvDocumentosSeleccionados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
        /*INICIO :: FUNCIONES BASES*/
        private void TotalesDgvPediente()
        {
            if (dgvDocumentosPendientes.RowCount > 0)
            {
                decimal total1 = 0;
                for (int i = 0; i < dgvDocumentosPendientes.RowCount; i++)
                {
                    total1 += decimal.Parse(dgvDocumentosPendientes.Rows[i].Cells["NUMONTO"].Value.ToString());
                }
                txtTotalPendiente.Text = total1.ToString("N2");
            }
            else
            {
                txtTotalPendiente.Text = "0.00";
            }

        }
        private void TotalesDgvSeleccion()
        {
            if (dgvDocumentosSeleccionados.RowCount > 0)
            {
                decimal total1 = 0;
                for (int i = 0; i < dgvDocumentosSeleccionados.RowCount; i++)
                {
                    total1 += decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString());
                }
                txttotalSeleccion.Text = total1.ToString("N2");
            }
            else
            {
                txttotalSeleccion.Text = "0.00";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
            {
                DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GrabarCabecera();
                    pasado(p_inidCliente);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            this.Dispose();
        }
        private bool Validacion()
        {
            bool flat = true;
            if (rbtcancela.Checked == true)
            {
                if (txtCheque.Text.Length > 0 && cbotipoPago.Text != "PAGO EN EFECTIVO")
                {
                    if (txtImport.Text.Length > 0 && decimal.Parse(txtImport.Text) != 0)
                    {
                        if (txtInter.Text.Length > 0)
                        {
                            if ((decimal.Parse(txtImport.Text) + decimal.Parse(txtInter.Text)) <= decimal.Parse(txttotalSeleccion.Text))
                            {
                                flat = false;
                            }
                            else
                            {
                                MessageBox.Show("El importe a pagar excede al monto seleccionado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Interés y comisión inválido", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Importe a pagar inválido", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("N° cheque vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                }
            }else
            {
                if (decimal.Parse(txttotalSeleccion.Text) >= 0)
                {
                    if (dgvDocumentosSeleccionados.RowCount == 2)
                    {
                        flat = false;
                    }
                    else
                    {
                        MessageBox.Show("Falta agregar un documento", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    }                    
                }else
                {
                    MessageBox.Show("Error", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                }
            }
            return flat;
        }
        private void GrabarCabecera()
        {
            /*INGRESO PLANILLA COBROS*/
            placobc Registros = new placobc();
            Registros =  pedidoNE.PlanillacobroCabeceraBusqueda(txtfecharegi.Text);
            if (Registros.p_inidplacoc == 0)
            {
                PlacobCabeceraG = new placobc();
                PlacobCabeceraG.chcorreplacobc = "";
                PlacobCabeceraG.chfecha = txtfecharegi.Text;
                PlacobCabeceraG.nuimporplamonenac = 0;
                PlacobCabeceraG.nuimporplanomeex = 0;
                PlacobCabeceraG.chreferencia = string.Empty;
                PlacobCabeceraG.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                PlacobCabeceraG.p_inidusuariodelete = 0;
                PlacobCabeceraG.estado = true;
                int CodigoCabecera = pedidoNE.IngresoPlacobCabecera(PlacobCabeceraG);
                Registros = pedidoNE.PlanillacobroCabeceraBusqueda(txtfecharegi.Text);
                GrabarDetalle(Registros.p_inidplacoc,Registros.chcorreplacobc);
            }
            else
            {
                GrabarDetalle(Registros.p_inidplacoc, Registros.chcorreplacobc);
            }
            /*INGRESO RECIBOS*/
            ReciboG = new recibo();
            ReciboG.p_inidpagocomprocabecera = Registros.p_inidplacoc;
            ReciboG.chcodigorecibo = txtCorrela.Text;
            ReciboG.chfecharecibo = txtfecharegi.Text;
            ReciboG.p_inidtipopago = (int)cbotipoPago.SelectedValue;
            ReciboG.nuimporterecalculo =decimal.Parse(txtImport.Text);
            ReciboG.nuimporteinteres =  decimal.Parse(txtInter.Text);
            ReciboG.p_inidcliente = p_inidCliente;
            ReciboG.p_inidmoneda = (int)cboMoneda.SelectedValue;
            ReciboG.p_inidbanco = (int)cboBanco.SelectedValue;
            ReciboG.chcheque = txtCheque.Text;
            ReciboG.p_inidsituacionregistro = (int)cbotipoPago.SelectedValue;
            if (rbtcancela.Checked) { ReciboG.p_inidtipomovimiento = 1; } else { ReciboG.p_inidtipomovimiento = 2; }
            ReciboG.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            ReciboG.p_inidurusariodelete = 0;
            ReciboG.estado = true;
            pedidoNE.IngresoRecibo(ReciboG);
            pedidoNE.ModificarPlanicobroCabecera(Registros.p_inidplacoc, decimal.Parse(txtImport.Text),0);
        }
        private void GrabarDetalle(int CodigoCabecera, string correlativo)
        {
            if (rbtcancela.Checked)
            {
                /*PARA CANCELAR*/
                bool flat = false;
                bool validarnegativo = true;
                int item = 0;
                int codventa = 0;
                decimal pago = decimal.Parse(txtImport.Text);
                decimal importe = decimal.Parse(txttotalSeleccion.Text);
                for (int i = 0; i < dgvDocumentosSeleccionados.RowCount; i++)
                {
                    codventa = (int)dgvDocumentosSeleccionados.Rows[i].Cells["CODVTAS"].Value;
                    pago -= decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString());
                    int tipopago = 0;
                    if (pago >= 0)
                    {
                        tipopago = 1;
                    }else
                    {
                        tipopago = 0;
                    }
                    PlacobDetalleG = new placobd();
                    PlacobDetalleG.p_inidplacoc = CodigoCabecera;
                    PlacobDetalleG.chcorreplacobc = correlativo;
                    PlacobDetalleG.chcorrerecibo = txtCorrela.Text;
                    PlacobDetalleG.initem = item++;
                    PlacobDetalleG.p_inidcliente = p_inidCliente;
                    PlacobDetalleG.p_inidtipodoc = (int)dgvDocumentosSeleccionados.Rows[i].Cells["CODTIPOS"].Value;
                    PlacobDetalleG.chcorredocumento = dgvDocumentosSeleccionados.Rows[i].Cells["CHDOCS"].Value.ToString();
                    PlacobDetalleG.chfecha = txtFechaCancel.Text;
                    PlacobDetalleG.nuimporpendiente = decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString());
                    PlacobDetalleG.p_inidmoneda = (int)cboMoneda.SelectedValue;
                    PlacobDetalleG.p_inidmonedapag = (int)cboMoneda.SelectedValue;
                    PlacobDetalleG.nuimporpagmonenac = decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString());
                    PlacobDetalleG.nuimporpagmoneext = decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString()) * decimal.Parse(txtTipoCambio.Text);
                    PlacobDetalleG.nuimporcamvta = decimal.Parse(txtTipoCambio.Text);
                    PlacobDetalleG.p_inidtipopag = tipopago;//pendiente = 0, cancelado = 1;
                    PlacobDetalleG.chobservacion = string.Empty;
                    if (rbtcancela.Checked) { PlacobDetalleG.p_inidtipomov = 1; } else { PlacobDetalleG.p_inidtipomov = 2; }
                    PlacobDetalleG.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                    PlacobDetalleG.p_inidusuariodelete = 0;
                    PlacobDetalleG.estado = true;


                    if (pago >= 0)
                    {
                        PlacobDetalleG.p_inidtipopag = 1;
                        
                        flat = true;
                    }
                    else
                    {
                        flat = false;
                        if (validarnegativo)
                        {
                            PlacobDetalleG.nuimporpagmonenac = decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString()) + pago;
                            PlacobDetalleG.nuimporpagmoneext = PlacobDetalleG.nuimporpagmonenac * decimal.Parse(txtTipoCambio.Text);
                            PlacobDetalleG.p_inidtipopag = 0;
                        }

                    }
                    if (flat)
                    {
                        int codssigo = pedidoNE.IngresoPlacobDetalle(PlacobDetalleG); 
                        int car = pedidoNE.RegistroVentaPagar(codventa, "" + DateTime.Now.ToShortDateString().PadLeft(10, '0'), tipopago, "" + DateTime.Now.ToLongTimeString());
                        //MessageBox.Show("Error " + DateTime.Now.ToShortDateString().PadLeft(10, '0'), "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (validarnegativo)
                        {
                            int codssigo = pedidoNE.IngresoPlacobDetalle(PlacobDetalleG);
                            validarnegativo = false;
                            int car = pedidoNE.RegistroVentaPagar(codventa, "" + DateTime.Now.ToShortDateString().PadLeft(10, '0'), tipopago, "" + DateTime.Now.ToLongTimeString());
                            
                                //MessageBox.Show("Error "+ DateTime.Now.ToShortDateString().PadLeft(10, '0'), "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            
                        }
                    }
                }
            }
            else
            {
                /*PARA CANJEAR*/
                decimal montoacumulado = 0;
                decimal montodescargado = 0;
                string correla = "";
                string fechas = "";
                for (int i = 0; i < dgvDocumentosSeleccionados.RowCount; i++)
                {
                    montoacumulado += decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString());
                    if (dgvDocumentosSeleccionados.Rows[i].Cells["CHTIPOS"].Value.ToString() == "NC")
                    {
                        montodescargado += decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString()) * (-1);
                    } else
                    {
                        correla = dgvDocumentosSeleccionados.Rows[i].Cells["CHDOCS"].Value.ToString();
                        fechas = dgvDocumentosSeleccionados.Rows[i].Cells["CHFECHAS"].Value.ToString();
                    }
                }
                int codventa =0;
                int tipopago = 0;
                if (montoacumulado == 0)
                {
                    tipopago = 2;//canjeado completo
                }else
                {
                    tipopago = 3; // canjeado parcial
                }
                decimal montofinal = 0;
                    int item = 0;
                for (int i = 0; i < dgvDocumentosSeleccionados.RowCount; i++)
                {
                    if (dgvDocumentosSeleccionados.Rows[i].Cells["CHTIPOS"].Value.ToString() != "NC")
                    {
                        codventa = (int)dgvDocumentosSeleccionados.Rows[i].Cells["CODVTAS"].Value;
                        PlacobDetalleG = new placobd();
                        PlacobDetalleG.p_inidplacoc = CodigoCabecera;
                        PlacobDetalleG.chcorreplacobc = correlativo;
                        PlacobDetalleG.chcorrerecibo = txtCorrela.Text;
                        PlacobDetalleG.initem = item++;
                        PlacobDetalleG.p_inidcliente = p_inidCliente;
                        PlacobDetalleG.p_inidtipodoc = (int)dgvDocumentosSeleccionados.Rows[i].Cells["CODTIPOS"].Value;
                        PlacobDetalleG.chcorredocumento = dgvDocumentosSeleccionados.Rows[i].Cells["CHDOCS"].Value.ToString();
                        PlacobDetalleG.chfecha = txtFechaCancel.Text;
                        PlacobDetalleG.nuimporpendiente = decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString());
                        PlacobDetalleG.p_inidmoneda = (int)cboMoneda.SelectedValue;
                        PlacobDetalleG.p_inidmonedapag = (int)cboMoneda.SelectedValue;
                        montofinal = (montodescargado) + (decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString()) - montodescargado);
                        PlacobDetalleG.nuimporpagmonenac = montofinal;
                        PlacobDetalleG.nuimporpagmoneext = decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString()) * decimal.Parse(txtTipoCambio.Text);
                        PlacobDetalleG.nuimporcamvta = decimal.Parse(txtTipoCambio.Text);
                        PlacobDetalleG.p_inidtipopag = tipopago;//pendiente = 0, cancelado = 1;
                        PlacobDetalleG.chobservacion = string.Empty;
                        if (rbtcancela.Checked) { PlacobDetalleG.p_inidtipomov = 1; } else { PlacobDetalleG.p_inidtipomov = 2; }
                        PlacobDetalleG.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                        PlacobDetalleG.p_inidusuariodelete = 0;
                        PlacobDetalleG.estado = true;
                        int codssigo = pedidoNE.IngresoPlacobDetalle(PlacobDetalleG);
                       pedidoNE.RegistroVentaPagar(codventa, ""+DateTime.Now.ToShortDateString().PadLeft(10, '0'), tipopago,""+ DateTime.Now.ToLongTimeString());
                        
                        
                    }
                    else
                    {
                        docnc Registrosdoc = new docnc();
                        Registrosdoc.chcorreladoc = correla;
                        Registrosdoc.chfechacancel = fechas;
                        Registrosdoc.p_inidnotacredito = (int)dgvDocumentosSeleccionados.Rows[i].Cells["CODTIPOS"].Value;
                        Registrosdoc.chcorrelanota = dgvDocumentosSeleccionados.Rows[i].Cells["CHDOCS"].Value.ToString();
                        Registrosdoc.chfechanota = dgvDocumentosSeleccionados.Rows[i].Cells["CHFECHAS"].Value.ToString();
                        Registrosdoc.p_inidmoneda = (int)cboMoneda.SelectedValue;
                        Registrosdoc.nuimporcancela = montofinal;
                        Registrosdoc.p_inidsituacion = 0;
                        Registrosdoc.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                        Registrosdoc.p_inidusuariodelete = 0;
                        Registrosdoc.estado = true;                        
                        pedidoNE.IngresarDocNc(Registrosdoc);
                    }                   
                }
            }     
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMoneda.Text == "SOLES")
            {
                txtDesMone3.Text = "S/.";
                txtDesMone4.Text = "S/.";
                txtDesMone5.Text = "S/.";
                txtTotalPendienteDolar.Text = "0.00";
            }
            else
            {
                if (cboMoneda.Text == "DOLARES")
                {
                    txtDesMone3.Text = "$ US";
                    txtDesMone4.Text = "$ US";
                    txtDesMone5.Text = "$ US";
                    decimal pendiente = decimal.Parse(txtTotalPendiente.Text);
                    txtTotalPendienteDolar.Text = string.Format("{0:0,0.00}", ( pendiente * (decimal.Parse(txtTipoCambio.Text))).ToString("N2"));
                }
            }
        }

        private void rbtcancela_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtcancela.Checked == true)
            {
                cbotipoPago.Visible = true;
                lbltipopago.Visible = true;
                lblNombre1.Visible = false;
                lblNombre2.Visible = false;
                lblNombre3.Visible = true;
                lblNombre4.Visible = true;
                cboBanco.Visible = false;
                txtCheque.Visible = false;
                txtDesMone3.Visible = true;
                txtDesMone4.Visible = true;
                txtImport.Visible = true;
                txtInter.Visible = true;
                int index3 = cbotipoPago.FindString("PAGO EN EFECTIVO");
                cbotipoPago.SelectedIndex = index3;
                CargarDatosTabla();
            }
        }

        private void rbtCanje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCanje.Checked == true)
            {
                cbotipoPago.Visible = false;
                lbltipopago.Visible = false;
                lblNombre1.Visible = false;
                lblNombre2.Visible = false;
                lblNombre3.Visible = false;
                lblNombre4.Visible = false;
                cboBanco.Visible = false;
                txtCheque.Visible = false;
                txtDesMone3.Visible = false;
                txtDesMone4.Visible = false;
                txtImport.Visible = false;
                txtInter.Visible = false;
                CargarDatosTabla();
            }
        }

        private void cbotipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipoPago.Text != "PAGO EN EFECTIVO")
            {
                lblNombre1.Visible = true;
                lblNombre2.Visible = true;
                cboBanco.Visible = true;
                txtCheque.Visible = true;
            }else
            {
                lblNombre1.Visible = false;
                lblNombre2.Visible = false;
                cboBanco.Visible = false;
                txtCheque.Visible = false;
            }
        }

        private void txtImport_Validated(object sender, EventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.ValidarNumero(ref textboxusado, e);
        }

        private void txtInter_Validated(object sender, EventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.ValidarNumero(ref textboxusado, e);
        }

        private void txtImport_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.solonumeros(ref textboxusado, e);
        }

        private void txtInter_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.solonumeros(ref textboxusado, e);
        }

        



        /*FIN :: FUNCIONES BASES*/
    }
}
