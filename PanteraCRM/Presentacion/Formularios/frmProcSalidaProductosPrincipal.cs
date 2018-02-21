using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Presentacion
{
    public partial class frmProcSalidaProductosPrincipal : Form
    {
        public frmProcSalidaProductosPrincipal()
        {
            InitializeComponent();
        }

        private void frmProcSalidaProductosPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSalidaProductosAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            this.Dispose();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSalidaProductosAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmProcSalidaProductosAnadir frm1 = new frmProcSalidaProductosAnadir();
            frm1.MdiParent = this.MdiParent;
            frm1.Show();
        }
        public void cheCarForm(Form frmhijo, Form frmpapa)
        {
            bool cargado = false;
            foreach (Form llamado in frmpapa.MdiChildren)
            {
                if (llamado.Text == frmhijo.Text)
                {
                    cargado = true;
                    break;
                }
            }
            if (!cargado)
            {
                frmhijo.MdiParent = frmpapa;
                frmhijo.Show();
            }
        }
    }
}
