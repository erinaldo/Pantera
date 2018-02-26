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
                List<productobuscado> listado = productoNE.ListaStockminimoLista();
                dgvListaSotck.DataSource = listado;
            }
            else
            {
                List<productobuscado> listado = productoNE.ListaStockMinimoParametro(parametro);
                dgvListaSotck.DataSource = listado;
            }

        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvListaSotck.Rows)
            {
                int valor = (int)Row.Cells["IDPRODUCTO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaSotck.CurrentCell = dgvListaSotck.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                vBoton = "M";
                cargarFormularioAnadir();

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
        private void cargarFormularioAnadir()
        {
            if (dgvListaSotck.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManStockMinimoAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmManStockMinimoAnadir f = new frmManStockMinimoAnadir(vBoton);
            f.pasado += new frmManStockMinimoAnadir.pasar(ejecutar);
            f.tmpsaldoalmacen = new saldoalmacen();
            f.tmpsaldoalmacen.p_inidproducto = (int)dgvListaSotck.CurrentRow.Cells["IDPRODUCTO"].Value;
            f.tmpsaldoalmacen.chcodigo = (string)dgvListaSotck.CurrentRow.Cells["CHCODIGO"].Value; 
            f.tmpsaldoalmacen.chnombrecompuesto = (string)dgvListaSotck.CurrentRow.Cells["CHDESCRIPCION"].Value;
            f.tmpsaldoalmacen.nustockminima= (decimal)dgvListaSotck.CurrentRow.Cells["CHSTOCK"].Value;
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            vBoton = "V";
            cargarFormularioAnadir();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
