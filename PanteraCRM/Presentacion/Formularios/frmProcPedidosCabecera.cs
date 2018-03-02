﻿using System;
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
        List<pedidodetalle> tmbpedidodetalle;
        internal clientebusqueda ClienteG;
        internal licencia LicenciaG;
        internal List<tarjetapropiedad> TarjetaG;
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
                    f.PasadoDetalle += new frmProcPedidosDetalle.PasarDetalle(CargarAdionar);
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
        private void CargarAdionar(List<pedidodetalle> ListaPedido,pedidodetalle RegistroPedido, bool Flat)
        {
            int val = 0;
            val++;
            if (Flat)
            {
                foreach (pedidodetalle obj in ListaPedido)
                {
                    string nombrecompuesto = obj.chnombrecompuesto;
                    string codigo = obj.chcodigoproducto;
                    int idproducto = obj.p_inidproducto;
                    decimal cantidad = obj.nucantidad;
                    decimal stock = obj.nustock;
                    decimal precio = obj.nuprecioventa;
                    decimal desc1 = obj.nuporcentajedesc1;
                    decimal desc2 = obj.nuporcentajedesc2;
                    decimal importe = obj.nuimportesubtotal;
                    decimal preunit = obj.nuprecioproducto;
                    string sval = "000" + val;
                    int pini = sval.Length - 3;
                    int pfin = sval.Length - 1;
                    dgvListaPedidoDetalle.Rows.Add("1", "2", sval.Substring(pini, pfin), idproducto, codigo, "1", stock, nombrecompuesto, obj.chserie, preunit, precio, desc1, desc2, importe, "15", "16");
                }
                //dgvListaPedidoDetalle.Rows.Add("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16");
            }
            else
            {
                string nombrecompuesto = RegistroPedido.chnombrecompuesto;
                string codigo = RegistroPedido.chcodigoproducto;
                int idproducto = RegistroPedido.p_inidproducto;
                decimal cantidad = RegistroPedido.nucantidad;
                decimal stock = RegistroPedido.nustock;
                decimal precio = RegistroPedido.nuprecioventa;
                decimal desc1 = RegistroPedido.nuporcentajedesc1;
                decimal desc2 = RegistroPedido.nuporcentajedesc2;
                decimal importe = RegistroPedido.nuimportesubtotal;
                decimal preunit = RegistroPedido.nuprecioproducto;
                string sval = "000" + val;
                int pini = sval.Length - 3;
                int pfin = sval.Length - 1;
                //dgvListaPedidoDetalle.Rows.Add("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16");
                dgvListaPedidoDetalle.Rows.Add("1", "2", sval.Substring(pini, pfin), idproducto, codigo, cantidad, stock, nombrecompuesto, "-", preunit,precio, desc1, desc2, importe, "15", "16");
                //f.tmbpedidodetalle.chnombrecompuesto;
            }
            GenerarTotales();
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
                    preciototal += decimal.Round(cantidad * preciprod, 2);
                }              

                txtTotVenta.Text = importe.ToString();
                decimal valorventa = decimal.Round(importe / decimal.Parse("1.18"), 2);
                txtValVenta.Text = valorventa.ToString();
                decimal igv = importe - valorventa;
                txtIgv.Text = (igv).ToString();
                decimal tdescuentototal = decimal.Round(preciototal - valorventa,2);
                txtDesctot.Text =tdescuentototal.ToString();
                txtSubtotal.Text = (valorventa- tdescuentototal).ToString();
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
            txtNombreAlmacen.Text = sesion.SessionGlobal.chalamacen;
            txtNombreVendedor.Text = sesion.SessionGlobal.chnombrepersona;
            txtFechaActual.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            List<transportista> listado = transportistaNE.ListaTransportista();
            foreach (transportista obj in listado)
            {
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
            DialogResult result = MessageBox.Show("Esta seguro de Registrar el pedido", "MENSAJE DE SISTEMA", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Registros Grabados", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Cancelo la Grabacion ", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}