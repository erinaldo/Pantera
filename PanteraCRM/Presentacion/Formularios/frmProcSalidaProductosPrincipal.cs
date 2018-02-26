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
using Entidades;
using Negocios;
namespace Presentacion
{
    public partial class frmProcSalidaProductosPrincipal : Form
    {
        internal int movimiento = 19;
        public frmProcSalidaProductosPrincipal()
        {
            InitializeComponent();
        }

        private void frmProcSalidaProductosPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0,"");
        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvVales.Rows)
            {
                int valor = (int)Row.Cells["IDVALEC"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvVales.CurrentCell = dgvVales.Rows[puntero].Cells["IDCORRELATIVO"];
                    return;
                }
            }
        }
        public void cargarData(int registro, string parametro)
        {
            if (parametro == "")
            {
                List<valecabecera> listado = valeNE.valesListar(movimiento);
                dgvVales.DataSource = listado;
            }
            else
            {
                List<valecabecera> listado = valeNE.valesListarparmetro(movimiento, parametro);
                dgvVales.DataSource = listado;
            }
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
            try
            {
                string vBoton = "A";

                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSalidaProductosAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmProcSalidaProductosAnadir f = new frmProcSalidaProductosAnadir(vBoton);
                    //f.pasado += new frmProcIngresoValesAnadir.pasar(ejecutar);
                    f.MdiParent = this.MdiParent;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0, parametro);
        }
    }
}
