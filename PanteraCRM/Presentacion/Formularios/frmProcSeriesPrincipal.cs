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
    public partial class frmProcSeriesPrincipal : Form
    {
        public frmProcSeriesPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSeriesAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            string vboton = "A";
            frmProcSeriesAnadir f = new frmProcSeriesAnadir(vboton);
            f.Show();
        }

       
    }
}
