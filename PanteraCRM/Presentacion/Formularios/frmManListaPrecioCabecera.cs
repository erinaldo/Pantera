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
    public partial class frmManListaPrecioCabecera : Form
    {
        public frmManListaPrecioCabecera()
        {
            InitializeComponent();
        }
              

        private void frmManListaPrecioCabecera_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            frmManListaPrecioDetalle fH = new frmManListaPrecioDetalle();
            fH.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
