using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace Presentacion
{
    public partial class frmProcValesIngresoPrincipal : Form
    {
        internal int movimiento = 14;
        public frmProcValesIngresoPrincipal()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "A";
                
                if (basicas.validarAcceso(vBoton))
                {
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcIngresoValesAnadir);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmProcIngresoValesAnadir f = new frmProcIngresoValesAnadir(vBoton);
                    f.pasado += new frmProcIngresoValesAnadir.pasar(ejecutar);
                    //f.MdiParent = this.MdiParent;
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }           
        }
        private void frmProcValesIngresoPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0, "");
        }
        
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvVales.Rows)
            {
                int valor = (int)Row.Cells["IDVALEC"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvVales.CurrentCell = dgvVales.Rows[puntero].Cells["IDCORRELATIVO"];
                    return;
                }
            }
        }
        public void cargarData(int registro, string parametro)
        {
            
            if (parametro == "")
            {
                List<valecabecera> listado = valeNE.valesListar(movimiento);
                dgvVales.DataSource = listado;
            }
            else
            {
                List<valecabecera> listado = valeNE.valesListarparmetro(movimiento,parametro);
                dgvVales.DataSource = listado;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcIngresoValesAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "M";

                if (basicas.validarAcceso(vBoton))
                {
                    if (dgvVales.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcIngresoValesAnadir);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmProcIngresoValesAnadir f = new frmProcIngresoValesAnadir(vBoton);                    
                    f.codigoMovimiento =(int)dgvVales.CurrentRow.Cells["IDVALEC"].Value;
                    //f.MdiParent = this.MdiParent;
                    f.pasado += new frmProcIngresoValesAnadir.pasar(ejecutar);
                    f.ShowDialog();
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
                string vBoton = "V";

                if (basicas.validarAcceso(vBoton))
                {
                    if (dgvVales.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcIngresoValesAnadir);
                    //if (frm != null)
                    //{
                    //    frm.BringToFront();
                    //    return;
                    //}
                    frmProcIngresoValesAnadir f = new frmProcIngresoValesAnadir(vBoton);
                    f.pasado += new frmProcIngresoValesAnadir.pasar(ejecutar);
                    f.codigoMovimiento = (int)dgvVales.CurrentRow.Cells["IDVALEC"].Value;
                   // f.MdiParent = this.MdiParent;
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }                       
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "I";

                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcIngresoValesAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }

                    Reportes.FrmReportesM Re = new Reportes.FrmReportesM();
                    CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;

                    //declarar listas
                    List<valecabecera> listCab = valeNE.valesListarparmetroCodigo(14, (int)dgvVales.CurrentRow.Cells["IDVALEC"].Value);

                    //declarar tablas y agregar al DataSet
                    DataSet ds = new DataSet();
                    //Empresa
                    empresas emp = empresaNE.EmpresaBusquedaCodigo(1);
                    Dataset.DtsReporte.TEmpresaDataTable dtE = new Dataset.DtsReporte.TEmpresaDataTable();
                    ds.Tables.Add(dtE);
                    DataRow filaE = dtE.NewRow();
                    filaE[0] = emp.chrazonsocial;
                    filaE[1] = emp.chruc;
                    dtE.Rows.Add(filaE);
                    Dataset.DtsReporte.TDetalleDataTable dt = new Dataset.DtsReporte.TDetalleDataTable();
                    Dataset.DtsReporte.TCabeceraDataTable dtc = new Dataset.DtsReporte.TCabeceraDataTable();
                    ds.Tables.Add(dt);
                    ds.Tables.Add(dtc);

                    DataRow filaC;
                    DataRow filaD;
                    foreach (valecabecera reg in listCab)
                    {
                        filaC = dtc.NewRow();
                        filaC[0] = reg.p_inidvalecebecera;
                        filaC[1] = reg.p_inidalamacen;
                        filaC[2] = reg.p_inidclase;
                        filaC[3] = reg.p_inidcorrevale;
                        filaC[4] = reg.chvalefecha;
                        filaC[5] = reg.p_inidtipomoneda;
                        filaC[6] = reg.p_inidproveedor;
                        filaC[7] = reg.chguiaremision;
                        filaC[8] = reg.chboletafactura;
                        filaC[9] = reg.p_inidtipomoviemiento;
                        filaC[10] = reg.chobservacion;
                        filaC[11] = reg.p_inidusuarioinsert;
                        filaC[12] = reg.p_inidusuariodelete;
                        filaC[13] = reg.estado;
                        filaC[14] = reg.p_inidtipomoviemiento;
                        dtc.Rows.Add(filaC);
                        List<valedetalle> listaDeta = movimientosNE.MovimientoProductoDetalleBusqueda(reg.p_inidvalecebecera);

                        foreach (valedetalle reg2 in listaDeta)
                        {
                            filaD = dt.NewRow();
                            filaD[0] = reg2.p_inidvaledetalle;
                            filaD[1] = reg2.p_inidvalecebecera;
                            filaD[2] = reg2.p_inidproducto;
                            filaD[3] = reg2.nucantidad;
                            filaD[4] = reg2.nucosto;
                            filaD[5] = reg2.nutotal;
                            filaD[6] = reg2.estado;
                            dt.Rows.Add(filaD);
                        }
                    }

                    Rpt1 = new Reportes.CrystalReportVales();
                    Rpt1.SetDataSource(ds);
                    Re.Rpt = Rpt1;
                    Re.ShowDialog();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }


        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "E";

                if (basicas.validarAcceso(vBoton))
                {
                    if (dgvVales.RowCount == 0)
                    {
                        MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        return;
                    }
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcIngresoValesAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //MessageBox.Show("Movimiento eliminado", "Mensaje de Sistema", MessageBoxButtons.OK);
                        AnularMovimiento((int)dgvVales.CurrentRow.Cells["IDVALEC"].Value);
                        cargarData(0,"");
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }            
        }
        private void AnularMovimiento(int codigo)
        {
            //modificacion de cabecera
            List<valedetalle> ListaMovimientoD = movimientosNE.MovimientoProductoDetalleBusqueda(codigo);
            foreach (valedetalle registrosMovimientoD in ListaMovimientoD)
            {
                serieNE.SeriesFalsear(registrosMovimientoD.p_inidvaledetalle,true);
                //MessageBox.Show("error Falseo"+ registrosMovimientoD.p_inidvaledetalle, "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                int cantidad = (-1) * registrosMovimientoD.nucantidad;
                almacenNE.SaldoAlmacenAdiconar(sesion.SessionGlobal.p_inidalmacen, registrosMovimientoD.p_inidproducto, cantidad);

            }
            movimientosNE.MovimientoProductoDetalleFalsear(codigo);
            movimientosNE.MovimientoProductoCabeceraFalsear(codigo);
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0, parametro);
        }
    }
}
