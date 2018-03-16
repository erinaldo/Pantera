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
using Presentacion.Dataset;
using Presentacion.Programas;
namespace Presentacion
{
    public partial class frmProcPedidosCabecera : Form
    {
        internal clientebusqueda ClienteG;
        internal int Transportistacodigo ;
        internal licencia LicenciaG;
        internal List<tarjetapropiedad> TarjetaG;
        internal pedidodetalle PedidoG;
        internal List<pedidodetallecontenido> ListaDetalleContenidoG;
        internal productoparaventa ProductoG;
        internal bool FlatG;
        internal int CodigoPedidoCabecera;
        public delegate void PasarCabecera(int codigo);
        public event PasarCabecera PasadoCabecera;
        internal int CodigoCabecera;

        public frmProcPedidosCabecera(string vBotonG)
        {
            InitializeComponent();
            this.vBotonG = vBotonG;
        }
        string vBotonG;


        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    List<pedidodetalle> listado = null;
                    if (dgvListaPedidoDetalle.RowCount > 0)
                    {
                        listado = new List<pedidodetalle>();
                        for (int i = 0; i < dgvListaPedidoDetalle.RowCount; i++)
                        {
                            pedidodetalle registros = new pedidodetalle();
                            registros.p_inidproducto = int.Parse(dgvListaPedidoDetalle.Rows[i].Cells["IDPRODUCTO"].Value.ToString());
                            registros.nucantidad = decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUCANTIDAD"].Value.ToString());
                            listado.Add(registros);
                        }
                    }
                    frmProcPedidosDetalle f = new frmProcPedidosDetalle(vBoton);
                    f.ListadoValidarG = listado;                    
                    f.PasadoDetalle += new frmProcPedidosDetalle.PasarDetalle(CargarTablaDetalle);
                    //f.MdiParent = this.MdiParent;
                    f.ShowDialog();
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
 
        private void CargarTablaDetalle()
        {
            int val = 0;
            val++;
            if (sesion.pedidodetallecontenido != null)
            {
                dgvListaPedidoDetalle.Rows.Clear();
                foreach (pedidodetallecontenido obj in sesion.pedidodetallecontenido)
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
                        dgvListaPedidoDetalle.Rows.Add("1", "2", obj.orden, idproducto, codigo, cantidad, stock, nombrecompuesto, codigoserie, preunit, precio, desc1, desc2, importe, "15", idserie);
                    }                   
                }
                //dgvListaPedidoDetalle.Rows.Add("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16");   
                GenerarTotales();
            }

        }
        public void GenerarTotales()
        {
            if (dgvListaPedidoDetalle.RowCount > 0)
            {
                decimal importe=0;
                decimal preciprod = 0;
                int cantidad = 0;
                decimal preciototal = 0;
                decimal valorigv = (100 + decimal.Parse(cboigv.Text)) / 100;
                List<pedidodetalle>  listado = new List<pedidodetalle>();
                for (int i = 0; i < dgvListaPedidoDetalle.RowCount; i++)
                {
                    //precio += decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["CHPRECIO"].Value.ToString());
                    importe += decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUIMPORTE"].Value.ToString());
                    preciprod = decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUPRECIOVENTA"].Value.ToString());
                    cantidad = int.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUCANTIDAD"].Value.ToString());
                    preciototal += (decimal.Round(cantidad * preciprod, 2) / valorigv);
                    //(100+ decimal.Parse(cboigv.Text))/100)
                }

                txtTotVenta.Text = string.Format("{0:0,0.00}", importe);
                decimal valorventa = decimal.Round(importe / valorigv, 2);
                txtValVenta.Text = string.Format("{0:0,0.00}", valorventa);
                decimal igv = importe - valorventa;
                txtIgv.Text = string.Format("{0:0,0.00}", igv);

                decimal tdescuentototal = decimal.Round(preciototal - valorventa, 2);
                txtDesctot.Text = string.Format("{0:0,0.00}", tdescuentototal);
                txtSubtotal.Text = string.Format("{0:0,0.00}", decimal.Round(preciototal, 2));
            }
        }
        private void frmProcPedidosPedidosCabecera_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            GenerarCodigoPedido();
            cboTipoDocu.DataSource = tipodocumentoNE.ListarDocumentosVenta();
            cboTipoDocu.ValueMember = "p_inidtipodocumento";
            cboTipoDocu.DisplayMember = "chacrominodocumento";
            cboTraslado.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(16);
            cboTraslado.ValueMember = "idmaestrodetalle";
            cboTraslado.DisplayMember = "nombreitem";
            cboCondVenta.DataSource = condicionpagoNE.ListaCondicionPago();
            cboCondVenta.ValueMember = "p_inidcondicionpago";
            cboCondVenta.DisplayMember = "chnombrepago";
            cboigv.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(22);
            cboigv.ValueMember = "idmaestrodetalle";
            cboigv.DisplayMember = "nombreitem";

            txtNombreAlmacen.Text = sesion.SessionGlobal.chalamacen;
            txtNombreVendedor.Text = sesion.SessionGlobal.chnombrepersona;
            txtFechaActual.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            List<transportista> listado = transportistaNE.ListaTransportista();
            foreach (transportista obj in listado)
            {
                Transportistacodigo = obj.p_inidtransportista;
                txtPtoPartida.Text = obj.chdireccionfiscal;
                txtRucTrans.Text = obj.chruc;
                txtNombreTrans.Text = obj.chnombretransportista;
                CargaVehiculos(obj.p_inidtransportista);
                CargaConductores(obj.p_inidtransportista);
            }
            List<tipocambio> listado2 = tipocambioNE.busquedaValorTipoCambio(txtFechaActual.Text);
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
            if (vBotonG == "A")
            {
                txtSubtotal.Text = "0.00";
                txtDesctot.Text = "0.00";
                txtIgv.Text = "0.00";
                txtValVenta.Text = "0.00";
                txtTotVenta.Text = "0.00";
                txtDesc.Text = "0.00";
                txtTipoCambio.Text = "0.00";
            }
            else
            {
                if (vBotonG == "M")
                {
                    CargarDatosCabecera();
                }
                else
                {
                    if (vBotonG == "V")
                    {
                        CargarDatosCabecera();
                        Desactivartext(txtCodigoCliente);
                        Desactivartext(txtordcomp);
                        Desactivartext(txtPtoPartida);
                        Desactivartext(txtPtoLlegada);
                        Desactivartext(txtObs);
                        btnAnadir.Enabled = false;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;
                        btnGrabar.Enabled = false;
                    }else
                    {
                        CargarDatosCabecera();
                        CodigoCabecera = CodigoPedidoCabecera;
                        MostrarVistaImpresion();
                        PasadoCabecera(CodigoCabecera);
                        
                    }
                }
            }
        }
        private void CargarDatosCabecera()
        {
            pedidocabecera pedCab = pedidoNE.PedidoCabeceraBusquedaCodigo(CodigoPedidoCabecera);
            List<pedidodetalle> peddet = pedidoNE.PedidoDetalleBusquedaParametro(CodigoPedidoCabecera);            
            List<pedidodetallecontenido> ListaPedidoContenido = new List<pedidodetallecontenido>();
            foreach (pedidodetalle obj in peddet)
            {
                pedidodetallecontenido RegistroPed = new pedidodetallecontenido();
                RegistroPed.orden = int.Parse( obj.chitem);
                RegistroPed.pedidodetalle = obj;
                serie registrosserie= serieNE.SerieBusquedaCodigo(obj.p_inidserie);
                if (registrosserie.p_inidserie == 0) { registrosserie = null; }
                RegistroPed.serie = registrosserie;
                producto prod = productoNE.ProductoBusquedaCodigo(obj.p_inidproducto);
                RegistroPed.productoparaventa = productoNE.ProductosVentaParametro(prod.chcodigoproducto);
                RegistroPed.estado = true;
                ListaPedidoContenido.Add(RegistroPed);
            }
            sesion.pedidodetallecontenido = ListaPedidoContenido;
            Mcliente Registroscliente = clienteNE.ClienteBusquedaCodigo(pedCab.p_inidcliente);
            txtCodigoCliente.Text = Registroscliente.chcodigocliente;
            txtNroPedido.Text = pedCab.chcodigopedido ;
            txtFechaActual.Text = pedCab.chfechapedido;
            cboTipoDocu.SelectedValue = pedCab.p_inidtipodocumento;
            cboTraslado.SelectedValue = pedCab.p_inmotivotransaccion;
            cboCondVenta.SelectedValue= pedCab.p_inidcompromisopago;
            txtordcomp.Text = pedCab.chordencompra;
            cboNombreConductor.SelectedValue = pedCab.p_inidconductor;
            cboVehiculo.Text = pedCab.chplacavehiculo;
            //txtfechaInicio.Text = pedCab.chfechainiciotransporte;
            txtPtoPartida.Text = pedCab.chpuntopartida;
            txtPtoLlegada.Text = pedCab.chpuntollegada;
            cboigv.SelectedValue= pedCab.p_inidigv;           

            //txtSubtotal.Text = "" + decimal.Round(pedCab.nuventainafectamonnacional- pedCab.nutotaldescmonnacional, 2);
            //txtValVenta.Text = "" + decimal.Round(pedCab.nuventainafectamonnacional, 2);
            //txtDesctot.Text = "" + decimal.Round(pedCab.nutotaldescmonnacional, 2);
            //txtIgv.Text = "" + decimal.Round(pedCab.nutotaligvmonnacional , 2) ;
            //txtTotVenta.Text = "" + decimal.Round(pedCab.nutotalventamonnacional , 2);
            txtObs.Text = pedCab.chobservacion;
            cboVehiculo.SelectedValue = pedCab.p_inidvehiculo;
            cboTarjeta.SelectedValue = pedCab.p_inidlicencia;
            CargarTablaDetalle();

        }
        private void CargarDatosDetalle()
        {

        }
        private void Desactivartext(TextBox texbox)
        {
            texbox.ReadOnly = true;
            texbox.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            texbox.ForeColor = Color.Blue;
            texbox.TabStop = false;
        }
        public void CargaVehiculos(int parametro)
        {
            cboVehiculo.DataSource = vehiculoNE.ListaVehiculosPorTransportista(parametro);
            cboVehiculo.ValueMember = "p_inidvehiculo";
            cboVehiculo.DisplayMember = "chplacavehiculo";
        }
        public void CargaConductores(int parametro)
        {
            cboNombreConductor.DataSource = conductorNE.ListaConductoresPorTransportista(parametro);
            cboNombreConductor.ValueMember = "p_inidcoductor";
            cboNombreConductor.DisplayMember = "chnombreconductor";
        }
        public void GenerarCodigoPedido()
        {
            string correlativo = generarCodigoNE.ObtenerUltimoCodigoPedido(sesion.SessionGlobal.p_inidpuntoventa);
            txtNroPedido.Text = correlativo;
            txtRucCliente.Focus();
        }

      
  
        public void Busquedacliente(string parametro)
        {
            List<clientebusqueda> listado = clienteNE.ClienteBusquedaParametro(parametro);
            if (listado != null)
            {
                foreach (clientebusqueda f in listado)
                {
                    txtRucCliente.Text = f.nrodocumento;
                    txtNombreCliente.Text = f.razon;
                    txtCodigoCliente.Text = f.chcodigocliente;
                    txtPtoLlegada.Text = f.chdireccion;
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (this.vBotonG)
            {
                case "A":
                    if (ValidacionyConfirmacion())
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            PedidoRegistrar();
                            MostrarVistaImpresion();
                            PasadoCabecera(CodigoCabecera);
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
                    break;
                case "M":
                    ValidacionyConfirmacion();
                    PedidoModificar();
                    break;
                default:
                    break;
            }
            sesion.pedidodetallecontenido = null;
           this.Dispose();
        }
        internal string correlativo;
        internal string nombrecompro;
        private void CargarDatosCorrelativos(string tipocomprobante1)
        {
            switch (tipocomprobante1)
            {
                case "BV":
                    {

                        correlativo = "BOLETA DE VENTA";
                        nombrecompro = generarCodigoNE.ObtenerCorrelativoBoleta(sesion.SessionGlobal.p_inidpuntoventa);
                    }
                    break;
                case "FC":
                    {

                        correlativo = "FACTURA";
                        nombrecompro = generarCodigoNE.ObtenercorrelativoFactura(sesion.SessionGlobal.p_inidpuntoventa);
                    }
                    break;
                case "FG":
                    {

                        correlativo = "FACTURA";
                        nombrecompro = generarCodigoNE.ObtenercorrelativoFactura(sesion.SessionGlobal.p_inidpuntoventa);
                    }
                    break;
                case "BG":
                    {

                        correlativo = "BOLETA DE VENTA";
                        nombrecompro = generarCodigoNE.ObtenercorrelativoFactura(sesion.SessionGlobal.p_inidpuntoventa);
                    }
                    break;
                case "GR":
                    {

                        correlativo = "NOTA DE VENTA";
                        nombrecompro = generarCodigoNE.ObtenerCorrelativoGuia(sesion.SessionGlobal.p_inidpuntoventa);
                    }
                    break;
                case "NV":
                    {

                        correlativo = "NOTA DE VENTA";
                        nombrecompro = generarCodigoNE.ObtenerCorrelativoNotaVenta(sesion.SessionGlobal.p_inidpuntoventa);
                    }
                    break;
            }
        }
        private void MostrarVistaImpresion()
        {
            Reportes.FrmReporte f = new Reportes.FrmReporte();
            f.tipocomprobante = cboTipoDocu.Text;
            f.codigopedido = txtNroPedido.Text;
            CargarDatosCorrelativos(cboTipoDocu.Text);
            f.p_inidcodigopedido = CodigoCabecera;
            CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;
            DataSet Dts = new DtsPedidos();
            /*PRA CABECERA*/
            decimal cadenatotol = decimal.Parse(txtTotVenta.Text);
            Dts.Tables["cabecera"].LoadDataRow(new object[]
            {
                txtNombreCliente.Text,
                txtPtoLlegada.Text,
                "LIMA",
                "976566115",
                txtRucCliente.Text,
                txtordcomp.Text,
                txtCodigoCliente.Text,
                txtFechaActual.Text,
                txtfechaInicio.Text,
                sesion.SessionGlobal.chusuario,
                txtNroPedido.Text,
                cboCondVenta.Text,
                txtLicencia.Text,
                txtVencLicencia.Text,
                cboTarjeta.Text,
                txtFechaVenciTarjeta.Text,
                correlativo,
                nombrecompro,
                basicas.Convertir(cadenatotol.ToString(),true),
                //txtValVenta.Text,
                string.Format("{0:0,0.00}", decimal.Parse(txtValVenta.Text)),
                "0",
                "0",
                "0",
                string.Format("{0:0,0.00}", decimal.Parse(txtIgv.Text)),
                //txtIgv.Text,
                string.Format("{0:0,0.00}", decimal.Parse(txtTotVenta.Text)),
                //txtTotVenta.Text,
                sesion.SessionGlobal.chpuntoventa,
                "10717767603"
            }, true);
            Dts.AcceptChanges();
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
                        //dgvListaPedidoDetalle.Rows.Add("1", "2", obj.orden, idproducto, codigo, cantidad, stock, nombrecompuesto, codigoserie, preunit, precio, desc1, desc2, importe, "15", idserie);
                        Dts.Tables["detalle"].LoadDataRow(new object[] 
                        {
                            codigo,
                            obj.pedidodetalle.nucantidad,
                            productoM.chtipoproducto,
                            productoM.chmarca,
                            productoM.chdmodelo,
                            productoM.chcalibre,
                            codigoserie,
                            codigoserie,                            
                            string.Format("{0:0,0.00}",obj.pedidodetalle.nuprecioventa),
                            string.Format("{0:0,0.00}",obj.pedidodetalle.nuimportesubtotal),
                            string.Format("{0:0,0.00}",obj.productoparaventa.chunidadmedidaproducto)
                        }, true);
                        Dts.AcceptChanges();
                    }
                }
                //dgvListaPedidoDetalle.Rows.Add("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16");   
                //GenerarTotales();
            }
            Rpt1 = new Reportes.CrystalReportPedidos();
            Rpt1.SetDataSource(Dts);
            f.Rpt = Rpt1;
            f.ShowDialog(this);
        }

        private bool ValidacionyConfirmacion()
        {
            bool flat = true;
            if (txtCodigoCliente.Text.Length <= 0)
            {
                MessageBox.Show("Código de Cliente vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return  false;
            }
            if (dgvListaPedidoDetalle.RowCount <= 0)
            {
                MessageBox.Show("Lista de venta vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return false;
            }
            if (txtordcomp.Text.Length <= 0)
            {
                MessageBox.Show("Orden de compra vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return false;
            }
            if (txtObs.Text.Length <= 0)
            {
                MessageBox.Show("Observacíon vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return false;
            }
            if (txtPtoLlegada.Text.Length <= 0)
            {
                MessageBox.Show("´Punto de llegada vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return false;
            }
            if (txtPtoPartida.Text.Length <= 0)
            {
                MessageBox.Show("Punto de partida vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return false;
            }
                       return flat;
        }

        
        private void PedidoRegistrar()
        {
            decimal valortipocambio = decimal.Parse(txtTipoCambio.Text);
            //MessageBox.Show("Pedido registrado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            pedidocabecera registrosPedidoCabecera = new pedidocabecera();
            //registrosPedidoCabecera.p_inidpedidocabecera = 0;
            registrosPedidoCabecera.p_inidpuntoventa = sesion.SessionGlobal.p_inidpuntoventa;
            registrosPedidoCabecera.chcodigopedido = txtNroPedido.Text;
            registrosPedidoCabecera.chfechapedido = txtFechaActual.Text;
            registrosPedidoCabecera.tmhorapedido = "";
            registrosPedidoCabecera.p_inidtipodocumento = (int)cboTipoDocu.SelectedValue;
            registrosPedidoCabecera.p_inidcliente = ClienteG.p_inidcodigoclie;
            registrosPedidoCabecera.p_inmotivotransaccion = (int)cboCondVenta.SelectedValue;
            registrosPedidoCabecera.p_inidcompromisopago = (int)cboCondVenta.SelectedValue;
            registrosPedidoCabecera.nuporcenatajedesc = 0;
            registrosPedidoCabecera.chordencompra = txtordcomp.Text;
            registrosPedidoCabecera.p_inidalmacen = sesion.SessionGlobal.p_inidalmacen;
            registrosPedidoCabecera.p_inidtransportista = Transportistacodigo;
            registrosPedidoCabecera.p_inidconductor = (int)cboNombreConductor.SelectedValue;
            registrosPedidoCabecera.chplacavehiculo = cboVehiculo.Text;
            registrosPedidoCabecera.chfechainiciotransporte = txtfechaInicio.Text;
            registrosPedidoCabecera.chpuntopartida = txtPtoPartida.Text;
            registrosPedidoCabecera.chpuntollegada = txtPtoLlegada.Text;
            registrosPedidoCabecera.nuventaafectamonnacional = 0;
            registrosPedidoCabecera.chmotivotransaccion ="";
            registrosPedidoCabecera.p_inidmoneda = 0;
            registrosPedidoCabecera.p_inidigv = (int)cboigv.SelectedValue;
            registrosPedidoCabecera.boafectoigv = true;
            registrosPedidoCabecera.nuimportecambioventa = 0;
            registrosPedidoCabecera.p_inidvendedor = sesion.SessionGlobal.p_inidusuario;
            registrosPedidoCabecera.chtiempoentrega = "";

            registrosPedidoCabecera.nuventainafectamonnacional = decimal.Parse(txtSubtotal.Text);
            registrosPedidoCabecera.nutotaldescmonnacional = decimal.Parse(txtDesctot.Text);
            registrosPedidoCabecera.nutotaligvmonnacional = decimal.Parse(txtIgv.Text);
            registrosPedidoCabecera.nutotalventamonnacional = decimal.Parse(txtTotVenta.Text);

            registrosPedidoCabecera.nuventaafectamonextra = decimal.Parse(txtSubtotal.Text);
            registrosPedidoCabecera.nuventainafectamonextra = decimal.Parse(txtDesctot.Text);
            registrosPedidoCabecera.nutotaldescmonextra = decimal.Parse(txtIgv.Text);
            registrosPedidoCabecera.nutotaligvmonextra = decimal.Parse(txtIgv.Text);
            registrosPedidoCabecera.nutotalventamonextra = decimal.Parse(txtTotVenta.Text);

            registrosPedidoCabecera.p_inidsituacionpedido = 85;
            registrosPedidoCabecera.chobservacion = txtObs.Text;
            registrosPedidoCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            //registrosPedidoCabecera.p_inidusuariodelete = 0;
            registrosPedidoCabecera.estado = true;
            registrosPedidoCabecera.p_inidvehiculo = (int)cboVehiculo.SelectedValue;

            registrosPedidoCabecera.p_inidlicencia = (int)cboTarjeta.SelectedValue;
            registrosPedidoCabecera.p_inidtarjeta = LicenciaG.p_inidlicencia;
            CodigoCabecera = 0;
             CodigoCabecera = pedidoNE.IngresoPedidoCabecera(registrosPedidoCabecera);
            
            if (sesion.pedidodetallecontenido != null)
            {
                //dgvListaPedidoDetalle.Rows.Clear();
                foreach (pedidodetallecontenido obj in sesion.pedidodetallecontenido)
                {
                    int codigodetalle = 0;
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
                        pedidodetalle RegistrosPedidosDetalle = new pedidodetalle();
                        //RegistrosPedidosDetalle.p_inidpedidodetalle = 0;
                        RegistrosPedidosDetalle.p_inidpedidocabecera = CodigoCabecera;
                        RegistrosPedidosDetalle.chitem = obj.orden.ToString();
                        RegistrosPedidosDetalle.p_inidproducto = idproducto;
                        RegistrosPedidosDetalle.nucantidad = cantidad;
                        RegistrosPedidosDetalle.nuprecioproducto = preunit;
                        RegistrosPedidosDetalle.nuporcentajedesc1 = desc1;
                        RegistrosPedidosDetalle.nuporcentajedesc2 = desc2;
                        RegistrosPedidosDetalle.nuprecioventa = precio;
                        RegistrosPedidosDetalle.nuimportesubtotal = importe;
                        RegistrosPedidosDetalle.nuimportetotal = 0;
                        RegistrosPedidosDetalle.estado = true;
                        RegistrosPedidosDetalle.p_inidserie = idserie;
                        serieNE.SeriesFalsearCodigo(idserie);
                        RegistrosPedidosDetalle.p_inidpedidodetalle = sesion.SessionGlobal.p_inidalmacen;
                        codigodetalle = pedidoNE.IngresoPedidoDetalle(RegistrosPedidosDetalle);
                    }
                }
                //dgvListaPedidoDetalle.Rows.Add("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16");   
                //GenerarTotales();
            }
            //MessageBox.Show("A:"+CodigoCabecera+":", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            

        }
        private void PedidoModificar()
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "E";
                if (basicas.validarAcceso(vBoton))
                {
                    if (dgvListaPedidoDetalle.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    
                    foreach (pedidodetallecontenido OBJ in sesion.pedidodetallecontenido)
                    {
                        if (OBJ.orden == int.Parse(dgvListaPedidoDetalle.CurrentRow.Cells["CHITEM"].Value.ToString()))
                        {
                            OBJ.estado = false;
                        }
                    }
                    CargarTablaDetalle();   
                    
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "M";
                if (basicas.validarAcceso(vBoton))
                {
                    if (dgvListaPedidoDetalle.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    List<pedidodetalle> listado = null;
                    if (dgvListaPedidoDetalle.RowCount > 0)
                    {
                        listado = new List<pedidodetalle>();
                        for (int i = 0; i < dgvListaPedidoDetalle.RowCount; i++)
                        {
                            pedidodetalle registros = new pedidodetalle();
                            registros.p_inidserie = int.Parse(dgvListaPedidoDetalle.Rows[i].Cells["IDSERIE"].Value.ToString());
                            registros.p_inidproducto = int.Parse(dgvListaPedidoDetalle.Rows[i].Cells["IDPRODUCTO"].Value.ToString());
                            registros.nucantidad = decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUCANTIDAD"].Value.ToString());
                            registros.estado = true;
                            listado.Add(registros);
                        }
                    }
                    frmProcPedidosDetalle f = new frmProcPedidosDetalle(vBoton);
                    f.ListadoValidarG = listado;
                    f.codigoorden = int.Parse(dgvListaPedidoDetalle.CurrentRow.Cells["CHITEM"].Value.ToString());
                    f.PasadoDetalle += new frmProcPedidosDetalle.PasarDetalle(CargarTablaDetalle);
                    f.MdiParent = this.MdiParent;
                    f.Show();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            sesion.pedidodetallecontenido = null;
        }

        
        private void BuscarClienteCodigo(string codigo)
        {
            ClienteG = clienteNE.ClienteBusquedaCodigoSecundario(codigo);
            
               // MessageBox.Show(""+ClienteG1.p_inidcodigoclie, "Mensaje de Sistema", MessageBoxButtons.OK);
            if (ClienteG != null)
            {
                //ClienteG = ClienteG1;
                txtNombreCliente.Text = ClienteG.razon;
                txtRucCliente.Text = ClienteG.nrodocumento;
                txtPtoLlegada.Text = ClienteG.chdireccion;
                LicenciaG = clienteNE.LicenciaBusquedaCodigo(ClienteG.p_inidcodigoclie);
                TarjetaG = clienteNE.TarjetaPropiedadBusquedaCodigo(ClienteG.p_inidcodigoclie);
                txtLicencia.Text = LicenciaG.chlicencia;
                txtVencLicencia.Text = LicenciaG.fechavencimiento;
                cboTarjeta.DataSource = TarjetaG;
                cboTarjeta.ValueMember = "p_inidtarjeta";
                cboTarjeta.DisplayMember = "chtarjeta";

            }
            else
            {
                txtNombreCliente.Text = "";
                txtRucCliente.Text = "";
                txtLicencia.Text = "";
                txtVencLicencia.Text ="";
                cboTarjeta.DataSource = null;
                txtPtoLlegada.Text = "";
            }
        }
        private void txtCodigoCliente_DoubleClick(object sender, EventArgs e)
        {
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmBusClientePrincipal);
            //if (frm != null)
            //{
            //    frm.BringToFront();
            //    return;
            //}
            frmBusClientePrincipal f = new frmBusClientePrincipal();
            f.Pasado += new frmBusClientePrincipal.PasarClienteCodigo(PonerCodigocliente);
            //f.MdiParent = this.MdiParent;
            f.ShowDialog();
        }
        private void PonerCodigocliente(string codigo)
        {
            txtCodigoCliente.Text = codigo.ToString();
        }

        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtCodigoCliente.Text;
            BuscarClienteCodigo(parametro);
        }

        private void cboTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string parametro = "";
            if (TarjetaG != null)
            {
                foreach (tarjetapropiedad Registros in TarjetaG)
                {
                    if (cboTarjeta.Text == Registros.chtarjeta)
                    {
                       parametro = Registros.fechavencimiento;
                    }
                }
            }
            txtFechaVenciTarjeta.Text = parametro;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtordcomp_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.LogitudDeCampo(ref textboxusado, e, 20);
        }

        private void txtObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.LogitudDeCampo(ref textboxusado, e, 100);
        }

        private void txtPtoPartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.LogitudDeCampo(ref textboxusado, e, 200);
        }

        private void txtPtoLlegada_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.LogitudDeCampo(ref textboxusado, e, 20);
        }
    }
}
