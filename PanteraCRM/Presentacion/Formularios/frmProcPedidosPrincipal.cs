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
    public partial class frmProcPedidosPrincipal : Form
    {
        public frmProcPedidosPrincipal()
        {
            InitializeComponent();
        }


        string vBoton;
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmProcPedidosPrincipal_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcPedidosCabecera);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmProcPedidosCabecera f = new frmProcPedidosCabecera(vBoton);
                    //f.pasado += new frmManClienteAnadir.pasar(ejecutar);
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Error de Acceso", "Mensaje de Sistema", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
    }
}
