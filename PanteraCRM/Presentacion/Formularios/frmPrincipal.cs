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
    public partial class frmPrincipal : Form
    {
        protected frmMenu menu { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        protected void cargaMenu()
        {
            if (this.menu == null)
            {
                this.menu = new frmMenu();
                this.menu.MdiParent = this;
            }
            this.menu.Height = this.ClientSize.Height - 5;
            this.menu.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.cargaMenu();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.menu!=null)
            {
                this.menu.Height = this.ClientSize.Height - 5;
            }
        }
    }
}
