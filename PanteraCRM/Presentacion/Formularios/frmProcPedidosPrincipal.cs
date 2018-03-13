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

namespace Presentacion
{
    public partial class frmProcPedidosPrincipal : Form
    {
        public frmProcPedidosPrincipal()
        {
            InitializeComponent();
        }


        string vBoton;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmProcPedidosPrincipal_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0,"");
            

        }
        public void cargarData(int registro, string parametro)
        {
            if (parametro == "")
            {
                List<pedidocabecera> listado = pedidoNE.PedidoCabeceraListar();
                CargarTabla(listado);
                //dgvPedidos.DataSource = listado;
            }
            else
            {
                List<pedidocabecera> listado = pedidoNE.PedidoCabeceraBusquedaParametro(parametro);
                CargarTabla(listado);
                //dgvPedidos.DataSource = listado;
            }

        }
        private void CargarTabla(List<pedidocabecera> Listado)
        {
            dgvPedidos.Rows.Clear();
            int countfile = 0;
            foreach (pedidocabecera registros in Listado)
            {
                string razon="";
                string documento = "";
                Mcliente Registroscliente = clienteNE.ClienteBusquedaCodigo(registros.p_inidcliente);
                if (Registroscliente.p_inidjurinat == 1)
                {
                    Mclientejuridico    ClienteJuridicoG = clienteNE.ClienteJuridicoBusquedaCodigo(Registroscliente.p_inidcliente);
                    empresas EmpresaG = empresaNE.EmpresaBusquedaCodigo(ClienteJuridicoG.p_inidempresa);
                    razon = EmpresaG.chrazonsocial;
                }
                else
                {

                    Mclientenatural ClienteNaturalG = clienteNE.ClienteNaturalBusquedaCodigo(Registroscliente.p_inidcliente);
                    persona PersonaG = personaNE.PersonaBusquedaCodigo(ClienteNaturalG.p_inidpersona);
                    razon = PersonaG.chapellidopaterno+" "+ PersonaG.chapellidomaterno+", "+ PersonaG.chnombres;
                }
                maestrodetalle madet = maestrodetalleNE.BuscarPorCodigoDetalle(registros.p_inidsituacionpedido);
                tipodocumento detalle = tipodocumentoNE.documentoVentaBusquedacodigo(registros.p_inidtipodocumento);
                
                dgvPedidos.Rows.Add(registros.p_inidpedidocabecera, registros.chcodigopedido, registros.chfechapedido, razon, detalle.chnombredocumento, registros.nutotalventamonnacional, madet.nombreitem);
                if (madet.nombreitem == "BAJA")
                {
                    dgvPedidos.Rows[countfile].DefaultCellStyle.ForeColor = Color.Red;
                }
                if (madet.nombreitem == "GENERADO")
                {
                    dgvPedidos.Rows[countfile].DefaultCellStyle.ForeColor = Color.Green;
                }
                countfile++;
            }
            
        }

        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvPedidos.Rows)
            {
                int valor = (int)Row.Cells["IDPEDIDO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvPedidos.CurrentCell = dgvPedidos.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcPedidosCabecera);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmProcPedidosCabecera f = new frmProcPedidosCabecera(vBoton);
                    f.PasadoCabecera += new frmProcPedidosCabecera.PasarCabecera(ejecutar);
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

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0,parametro);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "M";
                if (basicas.validarAcceso(vBoton))
                {
                    ConectaFormSecundario(vBoton);
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "V";
                if (basicas.validarAcceso(vBoton))
                {
                    ConectaFormSecundario(vBoton);
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
        private void ConectaFormSecundario(string vBoton)
        {
            if (dgvPedidos.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcPedidosCabecera);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "ACTIVO")
            {
                frmProcPedidosCabecera f = new frmProcPedidosCabecera(vBoton);
                f.PasadoCabecera += new frmProcPedidosCabecera.PasarCabecera(ejecutar);
                f.CodigoPedidoCabecera = (int)dgvPedidos.CurrentRow.Cells["IDPEDIDO"].Value;
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "BAJA")
                {
                    MessageBox.Show("El pedido está anulado", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El pedido ya tiene lo comprobantes generados", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcPedidosCabecera);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "ACTIVO")
            {
                DialogResult result = MessageBox.Show("¿Está seguro de anular el pedido N° "+ dgvPedidos.CurrentRow.Cells["CHCORRELATIVO"].Value.ToString() + " ?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //MessageBox.Show("Registro anulado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    int codigo = (int)dgvPedidos.CurrentRow.Cells["IDPEDIDO"].Value;
                    List<pedidodetalle> ListaPedidosDetalle = pedidoNE.PedidoDetalleBusquedaParametro(codigo);
                    foreach (pedidodetalle obj in ListaPedidosDetalle)
                    {                       
                        int cantidad = (-1) * int.Parse(obj.nucantidad.ToString());
                        almacenNE.CambiarSaldoComprometido(sesion.SessionGlobal.p_inidalmacen,obj.p_inidproducto, cantidad);
                    }
                    codigo = pedidoNE.CabeceraCambiarEstado(codigo,86);
                    ejecutar(codigo);
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "BAJA")
                {
                    MessageBox.Show("El pedido ya está anulado", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El pedido ya tiene lo comprobantes generados", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string vBoton = "I";
            if (dgvPedidos.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcPedidosCabecera);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "ACTIVO")
            {
                frmProcPedidosCabecera f = new frmProcPedidosCabecera(vBoton);
                f.PasadoCabecera += new frmProcPedidosCabecera.PasarCabecera(ejecutar);
                f.CodigoPedidoCabecera = (int)dgvPedidos.CurrentRow.Cells["IDPEDIDO"].Value;
              
            }
            else
            {
                if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "BAJA")
                {
                    MessageBox.Show("El pedido está anulado", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El pedido ya tiene lo comprobantes generados", "Mensaje de Sistema", MessageBoxButtons.OK);
                }
            }
        }
        private void CargarDatosCabecera(int CodigoPedidoCabecera)
        {
            pedidocabecera pedCab = pedidoNE.PedidoCabeceraBusquedaCodigo(CodigoPedidoCabecera);
            //List<tipodocumento> ListaTipdoc = tipodocumentoNE.ListarDocumentosVenta();
            //cboTipoDocu.ValueMember = "p_inidtipodocumento";
            //cboTipoDocu.DisplayMember = "chacrominodocumento";
            //cboTraslado.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(16);
            //cboTraslado.ValueMember = "idmaestrodetalle";
            //cboTraslado.DisplayMember = "nombreitem";
            //cboCondVenta.DataSource = condicionpagoNE.ListaCondicionPago();
            //cboCondVenta.ValueMember = "p_inidcondicionpago";
            //cboCondVenta.DisplayMember = "chnombrepago";
            //cboigv.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(22);
            //cboigv.ValueMember = "idmaestrodetalle";
            //cboigv.DisplayMember = "nombreitem";
            //Mcliente Registroscliente = clienteNE.ClienteBusquedaCodigo(pedCab.p_inidcliente);
            //txtCodigoCliente.Text = Registroscliente.chcodigocliente;
            //txtNroPedido.Text = pedCab.chcodigopedido;
            //txtFechaActual.Text = pedCab.chfechapedido;
            //cboTipoDocu.SelectedValue = pedCab.p_inidtipodocumento;
            //cboCondVenta.SelectedValue = pedCab.p_inmotivotransaccion;
            //cboCondVenta.SelectedValue = pedCab.p_inidcompromisopago;
            //txtordcomp.Text = pedCab.chordencompra;
            //cboNombreConductor.SelectedValue = pedCab.p_inidconductor;
            //cboVehiculo.Text = pedCab.chplacavehiculo;
            ////txtfechaInicio.Text = pedCab.chfechainiciotransporte;
            //txtPtoPartida.Text = pedCab.chpuntopartida;
            //txtPtoLlegada.Text = pedCab.chpuntollegada;
            //cboigv.SelectedValue = pedCab.p_inidigv;

            ////txtSubtotal.Text = "" + decimal.Round(pedCab.nuventainafectamonnacional- pedCab.nutotaldescmonnacional, 2);
            ////txtValVenta.Text = "" + decimal.Round(pedCab.nuventainafectamonnacional, 2);
            ////txtDesctot.Text = "" + decimal.Round(pedCab.nutotaldescmonnacional, 2);
            ////txtIgv.Text = "" + decimal.Round(pedCab.nutotaligvmonnacional , 2) ;
            ////txtTotVenta.Text = "" + decimal.Round(pedCab.nutotalventamonnacional , 2);
            //txtObs.Text = pedCab.chobservacion;
            //cboVehiculo.SelectedValue = pedCab.p_inidvehiculo;
            //cboTarjeta.SelectedValue = pedCab.p_inidlicencia;
            //CargarTablaDetalle();

        }
        private void CargarDatosDetalle(int CodigoPedidoCabecera)
        {
            List<pedidodetalle> peddet = pedidoNE.PedidoDetalleBusquedaParametro(CodigoPedidoCabecera);
            List<pedidodetallecontenido> ListaPedidoContenido = new List<pedidodetallecontenido>();
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
            sesion.pedidodetallecontenido = ListaPedidoContenido;
        }
        private void MostrarVistaImpresion()
        {
            //Reportes.FrmReporte f = new Reportes.FrmReporte();
            //f.tipocomprobante = cboTipoDocu.Text;
            //f.codigopedido = txtNroPedido.Text;
            //f.p_inidcodigopedido = CodigoCabecera;
            //CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;
            //DataSet Dts = new DtsPedidos();
            ///*PRA CABECERA*/
            //decimal cadenatotol = decimal.Parse(txtTotVenta.Text);
            //Dts.Tables["cabecera"].LoadDataRow(new object[]
            //{
            //    txtNombreCliente.Text,
            //    txtPtoLlegada.Text,
            //    "LIMA",
            //    "976566115",
            //    txtRucCliente.Text,
            //    txtordcomp.Text,
            //    txtCodigoCliente.Text,
            //    txtFechaActual.Text,
            //    txtfechaInicio.Text,
            //    sesion.SessionGlobal.chusuario,
            //    txtNroPedido.Text,
            //    cboCondVenta.Text,
            //    txtLicencia.Text,
            //    txtVencLicencia.Text,
            //    cboTarjeta.Text,
            //    txtFechaVenciTarjeta.Text,
            //    cboTipoDocu.Text,
            //    "003-0001",
            //    basicas.Convertir(cadenatotol.ToString(),true),
            //    //txtValVenta.Text,
            //    string.Format("{0:0,0.00}", decimal.Parse(txtValVenta.Text)),
            //    "0",
            //    "0",
            //    "0",
            //    string.Format("{0:0,0.00}", decimal.Parse(txtIgv.Text)),
            //    //txtIgv.Text,
            //    string.Format("{0:0,0.00}", decimal.Parse(txtTotVenta.Text)),
            //    //txtTotVenta.Text,
            //    sesion.SessionGlobal.chpuntoventa,
            //    "10717767603"
            //}, true);
            //Dts.AcceptChanges();
            //if (sesion.pedidodetallecontenido != null)
            //{
            //    //dgvListaPedidoDetalle.Rows.Clear();
            //    foreach (pedidodetallecontenido obj in sesion.pedidodetallecontenido)
            //    {
            //        producto productoM = productoNE.ProductoBusquedaCodigo(obj.pedidodetalle.p_inidproducto);

            //        string nombrecompuesto = obj.productoparaventa.chnombrecompuesto;
            //        string codigo = obj.productoparaventa.chcodigoproducto;
            //        int idproducto = obj.pedidodetalle.p_inidproducto;
            //        decimal cantidad = obj.pedidodetalle.nucantidad;
            //        decimal stock = 0;// ProductoM.nustock;
            //        decimal precio = obj.pedidodetalle.nuprecioventa;
            //        decimal desc1 = obj.pedidodetalle.nuporcentajedesc1;
            //        decimal desc2 = obj.pedidodetalle.nuporcentajedesc2;
            //        decimal importe = obj.pedidodetalle.nuimportesubtotal;
            //        decimal preunit = obj.pedidodetalle.nuprecioproducto;
            //        int idserie = 0;
            //        string codigoserie = "-";
            //        if (obj.serie != null)
            //        {
            //            cantidad = 1;
            //            idserie = obj.serie.p_inidserie;
            //            codigoserie = obj.serie.chcodigoserie;
            //        }
            //        if (obj.estado == true)
            //        {
            //            //dgvListaPedidoDetalle.Rows.Add("1", "2", obj.orden, idproducto, codigo, cantidad, stock, nombrecompuesto, codigoserie, preunit, precio, desc1, desc2, importe, "15", idserie);
            //            Dts.Tables["detalle"].LoadDataRow(new object[]
            //            {
            //                codigo,
            //                obj.pedidodetalle.nucantidad,
            //                productoM.chtipoproducto,
            //                productoM.chmarca,
            //                productoM.chdmodelo,
            //                productoM.chcalibre,
            //                codigoserie,
            //                codigoserie,
            //                string.Format("{0:0,0.00}",obj.pedidodetalle.nuprecioventa),
            //                string.Format("{0:0,0.00}",obj.pedidodetalle.nuimportesubtotal),
            //                string.Format("{0:0,0.00}",obj.productoparaventa.chunidadmedidaproducto)
            //            }, true);
            //            Dts.AcceptChanges();
            //        }
            //    }
            //    //dgvListaPedidoDetalle.Rows.Add("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16");   
            //    //GenerarTotales();
            //}
            //Rpt1 = new Reportes.CrystalReportPedidos();
            //Rpt1.SetDataSource(Dts);
            //f.Rpt = Rpt1;
            //f.ShowDialog(this);
        }
    }
}
