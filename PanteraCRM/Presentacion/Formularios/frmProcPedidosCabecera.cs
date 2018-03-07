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
                List<pedidodetalle>  listado = new List<pedidodetalle>();
                for (int i = 0; i < dgvListaPedidoDetalle.RowCount; i++)
                {
                    //precio += decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["CHPRECIO"].Value.ToString());
                    importe += decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUIMPORTE"].Value.ToString());
                    preciprod = decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUPRECIOVENTA"].Value.ToString());
                    cantidad = int.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUCANTIDAD"].Value.ToString());
                    preciototal += (decimal.Round(cantidad * preciprod, 2) / ((100+ decimal.Parse(cboigv.Text))/100));
                }              

                txtTotVenta.Text = importe.ToString();
                decimal valorventa = decimal.Round(importe / ((100 + decimal.Parse(cboigv.Text)) / 100), 2);
                txtValVenta.Text = valorventa.ToString();
                decimal igv = importe - valorventa;
                txtIgv.Text = (igv).ToString();

                decimal tdescuentototal = decimal.Round(preciototal - valorventa, 2);
                txtDesctot.Text =tdescuentototal.ToString();
                txtSubtotal.Text = decimal.Round(preciototal, 2).ToString();
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
                    txtTipoCambio.Text = "" + obj2.nucambioventa;
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
            }
            else
            {
                if (vBotonG == "M")
                {

                }else
                {
                    if (vBotonG == "V")
                    {

                    }
                }
            }
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
            int codigo = generarCodigoNE.ObtenerUltimoCodigoPedido(sesion.SessionGlobal.p_inidpuntoventa);
            string seudocorrelativo = "0000000000" + codigo;
            int pini = seudocorrelativo.Length-10;
            int pfin = seudocorrelativo.Length-1;
            string correlativo = seudocorrelativo.Substring(pini, pfin);
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
            this.Dispose();
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
            registrosPedidoCabecera.tmhorapedido = string.Empty;
            registrosPedidoCabecera.p_inidtipodocumento = (int)cboTipoDocu.SelectedValue;
            registrosPedidoCabecera.p_inidcliente = ClienteG.p_inidcodigoclie;
            registrosPedidoCabecera.p_inmotivotransaccion = (int)cboCondVenta.SelectedValue;
            registrosPedidoCabecera.p_inidcompromisopago = (int)cboCondVenta.SelectedValue;
            registrosPedidoCabecera.nuporcenatajedesc = 0;
            registrosPedidoCabecera.chordencompra = string.Empty;
            registrosPedidoCabecera.p_inidalmacen = sesion.SessionGlobal.p_inidalmacen;
            registrosPedidoCabecera.p_inidtransportista = Transportistacodigo;
            registrosPedidoCabecera.p_inidconductor = (int)cboNombreConductor.SelectedValue;
            registrosPedidoCabecera.chplacavehiculo = cboNombreConductor.Text;
            registrosPedidoCabecera.chfechainiciotransporte = txtfechaInicio.Text;
            registrosPedidoCabecera.chpuntopartida = txtPtoPartida.Text;
            registrosPedidoCabecera.chpuntollegada = txtPtoLlegada.Text;
            registrosPedidoCabecera.nuventaafectamonnacional = 0;
            registrosPedidoCabecera.chmotivotransaccion = string.Empty;
            registrosPedidoCabecera.p_inidmoneda = 0;
            registrosPedidoCabecera.p_inidigv = (int)cboigv.SelectedValue;
            registrosPedidoCabecera.boafectoigv = true;
            registrosPedidoCabecera.nuimportecambioventa = 0;
            registrosPedidoCabecera.p_inidvendedor = sesion.SessionGlobal.p_inidusuario;
            registrosPedidoCabecera.chtiempoentrega = string.Empty;

            registrosPedidoCabecera.nuventainafectamonnacional = decimal.Parse(txtSubtotal.Text);
            registrosPedidoCabecera.nutotaldescmonnacional = decimal.Parse(txtDesctot.Text);
            registrosPedidoCabecera.nutotaligvmonnacional = decimal.Parse(txtIgv.Text);
            registrosPedidoCabecera.nutotalventamonnacional = decimal.Parse(txtTotVenta.Text);

            registrosPedidoCabecera.nuventaafectamonextra = decimal.Parse(txtSubtotal.Text);
            registrosPedidoCabecera.nuventainafectamonextra = decimal.Parse(txtDesctot.Text);
            registrosPedidoCabecera.nutotaldescmonextra = decimal.Parse(txtIgv.Text);
            registrosPedidoCabecera.nutotaligvmonextra = decimal.Parse(txtIgv.Text);
            registrosPedidoCabecera.nutotalventamonextra = decimal.Parse(txtTotVenta.Text);

            registrosPedidoCabecera.p_inidsituacionpedido = 0;
            registrosPedidoCabecera.chobservacion = txtObs.Text;
            registrosPedidoCabecera.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
            //registrosPedidoCabecera.p_inidusuariodelete = 0;
            registrosPedidoCabecera.estado = true;
            registrosPedidoCabecera.p_inidvehiculo = (int)cboVehiculo.SelectedValue;
            int codigocabecera = pedidoNE.IngresoPedidoCabecera(registrosPedidoCabecera);
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
                        RegistrosPedidosDetalle.p_inidpedidocabecera = codigocabecera;
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
                        codigodetalle = pedidoNE.IngresoPedidoDetalle(RegistrosPedidosDetalle);
                    }
                }
                //dgvListaPedidoDetalle.Rows.Add("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16");   
                //GenerarTotales();
            }
            


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
            if (ClienteG != null)
            {
                
                txtNombreCliente.Text = ClienteG.razon;
                txtRucCliente.Text = ClienteG.nrodocumento;
                LicenciaG = clienteNE.LicenciaBusquedaCodigo(ClienteG.p_inidcodigoclie);
                TarjetaG = clienteNE.TarjetaPropiedadBusquedaCodigo(ClienteG.p_inidcodigoclie);
                txtLicencia.Text = LicenciaG.chlicencia;
                txtVencLicencia.Text = LicenciaG.fechavencimiento;
                cboTarjeta.DataSource = TarjetaG;
                cboTarjeta.ValueMember = "p_inidtarjeta";
                cboTarjeta.DisplayMember = "chtarjeta";
                txtPtoLlegada.Text = ClienteG.chdireccion;

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
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmBusClientePrincipal);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmBusClientePrincipal f = new frmBusClientePrincipal();
            f.Pasado += new frmBusClientePrincipal.PasarClienteCodigo(PonerCodigocliente);
            f.MdiParent = this.MdiParent;
            f.Show();
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
    }
}
