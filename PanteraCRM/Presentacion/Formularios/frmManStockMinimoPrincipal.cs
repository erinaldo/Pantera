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
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManStockMinimoAnadir);
            //if (frm != null)
            //{
            //    frm.BringToFront();
            //    return;
            //}
            frmManStockMinimoAnadir f = new frmManStockMinimoAnadir(vBoton);
            f.pasado += new frmManStockMinimoAnadir.pasar(ejecutar);
            f.tmpsaldoalmacen = new saldoalmacen();
            f.tmpsaldoalmacen.p_inidproducto = (int)dgvListaSotck.CurrentRow.Cells["IDPRODUCTO"].Value;
            f.tmpsaldoalmacen.chcodigo = (string)dgvListaSotck.CurrentRow.Cells["CHCODIGO"].Value; 
            f.tmpsaldoalmacen.chnombrecompuesto = (string)dgvListaSotck.CurrentRow.Cells["CHDESCRIPCION"].Value;
            f.tmpsaldoalmacen.nustockminima= (decimal)dgvListaSotck.CurrentRow.Cells["CHSTOCK"].Value;
            //f.MdiParent = this.MdiParent;
            f.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            vBoton = "V";
            cargarFormularioAnadir();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReportesM Re = new Reportes.FrmReportesM();
            CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;

            List<productobuscado> LisPro = productoNE.ListaStockminimoLista();
            DataSet ds = new DataSet();
            //Empresa
            empresas emp = empresaNE.EmpresaBusquedaCodigo(1);
            Dataset.DtsReporte.TEmpresaDataTable dtE = new Dataset.DtsReporte.TEmpresaDataTable();
            ds.Tables.Add(dtE);
            DataRow filaE = dtE.NewRow();
            filaE[0] = emp.chrazonsocial;
            filaE[1] = emp.chruc;
            dtE.Rows.Add(filaE);
            Dataset.DtsReporte.TProductosDataTable dtP = new Dataset.DtsReporte.TProductosDataTable();
            ds.Tables.Add(dtP);
            DataRow fila;

            foreach (productobuscado p in LisPro)
            {
                fila = dtP.NewRow();
                fila[0] = p.p_inidproducto;
                fila[1] = p.chcodigoproducto;
                fila[5] = p.chunidadmedidaproducto;
                fila[11] = p.chnombrecompuesto;
                fila[13] = p.nuprecio;
                dtP.Rows.Add(fila);
            }

            Rpt1 = new Reportes.CrystalReportProductoMinimo();
            Rpt1.SetDataSource(ds);
            Re.Rpt = Rpt1;
            Re.ShowDialog();
        }
    }
}
