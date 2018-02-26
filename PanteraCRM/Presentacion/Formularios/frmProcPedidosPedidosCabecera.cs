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
    public partial class frmProcPedidosPedidosCabecera : Form
    {
        List<pedidodetalle> tmbpedidodetalle;
        public frmProcPedidosPedidosCabecera()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            int val = 0;
            List<pedidodetalle> listado = null;
            
            if (dgvListaPedidoDetalle.RowCount > 0)
            {
                listado =new List<pedidodetalle>();
                for (int i = 0; i < dgvListaPedidoDetalle.RowCount; i++)
                {
                    pedidodetalle registros = new pedidodetalle();
                    registros.p_inidproducto = int.Parse(dgvListaPedidoDetalle.Rows[i].Cells["IDPRODUCTO"].Value.ToString());
                    registros.nucantidad = decimal.Parse(dgvListaPedidoDetalle.Rows[i].Cells["NUCANTIDAD"].Value.ToString());
                    listado.Add(registros);
                }
            }
            frmProcPedidosPedidosDetalle f = new frmProcPedidosPedidosDetalle();
            f.tmplistadovalidar = listado;
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                val++;
                tmbpedidodetalle = f.tmplistado;
                if (f.reqserie)
                {
                    foreach (pedidodetalle obj in tmbpedidodetalle)
                    {
                        string nombrecompuesto = obj.chnombrecompuesto;
                        string codigo = obj.chcodigoproducto;
                        int idproducto = obj.p_inidproducto;
                        decimal cantidad = obj.nucantidad;
                        decimal stock = obj.nustock;
                        decimal precio =obj.nuprecioventa;
                        decimal desc1 = obj.nuporcentajedesc1;
                        decimal desc2 = obj.nuporcentajedesc2;
                        decimal importe = obj.nuimportesubtotal;
                        string sval = "000" + val;
                        int pini = sval.Length - 3;
                        int pfin = sval.Length - 1;
                        dgvListaPedidoDetalle.Rows.Add("1", "2", sval.Substring(pini, pfin), idproducto, codigo, "1", stock, nombrecompuesto, obj.chserie, precio, desc1, desc2, "", importe, "15", "16");
                    }
                    //dgvListaPedidoDetalle.Rows.Add("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16");
                }
                else
                {
                    string nombrecompuesto = f.tmbpedidodetalle.chnombrecompuesto;
                    string codigo = f.tmbpedidodetalle.chcodigoproducto;
                    int idproducto = f.tmbpedidodetalle.p_inidproducto;
                    decimal cantidad = f.tmbpedidodetalle.nucantidad;
                    decimal stock = f.tmbpedidodetalle.nustock;
                    decimal precio = f.tmbpedidodetalle.nuprecioventa;
                    decimal desc1 = f.tmbpedidodetalle.nuporcentajedesc1;
                    decimal desc2 = f.tmbpedidodetalle.nuporcentajedesc2;
                    decimal importe = f.tmbpedidodetalle.nuimportesubtotal;
                    string sval = "000" + val;
                    int pini = sval.Length - 3;
                    int pfin = sval.Length - 1;
                    //dgvListaPedidoDetalle.Rows.Add("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16");
                    dgvListaPedidoDetalle.Rows.Add("1", "2", sval.Substring(pini, pfin), idproducto, codigo, cantidad, stock, nombrecompuesto, "-", precio, desc1, desc2, "", importe, "15", "16");
                    //f.tmbpedidodetalle.chnombrecompuesto;
                }

            }
            
        }

        private void frmProcPedidosPedidosCabecera_Load(object sender, EventArgs e)
        {
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

            }else
            {
                txtTipoCambio.Text = "0.00";
            }
            
            txtSubtotal.Text = "0.00";
            txtDesctot.Text = "0.00";
            txtIgv.Text = "0.00";
            txtValVenta.Text = "0.00";
            txtTotVenta.Text = "0.00";
            txtDesc.Text = "0.00";
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

        private void txtRucCliente_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtRucCliente.Text;
            Busquedacliente(parametro);
        }

        private void txtRucCliente_DoubleClick(object sender, EventArgs e)
        {
            frmBusClientePrincipal f = new frmBusClientePrincipal();
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                string parametro= f.tmpcliente.nrodocumento;
                Busquedacliente(parametro);
            }            
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
    }
}
