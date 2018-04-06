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
    public partial class frmTipoDeCambio : Form
    {
        public frmTipoDeCambio()
        {
            InitializeComponent();
        }

       
        private void frmTipoDeCambio_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            txtFecha.Text = DateTime.Now.ToShortDateString().PadLeft(10, '0');
            cboMoneda.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(17);
            cboMoneda.ValueMember = "idmaestrodetalle";
            cboMoneda.DisplayMember = "libre";
            txtVenta.Text = "0.00";
            txtCompra.Text = "0.00";
            cboMoneda.Focus();
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.solonumeros(ref textboxusado, e);
        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
        TextBox textboxusado = (TextBox)sender;
        utilidades.solonumeros(ref textboxusado, e);
    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tipocambio registro = new tipocambio();
                registro.chfechacambio = txtFecha.Text;
                registro.p_inidmoneda = (int)cboMoneda.SelectedValue;
                registro.p_inidusuariodelete = sesion.SessionGlobal.p_inidusuario;
                registro.p_inidusuarioinsert = sesion.SessionGlobal.p_inidusuario;
                registro.nucambioventa = decimal.Parse(txtVenta.Text);
                registro.nucambiocompra = decimal.Parse(txtCompra.Text); 
                registro.nucambiopon = 0;
                int flat = tipocambioNE.IngresarTipoCambio(registro);
                if (flat <= 0)
                {
                    MessageBox.Show("error en el ingreso", "Mensaje de Sistema");
                    return;
                }
            }
            else
            {
                return;
            }
            this.Dispose();
        }
        public bool ValidarCampos()
        {
            bool flat = false;
            decimal valor1 = 0;
            decimal valor2 = 0;
            if (txtCompra.Text.Length > 0)
            {
                valor1 = decimal.Parse(txtCompra.Text);
            }
            if (txtVenta.Text.Length > 0)
            {
                valor2 = decimal.Parse(txtVenta.Text);
            }
            if (valor1 > 0 )
            {
                if (valor2 > 0)
                {
                    flat = true;
                }else
                {

                    MessageBox.Show("Valor de Venta no Válido", "Mensaje de Sistema");
                }
            }else
            {

                MessageBox.Show("Valor de Compra no Válido", "Mensaje de Sistema");
            }
            return flat;
        }

        private void txtCompra_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { utilidades.SetTextBoxSelectAll((TextBox)sender); });
        }

        private void txtVenta_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { utilidades.SetTextBoxSelectAll((TextBox)sender); });
        }

        private void txtCompra_Validated(object sender, EventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.ValidarNumero(ref textboxusado, e);
        }

        private void txtVenta_Validated(object sender, EventArgs e)
        {
            TextBox textboxusado = (TextBox)sender;
            utilidades.ValidarNumero(ref textboxusado, e);
        }
    }
}
