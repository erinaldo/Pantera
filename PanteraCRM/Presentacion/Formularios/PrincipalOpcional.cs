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
    public partial class PrincipalOpcional : Form
    {
        protected frmMenu menu { get; set; }
        protected frmFondo fondo { get; set; }
        public PrincipalOpcional()
        {
            InitializeComponent();
        }

        private void PrincipalOpcional_Load(object sender, EventArgs e)
        {
            this.Text = "SISTEMA PANTERA S.A.C. :: BIENVENIDO " ;
            this.cargaMenu();
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
        

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.menu != null)
            {
                this.menu.Height = this.ClientSize.Height - 5;
            }
        }
    }
}
