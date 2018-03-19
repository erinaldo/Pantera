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
    public partial class frmProcCancelacionCuentasDetalle : Form
    {
        public frmProcCancelacionCuentasDetalle()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmProcCancelacionCuentasDetalle_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            dgvDocumentosPendientes.Rows.Add("FC", "0000000011", "", "02022018", "S/.", "123.80");
            dgvDocumentosPendientes.Rows.Add("FC", "0000000012", "", "02022018", "S/.", "123.80");
            dgvDocumentosPendientes.Rows.Add("FC", "0000000013", "", "02022018", "S/.", "123.80");
            TotalesDgvPediente();
            TotalesDgvSeleccion();
        }
        
        private void dgvDocumentosPendientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvDocumentosSeleccionados.Rows.Add(
                dgvDocumentosPendientes.CurrentRow.Cells["CHTIPO"].Value, 
                dgvDocumentosPendientes.CurrentRow.Cells["CHDOC"].Value,
                dgvDocumentosPendientes.CurrentRow.Cells["CHREN"].Value,
                dgvDocumentosPendientes.CurrentRow.Cells["CHFECHA"].Value,
                dgvDocumentosPendientes.CurrentRow.Cells["CHMONE"].Value,
                dgvDocumentosPendientes.CurrentRow.Cells["NUMONTO"].Value);
            dgvDocumentosPendientes.Rows.RemoveAt(e.RowIndex);
            TotalesDgvPediente();
            TotalesDgvSeleccion();
        }

        private void dgvDocumentosSeleccionados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        /*INICIO :: FUNCIONES BASES*/
        private void TotalesDgvPediente()
        {
            if (dgvDocumentosPendientes.RowCount > 0)
            {
                decimal total1 = 0;
                for (int i = 0; i < dgvDocumentosPendientes.RowCount; i++)
                {
                    total1 += decimal.Parse(dgvDocumentosPendientes.Rows[i].Cells["NUMONTO"].Value.ToString());
                }
                txtTotalPendiente.Text = total1.ToString("N2");
            }
            else
            {
                txtTotalPendiente.Text = "0.00";
            }

        }
        private void TotalesDgvSeleccion()
        {
            if (dgvDocumentosSeleccionados.RowCount > 0)
            {
                decimal total1 = 0;
                for (int i = 0; i < dgvDocumentosSeleccionados.RowCount; i++)
                {
                    total1 += decimal.Parse(dgvDocumentosSeleccionados.Rows[i].Cells["CHMONTOS"].Value.ToString());
                }
                txttotalSeleccion.Text = total1.ToString("N2");
            }
            else
            {
                txttotalSeleccion.Text = "0.00";
            }
        }
        /*FIN :: FUNCIONES BASES*/
    }
}
