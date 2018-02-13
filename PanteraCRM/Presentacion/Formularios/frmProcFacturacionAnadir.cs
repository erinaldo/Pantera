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
    public partial class frmProcFacturacionAnadir : Form
    {
        public frmProcFacturacionAnadir()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            
            //frmProcFacturacionDetalle fs = new frmProcFacturacionDetalle();
            //f.pasado += new frmProcFacturacionAnadir.pasar(ejecutar);
           // fs.ShowDialog();
        }

       

        private void frmProcFacturacionAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
        }

      
    }
}
