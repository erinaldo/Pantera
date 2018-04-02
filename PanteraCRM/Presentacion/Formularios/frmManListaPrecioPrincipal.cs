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
    public partial class frmManListaPrecioPrincipal : Form
    {
        private string vBoton = "A";
        public frmManListaPrecioPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManListaPrecioAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmManListaPrecioAnadir f = new frmManListaPrecioAnadir(vBoton);
                    f.pasado += new frmManListaPrecioAnadir.pasar(ejecutar);
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

        private void frmManListaPrecioPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0,"");
        }
        public void cargarData(int registro,string parametro)
        {
            if (parametro == "")
            {
                List<productobuscado> listado = productoNE.ListaPreciosLista();
                dgvListaPrecios.DataSource = listado;
            }else
            {
                List<productobuscado> listado = productoNE.ListaPreciosListaParametro(parametro);
                dgvListaPrecios.DataSource = listado;
            }
            
        }
        public void ejecutar(int dato)
        {
            cargarData(0,"");
            foreach (DataGridViewRow Row in dgvListaPrecios.Rows)
            {
                int valor = (int)Row.Cells["IDPRODUCTO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaPrecios.CurrentCell = dgvListaPrecios.Rows[puntero].Cells[1];
                    return;
                }
            }
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
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
        private void cargarFormularioAnadir()
        {
            if (dgvListaPrecios.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManListaPrecioAnadir);
            //if (frm != null)
            //{
            //    frm.BringToFront();
            //    return;
            //}
            frmManListaPrecioAnadir f = new frmManListaPrecioAnadir(vBoton);
            f.pasado += new frmManListaPrecioAnadir.pasar(ejecutar);
            f.tmpProducto = new productobuscado();
            f.tmpProducto.p_inidproducto = (int)dgvListaPrecios.CurrentRow.Cells["IDPRODUCTO"].Value;
            f.tmpProducto.chnombrecompuesto = (string)dgvListaPrecios.CurrentRow.Cells["CHDESCRIPCION"].Value;
            f.tmpProducto.nuprecio = (decimal)dgvListaPrecios.CurrentRow.Cells["CHPRECIO"].Value;
            f.tmpProducto.chcodigoproducto = (string)(dgvListaPrecios.CurrentRow.Cells["CHCODIGO"].Value);
            //f.MdiParent = this.MdiParent;
            f.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "V";
                if (basicas.validarAcceso(vBoton))
                {
                    cargarFormularioAnadir();
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


        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0, parametro);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (basicas.validarAcceso("V"))
            {
                Reportes.FrmReportesM Re = new Reportes.FrmReportesM();
                CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;

                List<productobuscado> LisPro = productoNE.ListaPreciosLista();
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

                Rpt1 = new Reportes.CrystalReportProductoPrecio();
                Rpt1.SetDataSource(ds);
                Re.Rpt = Rpt1;
                Re.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error de Acceso", "Mensaje de Sistema", MessageBoxButtons.OK);
            }           
        }
    }
}
