using Entidades;
using Negocios;
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
    public partial class frmReportePresupuesto : Form
    {
        public frmReportePresupuesto()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            cargarData();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            basicas.exportaExcel(dgvPresupuesto);
        }

        private void frmReportePresupuesto_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            txtCodigoserie.Text = sesion.puntoventasesion.prefijopresupuesto;
            txtCodigoserie1.Text = sesion.puntoventasesion.prefijopresupuesto;
            txtCodigoserie.Enabled = sesion.usuariosesion.idperfil == 3;
            txtCodigoserie1.Enabled = sesion.usuariosesion.idperfil == 3;
        }


        public void ejecutar(int dato)
        {
            cargarData();
            foreach (DataGridViewRow Row in dgvPresupuesto.Rows)
            {
                int valor = (int)Row.Cells["IDPRESUPUESTO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    dgvPresupuesto.CurrentCell = dgvPresupuesto.Rows[puntero].Cells[3];
                    return;
                }
            }
        }

        private void cargarData()
        {
            List<presupuesto> listado = presupuestoNE.presupuestoListarFechas(sesion.empresasesion.idempresa, 
                dtpfechaini.Text, dtpfechafin.Text, txtCodigoserie.Text, txtCodigoserie1.Text);
            dgvPresupuesto.DataSource = listado;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPresupuesto.RowCount == 0)
                {
                    MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    return;
                }
                if (basicas.validarAcceso("N"))
                {
                    if ((string)dgvPresupuesto.CurrentRow.Cells["IDSITUPRESUPUESTO"].Value != "1")
                    {
                        throw new Exception("Estado de presupuesto no permite anular");
                        //MessageBox.Show("Estado de presupuesto no permite anular", "Mensaje de Sistema", MessageBoxButtons.OK);
                        //return;
                    }
                    int idpresupuesto = (int)dgvPresupuesto.CurrentRow.Cells["IDPRESUPUESTO"].Value;
                    string numeropresupuesto = Convert.ToString(dgvPresupuesto.CurrentRow.Cells["NUMEROPRESUPUESTO"].Value);
                    if (MessageBox.Show("Desea anular el presupuesto N° " + numeropresupuesto + "?", "MENSAJE DE CONFIRMACIÓN", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (presupuestoNE.presupuestoAnular(idpresupuesto) > 0)
                        {
                            MessageBox.Show("Presupuesto fue anulado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            ejecutar(idpresupuesto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }

        }

        private void dgvPresupuesto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((string)this.dgvPresupuesto.Rows[e.RowIndex].Cells["IDSITUPRESUPUESTO"].Value == "9")
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
