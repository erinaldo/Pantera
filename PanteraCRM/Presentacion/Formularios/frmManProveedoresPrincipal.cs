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
    public partial class frmManProveedoresPrincipal : Form
    {

        private string vBoton = "A";
        public frmManProveedoresPrincipal()
        {
            InitializeComponent();
        }
        private void frmManProveedoresPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0,"");
        }
        public void cargarData(int registro, string parametro)
        {
            if (parametro == "")
            {
                List<proveedor> listado = proveedorNE.proveedorListar();
                dgvListadoProveedores.DataSource = listado;
            }
            else
            {
                List<proveedor> listado = proveedorNE.ProveedorListarParametro(parametro);
                dgvListadoProveedores.DataSource = listado;
            }
        }
        public void ejecutar(int dato)
        {
            cargarData(0,"");
            foreach (DataGridViewRow Row in dgvListadoProveedores.Rows)
            {
                int valor = (int)Row.Cells["IDPROVE"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListadoProveedores.CurrentCell = dgvListadoProveedores.Rows[puntero].Cells[1];
                    return;
                }
            }
        }

     

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManProveedoresAnadir);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmManProveedoresAnadir f = new frmManProveedoresAnadir(vBoton);
                    f.pasado += new frmManProveedoresAnadir.pasar(ejecutar);
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReportesM Re = new Reportes.FrmReportesM();
            CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;

            List<proveedor> LisProv = proveedorNE.proveedorListar();
            DataSet ds = new DataSet();
            //Empresa
            empresas emp = empresaNE.EmpresaBusquedaCodigo(1);
            Dataset.DtsReporte.TEmpresaDataTable dtE = new Dataset.DtsReporte.TEmpresaDataTable();
            ds.Tables.Add(dtE);
            DataRow filaE = dtE.NewRow();
            filaE[0] = emp.chrazonsocial;
            filaE[1] = emp.chruc;
            dtE.Rows.Add(filaE);
            Dataset.DtsReporte.TProovedoresDataTable dtP = new Dataset.DtsReporte.TProovedoresDataTable();
            ds.Tables.Add(dtP);
            DataRow fila;

            foreach (proveedor p in LisProv)
            {
                fila = dtP.NewRow();
                fila[0] = p.p_inidcodigoclie;
                fila[1] = p.razon;
                fila[2] = p.tipodocu;
                fila[3] = p.nrodocumento;
                fila[4] = p.telefono;
                dtP.Rows.Add(fila);
            }

            Rpt1 = new Reportes.CrystalReportProveedor();
            Rpt1.SetDataSource(ds);
            Re.Rpt = Rpt1;
            Re.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "V";
                if (basicas.validarAcceso(vBoton))
                {
                    if (dgvListadoProveedores.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManProveedoresAnadir);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmManProveedoresAnadir f = new frmManProveedoresAnadir(vBoton);
                    f.pasado += new frmManProveedoresAnadir.pasar(ejecutar);
                    f.ProveedorCodigo = (int)dgvListadoProveedores.CurrentRow.Cells["IDPROVE"].Value;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "M";
                if (basicas.validarAcceso(vBoton))
                {
                    if (dgvListadoProveedores.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManProveedoresAnadir);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmManProveedoresAnadir f = new frmManProveedoresAnadir(vBoton);
                    f.pasado += new frmManProveedoresAnadir.pasar(ejecutar);
                    f.ProveedorCodigo = (int)dgvListadoProveedores.CurrentRow.Cells["IDPROVE"].Value;
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

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0, parametro);

        }
    }
}
