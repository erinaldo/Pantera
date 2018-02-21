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
    public partial class frmManProveedoresAnadir : Form
    {
        public delegate void pasar(int varreg);
        public event pasar pasado;      
        
        public frmManProveedoresAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUbigeo_TextChanged(object sender, EventArgs e)
        {
            int codigo = 0;
            if (txtUbigeo.Text.Length > 0)
            {
                codigo = int.Parse(txtUbigeo.Text);
            }
            BuscarRegistro(codigo);
        }

        private void txtUbigeo_DoubleClick(object sender, EventArgs e)
        {
            frmBusquedaUbigeo f = new frmBusquedaUbigeo();
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmBusquedaUbigeo);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            f.pasadoUbigeo += new frmBusquedaUbigeo.pasarUbigeo(BuscarData);
            f.MdiParent = this.MdiParent;
            f.Show();            
        }
        
        public void BuscarData(int codigo)
        {
            txtUbigeo.Text = codigo.ToString();
        }
        public void BuscarRegistro(int codigo)
        {
            ubigeo registro = ubigeoNE.buscarPorCodigo(codigo);
            if (registro != null)
            {
                txtDeparta.Text = registro.desc_departamento;
                txtProvincia.Text = registro.desc_provincia;
                txtDistrito.Text = registro.desc_distrito;
            }else
            {
                txtDeparta.Text = "";
                txtProvincia.Text = "";
                txtDistrito.Text = "";
            }
            
        }

        private void txtUbigeo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void frmManProveedoresAnadir_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cboPais.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(10);
            cboPais.ValueMember = "idmaestrodetalle";
            cboPais.DisplayMember = "nombreitem";

            cboTipvia.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(9);
            cboTipvia.ValueMember = "idmaestrodetalle";
            cboTipvia.DisplayMember = "nombreitem";

            cboZona.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(11);
            cboZona.ValueMember = "idmaestrodetalle";
            cboZona.DisplayMember = "nombreitem";

            if (this.vBoton == "A")
            {
                
            }
            else
                if (this.vBoton == "M")
            {
                this.Text = "MODIFICAR PROVEEDOR";
              
            }
            else
                   if (this.vBoton == "V")
            {
                this.Text = "VER PROVEEDOR";
                

                btnGrabar.Enabled = false;
            }




        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int varIdArticulo;
            switch (this.vBoton)
            {
                case "A":
                    int codempresa = 0;
                    int codprove = 0;
                    empresas registrosEmpresa = new empresas();
                    registrosEmpresa.chrazonsocial = txtRazon.Text;
                    registrosEmpresa.chruc = TXTRUC.Text;
                    registrosEmpresa.chtelefono = txtTele1.Text;
                    registrosEmpresa.chdirecfiscal = txtdireccionfisc.Text;
                    registrosEmpresa.chobservacion = txtdireccionfisc.Text;
                    registrosEmpresa.estado = true;
                    registrosEmpresa.chnombrecomercial = txtNombre.Text;
                    registrosEmpresa.p_inidubigeo = int.Parse(txtUbigeo.Text);
                    codempresa = empresaNE.EmpresaIngresar(registrosEmpresa);
                    if (codempresa <= 0)
                    {
                        MessageBox.Show("Error en el ingreso E", "Mensaje de Sistema", MessageBoxButtons.OK);
                        return;
                        
                    }
                    proveedores registrosProveedores = new proveedores();
                    registrosProveedores.p_inactividad = 19;
                    registrosProveedores.p_incodzona = (int)cboZona.SelectedValue;
                    registrosProveedores.chnombrezona = txtZonaNom.Text;
                    registrosProveedores.chtelefono1 = txtTele1.Text;
                    registrosProveedores.chtelefono2 = txtTele2.Text;
                    registrosProveedores.p_incodpais = (int)cboPais.SelectedValue;
                    registrosProveedores.estado = true;
                    registrosProveedores.chcodigoproveedor = "001";
                    registrosProveedores.p_inidtipovia = (int)cboTipvia.SelectedValue;
                    registrosProveedores.chtipovia = txtVianombre.Text;
                    registrosProveedores.chnumero = txtNum.Text;
                    registrosProveedores.chinterior = txtInt.Text;
                    codprove = proveedorNE.ProveedorIngresar(registrosProveedores);
                    if (codprove <= 0)
                    {
                        MessageBox.Show("Error en el ingreso P", "Mensaje de Sistema", MessageBoxButtons.OK);
                        return;
                       
                    }
                    proveedorjuridico registrosProvJuri = new proveedorjuridico();
                    registrosProvJuri.p_inidempresa = codempresa;
                    registrosProvJuri.p_inidproveedor = codprove;
                    varIdArticulo = proveedorjuridicoNE.ProveedorJuridicoIngresar(registrosProvJuri);
                    if (varIdArticulo <= 0)
                    {
                        MessageBox.Show("Error en la Modificación T", "Mensaje de Sistema", MessageBoxButtons.OK);
                        return;
                        //MessageBox.Show("Registro con error por actualizado, validar");
                    }
                    else
                    {
                        //MessageBox.Show("Registro Modificado", "Mensaje de Sistema", MessageBoxButtons.OK);
                        pasado(varIdArticulo);
                    }

                    break;
                case "M":
                  
                    break;
                default:
                    break;
            }
            this.Dispose();
        }
    }
}
