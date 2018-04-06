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
    public partial class frmConsCobranzaDocuVentaPrincipal : Form
    {
        public frmConsCobranzaDocuVentaPrincipal()
        {
            InitializeComponent();
        }

        private void frmConsCobranzaDocuVentaPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            CargarDatos();
        }
        public void CargarDatos()
        {
            cboTipoDoc.DataSource = tipodocumentoNE.ListarTipoDocumentosVentaParametro(true);
            cboTipoDoc.ValueMember = "p_inidtipodocumento";
            cboTipoDoc.DisplayMember = "chacrominodocumento";
        }
        public void ValidarComprobante()
        {
            if (cboTipoDoc.Text == "FC")
            {
                busquedaDocumento("F");

            }
            else if (cboTipoDoc.Text == "BV")
            {
                busquedaDocumento("B");
            }
            else
            {
                busquedaDocumento("NV");
            }
        }
        internal pedidoguicomp PedidoFacturado = null;
        public void busquedaDocumento(string parametro)
        {
            PedidoFacturado = pedidoNE.BuscarComprobantesFacturados(parametro, txtCodDocu.Text);

           
            if (PedidoFacturado.p_inidpedidoguicomp != 0)
            {
                CargarDatosCabecera(PedidoFacturado.p_inidpedidoguicomp);
            }
            else
            {
                BalquearCampos();

            }
        }
        internal pedidocabecera pedCab;
        public void CargarDatosCabecera(int codigo)
        {
            pedCab = pedidoNE.PedidoCabeceraBusquedaCodigo(codigo);          
            Mcliente Registroscliente = clienteNE.ClienteBusquedaCodigo(pedCab.p_inidcliente);
            BuscarClienteCodigo(Registroscliente.chcodigocliente);
            txtFecha.Text = pedCab.chfechapedido;
            txtMoneda.Text = "S/.";
            txtImporte.Text = pedCab.nutotalventamonnacional.ToString("N2");
            dgvPlanilla.Rows.Clear();
            
        }

        public void BuscarClienteCodigo(string codigo)
        {
            clientebusqueda ClienteG = clienteNE.ClienteBusquedaCodigoSecundario(codigo);            
            if (ClienteG != null)
            {
                lblTipDoc.Text = ClienteG.tipodocu;
                txtNroDoc.Text = ClienteG.nrodocumento;
                txtRazon.Text = ClienteG.razon;
            }
        }
        public void BalquearCampos()
        {

            dgvPlanilla.Rows.Clear();
            txtFecha.Text = string.Empty;
            txtMoneda.Text = string.Empty;
            txtImporte.Text = string.Empty;
            txtNroDoc.Text = string.Empty;
            txtRazon.Text = string.Empty;
            txtMone.Text = string.Empty;
            txtMone2.Text = string.Empty;
            txtCancela.Text = string.Empty;
            txtSaldo.Text = string.Empty;
        }
        private void txtCodDocu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodDocu_Validated(object sender, EventArgs e)
        {
            TextBox TextoUsado = (TextBox)sender;
            utilidades.ValidarCampoDocumento(ref TextoUsado, e);
            ValidarComprobante();
        }

        private void txtCodDocu_Enter(object sender, EventArgs e)
        {
             BeginInvoke((Action)delegate { utilidades.SetTextBoxSelectAll((TextBox)sender); });
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            decimal pagado = 0;
            if (PedidoFacturado.p_inidpedidoguicomp != 0)
            {
                List<placobd> ListaPlanila = pedidoNE.PlanillacobroDetalleBusqueda(txtCodDocu.Text, (int)cboTipoDoc.SelectedValue);
                if (ListaPlanila.Count > 0)
                {
                    foreach (placobd Resgitros in ListaPlanila)
                    {
                        string ref1="";
                        string ref2="";
                        if (Resgitros.chobservacion != "")
                        {
                            var con = Resgitros.chobservacion.Split('|');
                            ref1 = con[0];
                            ref2 = con[1];
                        }                        
                        dgvPlanilla.Rows.Add(Resgitros.p_inidplacod, Resgitros.chcorreplacobc, Resgitros.chfecha, Resgitros.chcorrerecibo, Resgitros.nuimporpagmonenac, ref1, ref2);
                        pagado += Resgitros.nuimporpagmonenac;
                    }
                }
                txtMone.Text = "S/.";
                txtCancela.Text = pagado.ToString("N2");
                txtMone2.Text = "S/.";
                txtSaldo.Text = (pedCab.nutotalventamonnacional - pagado).ToString("N2");
            }
            else
            {

            }

        }
        public void cargarTabla()
        {

        }
    }
}
