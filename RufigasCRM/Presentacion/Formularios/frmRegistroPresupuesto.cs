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
    public partial class frmRegistroPresupuesto : Form
    {
        public frmRegistroPresupuesto()
        {
            InitializeComponent();
        }
        private string vBoton = "A";
        private void cmdAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmRegistroPresupuestoAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmRegistroPresupuestoAnadir f = new frmRegistroPresupuestoAnadir(vBoton);
                    f.pasado += new frmRegistroPresupuestoAnadir.pasar(ejecutar);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Mensaje de Sistema",MessageBoxButtons.OK);
            }
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
        private void frmRegistroPresupuesto_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData();
            ejecutar(dgvPresupuesto.RowCount);
            dgvPresupuesto.Refresh();
        }

        private void cargarData()
        {
            List<presupuesto> listado = presupuestoNE.presupuestoListar(sesion.empresasesion.idempresa,sesion.puntoventasesion.idpuntoventa);
            dgvPresupuesto.DataSource = listado;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            vBoton = "V";
            cargarFormularioAnadir();
        }

        private void cargarFormularioAnadir()
        {
            if (dgvPresupuesto.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmRegistroPresupuestoAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmRegistroPresupuestoAnadir f = new frmRegistroPresupuestoAnadir(vBoton);
            f.pasado += new frmRegistroPresupuestoAnadir.pasar(ejecutar);

            f.tmpPresupuesto = new presupuesto();
            f.tmpPresupuesto.idpresupuesto = (int)dgvPresupuesto.CurrentRow.Cells["IDPRESUPUESTO"].Value;
            f.tmpPresupuesto.codigoserie = (string)(dgvPresupuesto.CurrentRow.Cells["CODIGOSERIE"].Value);
            f.tmpPresupuesto.numeropresupuesto = (string)(dgvPresupuesto.CurrentRow.Cells["NUMEROPRESUPUESTO"].Value);
            f.tmpPresupuesto.placa = (string)(dgvPresupuesto.CurrentRow.Cells["PLACA"].Value);
            f.tmpPresupuesto.idpersona = (int)(dgvPresupuesto.CurrentRow.Cells["IDPERSONA"].Value);
            f.tmpPresupuesto.fechapresupuesto = (string)(dgvPresupuesto.CurrentRow.Cells["FECHAPRESUPUESTO"].Value);
            f.tmpPresupuesto.fecharq = (string)(dgvPresupuesto.CurrentRow.Cells["FECHARQ"].Value);
            f.tmpPresupuesto.fechara = (string)(dgvPresupuesto.CurrentRow.Cells["FECHARA"].Value);
            f.tmpPresupuesto.idmarca = (int)(dgvPresupuesto.CurrentRow.Cells["IDMARCA"].Value);
            f.tmpPresupuesto.idmodelo = (int)(dgvPresupuesto.CurrentRow.Cells["IDMODELO"].Value);
            f.tmpPresupuesto.total = (decimal)(dgvPresupuesto.CurrentRow.Cells["TOTAL"].Value);
            f.tmpPresupuesto.observacion = (string)(dgvPresupuesto.CurrentRow.Cells["OBSERVACION"].Value);
            f.tmpPresupuesto.idsitupresupuesto = (string)dgvPresupuesto.CurrentRow.Cells["IDSITUPRESUPUESTO"].Value;
            f.tmpPresupuesto.estadopresupuesto = (bool)(dgvPresupuesto.CurrentRow.Cells["ESTADOPRESUPUESTO"].Value);
            f.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "M";
                if (basicas.validarAcceso(vBoton))
                {
                    cargarFormularioAnadir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                vBoton = "N";
                if (basicas.validarAcceso(vBoton))
                {
                    if ((string)dgvPresupuesto.CurrentRow.Cells["IDSITUPRESUPUESTO"].Value!="1")
                    {
                        throw new Exception("Estado de presupuesto no permite anular");
                        //MessageBox.Show("Estado de presupuesto no permite anular", "Mensaje de Sistema", MessageBoxButtons.OK);
                        //return;
                    }
                    int idpresupuesto = (int)dgvPresupuesto.CurrentRow.Cells["IDPRESUPUESTO"].Value;
                    if (MessageBox.Show("Desea anular el presupuesto N° "+ idpresupuesto+"?","MENSAJE DE CONFIRMACIÓN",MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                //Color.PaleGreen;
            }


            //if (dgvPresupuesto.Columns[e.ColumnIndex].Name == "IDSITUPRESUPUESTO")
            //{
            //    if ((string)(dgvPresupuesto.CurrentRow.Cells["IDSITUPRESUPUESTO"].Value) == "9")
            //    {
            //        dgvPresupuesto.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            //        //-e.CellStyle.ForeColor = Color.Pink;
            //        //dgvPresupuesto.Rows[e.Index].DefaultCellStyle.ForeColor
            //    }
            //}



            //        foreach (DataGridViewRow row in dgvPresupuesto.Rows)
            //{
            //    if ("9" == (string)row.Cells["IDSITUPRESUPUESTO"].Value)
            //    {
            //        dgvPresupuesto.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Red;
            //    }
            //}
        }
    }
}