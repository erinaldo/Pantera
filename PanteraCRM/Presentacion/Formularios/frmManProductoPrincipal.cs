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
using Presentacion.Programas;
using siempreEncima_cs.elGuille.Util;
namespace Presentacion
{
    public partial class frmManProductoPrincipal : Form
    {
        private string vBoton = "A";
        public frmManProductoPrincipal()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManProductoAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmManProductoAnadir f = new frmManProductoAnadir(vBoton);
                    f.pasado += new frmManProductoAnadir.pasar(ejecutar);                  
                    f.ShowDialog();
                    //WinAPI.SiempreEncima(f.Handle.ToInt32());
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
        private void frmManProductoPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0,"");
        }
        public void cargarData(int registro,string parametro)
        {
            if (parametro == "")
            {
                List<producto> listado = productoNE.productoListar();
                dvgProducto.DataSource = listado;
            }else
            {
                List<producto> listado = productoNE.productoListarBusqueda(parametro);
                dvgProducto.DataSource = listado;
            }
            
        }
        public void ejecutar(int dato)
        {
            cargarData(0,"");
            foreach (DataGridViewRow Row in dvgProducto.Rows)
            {
                int valor = (int)Row.Cells["IDPRODUCTO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dvgProducto.CurrentCell = dvgProducto.Rows[puntero].Cells[1];
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
            if (dvgProducto.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManProductoAnadir);
            //if (frm != null)
            //{
            //    frm.BringToFront();
            //    return;
            //}
            frmManProductoAnadir f = new frmManProductoAnadir(vBoton);
            f.pasado += new frmManProductoAnadir.pasar(ejecutar);
            f.tmpProducto = new producto();
            f.tmpProducto.p_inidproducto = (int)dvgProducto.CurrentRow.Cells["IDPRODUCTO"].Value;
            f.tmpProducto.chdescripcionproducto= (string)dvgProducto.CurrentRow.Cells["CHDESCRIPCION"].Value;
            f.tmpProducto.p_inidcalibre = (int)dvgProducto.CurrentRow.Cells["IDCALIBRE"].Value;
            f.tmpProducto.p_inidfamiliaproducto = (int)(dvgProducto.CurrentRow.Cells["IDFAMILIA"].Value);
            f.tmpProducto.p_inidmarca = (int)(dvgProducto.CurrentRow.Cells["IDMARCA"].Value);
            f.tmpProducto.p_inidmodelo = (int)(dvgProducto.CurrentRow.Cells["IDMODELO"].Value);
            f.tmpProducto.p_inidunidadmedidaproducto = (int)(dvgProducto.CurrentRow.Cells["IDMEDIDA"].Value);
            f.tmpProducto.p_inidcalibre = (int)(dvgProducto.CurrentRow.Cells["IDCALIBRE"].Value);
            f.tmpProducto.p_inidsituacion = (int)(dvgProducto.CurrentRow.Cells["IDSITUACION"].Value);
            f.tmpProducto.p_inidtipoproducto = (int)(dvgProducto.CurrentRow.Cells["IDTIPO"].Value);
            f.tmpProducto.chcodigoproducto = (string)(dvgProducto.CurrentRow.Cells["CODPRODUCTO"].Value);
            f.tmpProducto.chfechacreacion = (string)(dvgProducto.CurrentRow.Cells["CHFECHA"].Value);
            f.tmpProducto.req_serie = (bool)(dvgProducto.CurrentRow.Cells["IDCHECK"].Value);
            //f.MdiParent = this.MdiParent;
            f.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            vBoton = "V";
            cargarFormularioAnadir();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0, parametro);
        }

        private void button1_Click(object sender, EventArgs e)
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

            Rpt1 = new Reportes.CrystalReportProductos();
            Rpt1.SetDataSource(ds);
            Re.Rpt = Rpt1;
            Re.ShowDialog();

        }
    }
}