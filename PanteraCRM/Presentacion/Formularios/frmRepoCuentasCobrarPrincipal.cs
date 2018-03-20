using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmRepoCuentasCobrarPrincipal : Form
    {
        public frmRepoCuentasCobrarPrincipal()
        {
            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbkGeneral_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void CargarBeans()
        {
            cboVendedores.Visible = false;
            txtClieCod.Visible = false;
            lblCodigo.Visible = false;
            lblNroIden.Visible = false;
            txtNroDocuIden.Visible = false;
            txtNomClie.Visible = false;
            rbtOrdVendedor.Checked = true;
            rbtDesPantalla.Checked = true;
        }

        private void frmRepoCuentasCobrarPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            CargarBeans();
        }

        private void rbtGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtGeneral.Checked == true)
            {
                cboVendedores.Visible = false;
                txtClieCod.Visible = false;
                lblCodigo.Visible = false;
                lblNroIden.Visible = false;
                txtNroDocuIden.Visible = false;
                txtNomClie.Visible = false;
            }
        }

        private void rbtVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtVendedor.Checked == true)
            {
                cboVendedores.Visible = true;
                txtClieCod.Visible = false;
                lblCodigo.Visible = false;
                lblNroIden.Visible = false;
                txtNroDocuIden.Visible = false;
                txtNomClie.Visible = false;
            }
        }

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCliente.Checked == true)
            {
                cboVendedores.Visible = false;
                txtClieCod.Visible = true;
                lblCodigo.Visible = true;
                lblNroIden.Visible = true;
                txtNroDocuIden.Visible = true;
                txtNomClie.Visible = true;
            }

        }
    }
}
