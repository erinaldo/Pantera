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
    public partial class frmManListaPrecioDetalle : Form
    {
        public frmManListaPrecioDetalle()
        {
            InitializeComponent();
        }

        private void frmManListaPrecioDetalle_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDAR SOLOR NUMEROS Y BORRADO
            if (!(e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1 && !char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;

            }
          
           
        }
    }
}
