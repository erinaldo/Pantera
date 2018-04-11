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

using Presentacion.Dataset;
namespace Presentacion
{
    public partial class frmRepoReposicionStockPrincipal : Form
    {
        public frmRepoReposicionStockPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Crearimpresion();

        }
        private void Crearimpresion()
        {
            Reportes.FrmReportesM f = new Reportes.FrmReportesM();
            CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;
            DataSet Dts = new DtsPedidos();
            /*PRA CABECERA*/
            int orden = 1;
            List<productostockminimo> Lista = new List<productostockminimo>();
            if (cbkTodos.Checked)
            {
                Lista = productoNE.ListaStockminimoListado();
                if (Lista.Count <= 0)
                {
                    MessageBox.Show("No se encontraron resultados", "Mensaje de Sistema", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                Lista = productoNE.ListaStockminimoListadoParametro((int)cboCategoria.SelectedValue);
                if (Lista.Count <= 0)
                {
                    MessageBox.Show("No se encontraron resultados", "Mensaje de Sistema", MessageBoxButtons.OK);
                    return;
                }
            }
            foreach (productostockminimo registro in Lista)
            {
                Dts.Tables["stockminimo"].LoadDataRow(new object[]
            {registro.p_inidproducto,
                registro.chcodigoproducto,
                registro.producto ,
                registro.nustockactual ,
                sesion.SessionGlobal.chpuntoventa,
                "DIRECCION: AV. DEFENSORES DEL MORRO  N° 666  OF. 44, 45 y 46 - CHORRILLOS - LIMA - PERU",
                "RUC: 20522355292",
                "REGISTRO DE VENTAS",
                "MES:"
            }, true);

            }
            Dts.AcceptChanges();
            Rpt1 = new Reportes.CrystalReportProductostockminimo();
            Rpt1.SetDataSource(Dts);
            f.Rpt = Rpt1;
            f.ShowDialog(this);
        }
      

        private void cbkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkTodos.Checked)
            {
                cboCategoria.Enabled = false;
            }else
            {
                cboCategoria.Enabled = true;

            }
        }

        private void frmRepoReposicionStockPrincipal_Load(object sender, EventArgs e)
        {
            cboCategoria.DataSource = maestrodetalleNE.ListarCategorias();
            cboCategoria.ValueMember = "p_inidcategoria";
            cboCategoria.DisplayMember = "chcategoria";
        }
    }
}
