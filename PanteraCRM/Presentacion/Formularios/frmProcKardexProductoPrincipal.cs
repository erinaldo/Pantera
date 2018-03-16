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
    public partial class frmProcKardexProductoPrincipal : Form
    {
        public frmProcKardexProductoPrincipal()
        {
            InitializeComponent();
        }

        private void frmProcKardexProductoPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargaData("");
        }
        private void cargaData(string parametro)
        {
            if (parametro == "")
            {
                List<productobuscado> listado = productoNE.ListaProductosKardex();
                dgvListaPrecios.DataSource = listado;
            }
            else
            {
                List<productobuscado> listado = productoNE.ListaProductosKardexBusquedaParametro(parametro);
                dgvListaPrecios.DataSource = listado;
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    if (dgvListaPrecios.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcKardexProductoDetalle);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmProcKardexProductoDetalle f = new frmProcKardexProductoDetalle();
                    productobuscado ProdBusca = new productobuscado();
                    ProdBusca.p_inidproducto = (int)dgvListaPrecios.CurrentRow.Cells["IDPRODUCTO"].Value;
                    ProdBusca.chcodigoproducto = dgvListaPrecios.CurrentRow.Cells["CHCODIGO"].Value.ToString();
                    ProdBusca.chnombrecompuesto = dgvListaPrecios.CurrentRow.Cells["CHDESCRIPCION"].Value.ToString();
                    ProdBusca.chunidadmedidaproducto = dgvListaPrecios.CurrentRow.Cells["CHMEDIDA"].Value.ToString();
                    f.ProductoBuscado = ProdBusca;
                    //f.pasado += new frmManProductoAnadir.pasar(ejecutar);
                    //f.MdiParent = this.MdiParent;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametro.Text;
            cargaData(parametro);
        }
    }
}
