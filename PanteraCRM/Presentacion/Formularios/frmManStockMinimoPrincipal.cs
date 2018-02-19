using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class frmManStockMinimoPrincipal : Form
    {

        private string vBoton = "A";
        public frmManStockMinimoPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmManStockMinimoPrincipal_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0,"");
        }
        public void cargarData(int registro, string parametro)
        {
            if (parametro == "")
            {
                List<productobuscado> listado = productoNE.ListaPreciosLista();
                dgvListaProdStock.DataSource = listado;
            }
            else
            {
                List<productobuscado> listado = productoNE.ListaPreciosListaParametro(parametro);
                dgvListaProdStock.DataSource = listado;
            }

        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvListaProdStock.Rows)
            {
                int valor = (int)Row.Cells["IDPRODUCTO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaProdStock.CurrentCell = dgvListaProdStock.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManStockMinimoPrincipal);
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
    }
}
