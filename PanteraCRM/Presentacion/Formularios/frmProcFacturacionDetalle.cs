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
    public partial class frmProcFacturacionDetalle : Form
    {
        public frmProcFacturacionDetalle()
        {
            InitializeComponent();
        }

       

        private void frmProcFacturacionDetalle_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            txtCant.Text = "0.00";
            txtDesc1.Text = "0.00";
            txtDesc2.Text = "0.00";
            txtImporte.Text = "0.00";
            txtPreUnit.Text = "0.00";
            txtStock.Text = "0";
            txtPrecioVenta.Text = "0.00";
        }

       

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            frmBusquedaProductoFacturacion fo = new frmBusquedaProductoFacturacion();
            fo.ShowDialog();
        }

        private void txtCodigo_MouseClick(object sender, MouseEventArgs e)
        {

            frmBusquedaProductoFacturacion fo = new frmBusquedaProductoFacturacion();
            fo.ShowDialog();
        }

       
    }
}
