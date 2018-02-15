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
            frmProcPedidosPedidosDetalle f = new frmProcPedidosPedidosDetalle();
            //f.pasado += new frmProcFacturacionAnadir.pasar(ejecutar);
            f.ShowDialog();
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

        }

        private void txtRucCliente_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
