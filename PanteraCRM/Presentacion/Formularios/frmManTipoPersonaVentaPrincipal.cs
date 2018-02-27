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
    public partial class frmManTipoPersonaVentaPrincipal : Form
    {
        public frmManTipoPersonaVentaPrincipal()
        {
            InitializeComponent();
        }
        
        private void frmManTipoPersonaVentaPrincipal_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string vBoton = "A";
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManTipoPersonaVentaAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmManTipoPersonaVentaAnadir f = new frmManTipoPersonaVentaAnadir();
                    //f.pasado += new frmManTipoPersonaVentaAnadir.pasar(ejecutar);
                    f.ShowDialog();
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

        private void btnVer_Click(object sender, EventArgs e)
        {

        }
    }
}
