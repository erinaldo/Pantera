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
    public partial class frmManClientePrincipal : Form
    {
        string vBoton;
        public frmManClientePrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void frmManClientePrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0,"");
        }
        public void cargarData(int registro,string parametro)
        {
            if (parametro == "")
            {
                List<cliente> listado = clienteNE.clienteListar();
                dgvListaClientes.DataSource = listado;
            }
            else
            {
                List<cliente> listado = clienteNE.ClienteListarParametro2(parametro);
                dgvListaClientes.DataSource = listado;
            }
            
            
        }
        public void ejecutar(int dato)
        {
            cargarData(0,"");
            foreach (DataGridViewRow Row in dgvListaClientes.Rows)
            {
                int valor = (int)Row.Cells["IDCLIENTE"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaClientes.CurrentCell = dgvListaClientes.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                   
                    frmManClienteAnadir f = new frmManClienteAnadir(vBoton);
                    f.pasado += new frmManClienteAnadir.pasar(ejecutar);
                    
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
                    if (dgvListaClientes.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManClienteAnadir);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmManClienteAnadir f = new frmManClienteAnadir(vBoton);
                    f.codigoCliente = (int)dgvListaClientes.CurrentRow.Cells["IDCLIENTE"].Value;
                    f.pasado += new frmManClienteAnadir.pasar(ejecutar);
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "V";
                if (basicas.validarAcceso(vBoton))
                {
                    if (dgvListaClientes.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManClienteAnadir);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmManClienteAnadir f = new frmManClienteAnadir(vBoton);
                    f.codigoCliente = (int)dgvListaClientes.CurrentRow.Cells["IDCLIENTE"].Value;
                    f.pasado += new frmManClienteAnadir.pasar(ejecutar);
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
            string parametro =txtParametro.Text;
            cargarData(0,parametro);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            vBoton = "I";
            if (basicas.validarAcceso(vBoton))
            {
                Reportes.FrmReportesM Re = new Reportes.FrmReportesM();
                CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;

                List<cliente> LisCli = clienteNE.clienteListar();
                DataSet ds = new DataSet();

                //Empresa
                empresas emp = empresaNE.EmpresaBusquedaCodigo(1);
                Dataset.DtsReporte.TEmpresaDataTable dtE = new Dataset.DtsReporte.TEmpresaDataTable();
                ds.Tables.Add(dtE);
                DataRow filaE = dtE.NewRow();
                filaE[0] = emp.chrazonsocial;
                filaE[1] = emp.chruc;
                dtE.Rows.Add(filaE);
                Dataset.DtsReporte.TClienteDataTable dtC = new Dataset.DtsReporte.TClienteDataTable();
                ds.Tables.Add(dtC);
                DataRow fila;

                foreach (cliente c in LisCli)
                {
                    fila = dtC.NewRow();
                    fila[0] = c.p_inidcodigoclie;
                    fila[1] = c.razon;
                    fila[2] = c.tipodocu;
                    fila[3] = c.nrodocumento;
                    fila[4] = c.telefono;
                    dtC.Rows.Add(fila);
                }

                Rpt1 = new Reportes.CrystalReportClientes();
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
