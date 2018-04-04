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
namespace Presentacion
{
    public partial class frmProcPedidosPrincipal : Form
    {
        internal string correlativo = "";
        internal string nombrecompro = "";
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
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcPedidosCabecera);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmProcPedidosCabecera f = new frmProcPedidosCabecera(vBoton);
                    f.PasadoCabecera += new frmProcPedidosCabecera.PasarCabecera(ejecutar);
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
            if (dgvPedidos.CurrentRow.Cells["CHESTADO"].Value.ToString() == "ACTIVO")
            {
                frmProcPedidosCabecera f = new frmProcPedidosCabecera(vBoton);
                f.PasadoCabecera += new frmProcPedidosCabecera.PasarCabecera(ejecutar);
                f.CodigoPedidoCabecera = (int)dgvPedidos.CurrentRow.Cells["IDPEDIDO"].Value;
                f.ShowDialog();
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
                        //MessageBox.Show("codigoi Serie: "+ obj.p_inidserie, "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        serieNE.SeriesFalsearPedido(obj.p_inidserie,true);
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
            //string vBoton = "I";
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
                CargarDatosCabecera((int)dgvPedidos.CurrentRow.Cells["IDPEDIDO"].Value);
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
        private void CargarDatosCabecera(int CodigoPedidoCabecera)
        {
            pedidocabecera pedCab = pedidoNE.PedidoCabeceraBusquedaCodigo(CodigoPedidoCabecera);
            List<tipodocumento> ListaTipdoc = tipodocumentoNE.ListarDocumentosVenta();

            Mcliente Registroscliente = clienteNE.ClienteBusquedaCodigo(pedCab.p_inidcliente);
            clientebusqueda ClienteG = clienteNE.ClienteBusquedaCodigoSecundario(Registroscliente.chcodigocliente);
            
            
            string licenciaaaa = "";
            string fechavencilli = "";
            List <licencia> LicenciaG = clienteNE.LicenciaBusquedaCodigo(ClienteG.p_inidcodigoclie);
            foreach (licencia aa in LicenciaG)
            {
                if (aa.p_inidlicencia == pedCab.p_inidlicencia)
                {
                    licenciaaaa= aa.chlicencia;
                    fechavencilli = aa.fechavencimiento;
                }
            }
            string rd = "";
            string vencird = "";
            if (ClienteG.tipodocu == "RUC")
            {
                rd = licenciaaaa;
                vencird = fechavencilli;
            }
            else
            {
                rd = "";
                vencird = "";
            }
            Reportes.FrmReporte f = new Reportes.FrmReporte();
            string tipocodicmento = "";
            foreach (tipodocumento objTipodic in ListaTipdoc)
            {
                if (objTipodic.p_inidtipodocumento == pedCab.p_inidtipodocumento)
                {
                    tipocodicmento =objTipodic.chacrominodocumento;
                }
            }
            string condicionpago = "";
            List<condicionpago> cboCondVenta = condicionpagoNE.ListaCondicionPago();
            foreach (condicionpago objcondpago in cboCondVenta)
            {
                if (objcondpago.p_inidcondicionpago == pedCab.p_inidcompromisopago)
                {
                    condicionpago = objcondpago.chnombrepago;
                }
            }
            f.tipocomprobante = tipocodicmento;
            CargarDatosCorrelativos(tipocodicmento);
            f.codigopedido = pedCab.chcodigopedido;
            f.p_inidcodigopedido = CodigoPedidoCabecera;
            CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;
            DataSet Dts = new DtsPedidos();
            /*PRA CABECERA*/
            Dts.Tables["cabecera"].LoadDataRow(new object[]
            {
                ClienteG.razon,
                ClienteG.chdireccion,
                "LIMA",
                "976566115",
                ClienteG.nrodocumento,
                pedCab.chordencompra,
                ClienteG.chcodigocliente,
                pedCab.chfechapedido,
                pedCab.chfechainiciotransporte,
                pedCab.p_inidusuarioinsert,
                pedCab.chcodigopedido,
                condicionpago,
                pedCab.codigolicencia,
                pedCab.vencilicencia,
                pedCab.codigotarjeta,
                pedCab.vencitarjeta,

                 correlativo,
            nombrecompro,
                basicas.Convertir(pedCab.nutotalventamonnacional.ToString(),true),
                //txtValVenta.Text,
                string.Format("{0:0,0.00}", pedCab.nuventainafectamonnacional),
                "0",
                "0",
                "0",
                string.Format("{0:0,0.00}", pedCab.nutotaligvmonnacional),
                //txtIgv.Text,
                string.Format("{0:0,0.00}", pedCab.nutotalventamonnacional),
                //txtTotVenta.Text,
                sesion.SessionGlobal.chpuntoventa,
                "10717767603",rd,vencird
            }, true);
            CargarDatosDetalle(CodigoPedidoCabecera);
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
            }
            Rpt1 = new Reportes.CrystalReportPedidos();
            Rpt1.SetDataSource(Dts);
            f.Rpt = Rpt1;
            f.ShowDialog(this);
            ejecutar(CodigoPedidoCabecera);

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
      
    }
}
