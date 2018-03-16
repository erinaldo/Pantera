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
    public partial class frmProcSeparacionExhibicionPrincipal : Form
    {
        string vBoton;
        public frmProcSeparacionExhibicionPrincipal()
        {
            InitializeComponent();
        }

        private void frmProcSeparacionexhibicionPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0,"");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "M";
                if (basicas.validarAcceso(vBoton))
                {
                    cargarFormularioAnadir(vBoton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }

        }

        private void cargarFormularioAnadir(string vBoton)
        {
            if (dgvListaExhibicion.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSeparacionexhibicionAnadir);
            //if (frm != null)
            //{
            //    frm.BringToFront();
            //    return;
            //}
            frmProcSeparacionexhibicionAnadir f = new frmProcSeparacionexhibicionAnadir(vBoton);
            f.pasado += new frmProcSeparacionexhibicionAnadir.pasar(ejecutar);
            f.tmpProductoSerie = new productoserie();
            f.tmpProductoSerie.p_inidproducto = (int)dgvListaExhibicion.CurrentRow.Cells["IDPRODUCTO"].Value;
            f.tmpProductoSerie.chcodigoproducto = (string)dgvListaExhibicion.CurrentRow.Cells["CHPRODUCTO"].Value;
            f.tmpProductoSerie.chdescripcion = (string)dgvListaExhibicion.CurrentRow.Cells["CHDESCRIPCION"].Value;
            f.tmpProductoSerie.p_inidserie = (int)dgvListaExhibicion.CurrentRow.Cells["IDSERIE"].Value;
            f.tmpProductoSerie.chcodigoserie = (string)dgvListaExhibicion.CurrentRow.Cells["CHSERIE"].Value;
            f.tmpProductoSerie.estado = (bool)dgvListaExhibicion.CurrentRow.Cells["BOESTADO"].Value;
            f.tmpProductoSerie.boexhibicion = (bool)dgvListaExhibicion.CurrentRow.Cells["BOEXHIBICION"].Value;
            f.tmpProductoSerie.chinforme = (string)dgvListaExhibicion.CurrentRow.Cells["CHINFORME"].Value;
            f.tmpProductoSerie.chinformeobs =(string)dgvListaExhibicion.CurrentRow.Cells["CHINFORMEOBS"].Value;
            f.tmpProductoSerie.chinformefecha = (string)dgvListaExhibicion.CurrentRow.Cells["CHINFORMEFECHA"].Value;
            f.tmpProductoSerie.chcodigo = (string)dgvListaExhibicion.CurrentRow.Cells["CHCODIGOSERIE"].Value;
            f.tmpProductoSerie.identificador = (string)dgvListaExhibicion.CurrentRow.Cells["CHIDENTIFICADOR"].Value;
            //f.MdiParent = this.MdiParent;
            f.ShowDialog();
        }
        public void cargarData(int registro,string parametro)
        {
            if (parametro.Length > 0)
            {
                List<productoserie> listado = exhibicionNE.ListaProductosSerieExhibicionParametro(parametro);
                dgvListaExhibicion.DataSource = listado;
            }
            else
            {
                List<productoserie> listado = exhibicionNE.ListaProductosSerieExhibicion();
                dgvListaExhibicion.DataSource = listado;
            }
            
        }
        public void ejecutar(int dato)
        {
            cargarData(0,"");
            foreach (DataGridViewRow Row in dgvListaExhibicion.Rows)
            {
                int valor = (int)Row.Cells["IDSERIE"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaExhibicion.CurrentCell = dgvListaExhibicion.Rows[puntero].Cells["CHSERIE"];
                    return;
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "V";
                if (basicas.validarAcceso(vBoton))
                {
                    cargarFormularioAnadir(vBoton);
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
            cargarData(0,parametro);
        }
    }
}
