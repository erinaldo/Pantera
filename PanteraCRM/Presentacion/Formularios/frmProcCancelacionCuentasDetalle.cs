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
    public partial class frmProcCancelacionCuentasDetalle : Form
    {

        public delegate void pasar(int varible);
        public event pasar pasado;
        internal string RazonG;
        internal string NroDocG;
        internal string codigoG;
        internal int p_inidCliente;
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
            txtFechaReg.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            cboBanco.DataSource =bancoNE.BancoListar();
            cboBanco.ValueMember = "p_inidbanco";
            cboBanco.DisplayMember = "chnombrebanco";
            cboMoneda.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(13);
            cboMoneda.ValueMember = "idmaestrodetalle";
            cboMoneda.DisplayMember = "nombreitem";
            cbotipoPago.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(24);
            cbotipoPago.ValueMember = "idmaestrodetalle";
            cbotipoPago.DisplayMember = "nombreitem";

            int index3 = cbotipoPago.FindString("PAGO EN EFECTIVO");
            cbotipoPago.SelectedIndex = index3;
            //string correlativo = generarCodigoNE.ObtenerCorrelativo(sesion.SessionGlobal.p_inidpuntoventa);
            List<RegistroVenta> RegistroVenta = new List<RegistroVenta>();
            RegistroVenta = pedidoNE.BuscarRegistroVentasCliente(p_inidCliente);
            foreach (RegistroVenta Registros in RegistroVenta)
            {
                if (Registros.p_inidtipodocu == 4 || Registros.p_inidtipodocu == 5 )
                {
                    dgvDocumentosPendientes.Rows.Add(DevolverNombrecomprobante(Registros.p_inidtipodocu), Registros.chcodigodocu, "", Registros.chfechadoc, "S/.", (-1)*Registros.nuimportetotvta);
                }
                else
                {
                    dgvDocumentosPendientes.Rows.Add(DevolverNombrecomprobante(Registros.p_inidtipodocu), Registros.chcodigodocu, "", Registros.chfechadoc, "S/.", Registros.nuimportetotvta);
                }
                
            }
            List<tipocambio> listado2 = tipocambioNE.busquedaValorTipoCambio(txtFechaReg.Text);
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
        private string DevolverNombrecomprobante(int codigo)
        {
            tipodocumento tipodocumentos = tipodocumentoNE.documentoVentaBusquedacodigo(codigo);
            return tipodocumentos.chacrominodocumento;
        }
        private void dgvDocumentosPendientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvDocumentosSeleccionados.Rows.Add(
                dgvDocumentosPendientes.CurrentRow.Cells["CHTIPO"].Value, 
                dgvDocumentosPendientes.CurrentRow.Cells["CHDOC"].Value,
                dgvDocumentosPendientes.CurrentRow.Cells["CHREN"].Value,
                dgvDocumentosPendientes.CurrentRow.Cells["CHFECHA"].Value,
                dgvDocumentosPendientes.CurrentRow.Cells["CHMONE"].Value,
                dgvDocumentosPendientes.CurrentRow.Cells["NUMONTO"].Value);
            dgvDocumentosPendientes.Rows.RemoveAt(e.RowIndex);
            TotalesDgvPediente();
            TotalesDgvSeleccion();
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



        /*FIN :: FUNCIONES BASES*/
    }
}
