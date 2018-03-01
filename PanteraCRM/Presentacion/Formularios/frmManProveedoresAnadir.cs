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
        internal proveedores ProveedorG;
        internal empresas EmpresaG;
        internal int ProveedorCodigo;
        internal proveedorjuridico ProveedorJuridicoG;


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
                txtdepartamento.Text = registro.desc_departamento;
                txtProvincia.Text = registro.desc_provincia;
                txtDistrito.Text = registro.desc_distrito;
            }else
            {
                txtdepartamento.Text = "";
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

            cboTipovia.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(9);
            cboTipovia.ValueMember = "idmaestrodetalle";
            cboTipovia.DisplayMember = "nombreitem";

            cboTipozona.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(11);
            cboTipozona.ValueMember = "idmaestrodetalle";
            cboTipozona.DisplayMember = "nombreitem";

            if (this.vBoton == "A")
            {
                
            }
            else
                if (this.vBoton == "M")
            {
                this.Text = "MODIFICAR PROVEEDOR";
                CargarDatosProveedor();
            }
            else
                   if (this.vBoton == "V")
            {
                this.Text = "VER PROVEEDOR";
                CargarDatosProveedor();
                CambiarForma(txtRazon);
                CambiarForma(TXTRUC);
                CambiarForma(txtTelefono);
                CambiarForma(txtDireccion);
                CambiarForma(txtNombre);
                CambiarForma(txtUbigeo);
                cboTipozona.SelectedValue = ProveedorG.p_incodzona;
                CambiarForma(txtNombreZona);
                cboPais.SelectedValue = ProveedorG.p_incodpais;
                cboTipovia.SelectedValue = ProveedorG.p_inidtipovia;
                CambiarForma(txtNombreVia);
                CambiarForma(txtNumeroVia);
                CambiarForma(txtInterior);

                btnGrabar.Enabled = false;
            }




        }
        private void CargarDatosProveedor()
        {
            ProveedorG = proveedorNE.ProveedorBusquedaCodigo2(ProveedorCodigo);
            ProveedorJuridicoG = proveedorNE.ProveedorJuridicoBusqueda(ProveedorCodigo);
            EmpresaG = empresaNE.EmpresaBusquedaCodigo(ProveedorJuridicoG.p_inidempresa);
            
            txtRazon.Text = EmpresaG.chrazonsocial;
            TXTRUC.Text= EmpresaG.chruc;
            txtTelefono.Text = EmpresaG.chtelefono;
            txtDireccion.Text = EmpresaG.chdirecfiscal;
            txtNombre.Text = EmpresaG.chnombrecomercial;
            txtUbigeo.Text = EmpresaG.p_inidubigeo.ToString();
            cboTipozona.SelectedValue = ProveedorG.p_incodzona;
            txtNombreZona.Text = ProveedorG.chnombrezona;
            cboPais.SelectedValue = ProveedorG.p_incodpais;
            cboTipovia.SelectedValue = ProveedorG.p_inidtipovia;
            txtNombreVia.Text = ProveedorG.chtipovia;
            txtNumeroVia.Text = ProveedorG.chnumero;
            txtInterior.Text = ProveedorG.chinterior;
        }
        private void CambiarForma(TextBox texbox)
        {
            texbox.ReadOnly = true;
            texbox.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            texbox.ForeColor = Color.Blue;
            texbox.TabStop = false;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            switch (this.vBoton)
            {
                case "A":
                    if (ValidarCamposIndependientesModificar())
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro de grabar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ProveedorRegistrar();
                        }
                        else
                        {
                            return;
                        }

                    }
                    else
                    {
                        return;
                    }


                    break;
                case "M":
                    if (ValidarCamposIndependientesModificar())
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro de modificar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ProveedorModificar();
                        }
                        else
                        {
                            return;
                        }

                    }
                    else
                    {
                        return;
                    }
                    break;
                default:
                    break;
            }
            this.Dispose();
        }
        private void ProveedorRegistrar()
        {
            int codempresa = 0;
            int codprove = 0;
            empresas registrosEmpresa = new empresas();
            registrosEmpresa.chrazonsocial = txtRazon.Text;
            registrosEmpresa.chruc = TXTRUC.Text;
            registrosEmpresa.chtelefono = txtTelefono.Text;
            registrosEmpresa.chdirecfiscal = txtDireccion.Text;
            registrosEmpresa.chobservacion = txtDireccion.Text;
            registrosEmpresa.estado = true;
            registrosEmpresa.chnombrecomercial = txtNombre.Text;
            registrosEmpresa.p_inidubigeo = int.Parse(txtUbigeo.Text);
            codempresa = empresaNE.EmpresaIngresar(registrosEmpresa);            
            proveedores registrosProveedores = new proveedores();
            registrosProveedores.p_inactividad = 19;
            registrosProveedores.p_incodzona = (int)cboTipozona.SelectedValue;
            registrosProveedores.chnombrezona = txtNombreZona.Text;
            registrosProveedores.chtelefono1 = txtTelefono.Text;
            registrosProveedores.chtelefono2 = txtTelefono.Text;
            registrosProveedores.p_incodpais = (int)cboPais.SelectedValue;
            registrosProveedores.estado = true;
            registrosProveedores.p_inidtipovia = (int)cboTipovia.SelectedValue;
            registrosProveedores.chtipovia = txtNombreVia.Text;
            registrosProveedores.chnumero = txtNumeroVia.Text;
            registrosProveedores.chinterior = txtInterior.Text;
            codprove = proveedorNE.ProveedorIngresar(registrosProveedores);           
            proveedorjuridico registrosProvJuri = new proveedorjuridico();
            registrosProvJuri.p_inidempresa = codempresa;
            registrosProvJuri.p_inidproveedor = codprove;
            ProveedorCodigo = proveedorjuridicoNE.ProveedorJuridicoIngresar(registrosProvJuri);
            pasado(ProveedorCodigo);
            
        }
        private void ProveedorModificar()
        {
            empresas registrosEmpresa = new empresas();
            registrosEmpresa.p_inidempresa = EmpresaG.p_inidempresa;
            registrosEmpresa.chrazonsocial = txtRazon.Text;
            registrosEmpresa.chruc = TXTRUC.Text;
            registrosEmpresa.chtelefono = txtTelefono.Text;
            registrosEmpresa.chdirecfiscal = txtDireccion.Text;
            registrosEmpresa.chobservacion = txtDireccion.Text;
            registrosEmpresa.estado = true;
            registrosEmpresa.chnombrecomercial = txtNombre.Text;
            registrosEmpresa.p_inidubigeo = int.Parse(txtUbigeo.Text);
            empresaNE.EmpresaModificar(registrosEmpresa);
            proveedores registrosProveedores = new proveedores();
            registrosProveedores.p_inidproveedor = ProveedorG.p_inidproveedor;
            registrosProveedores.p_inactividad = 19;
            registrosProveedores.p_incodzona = (int)cboTipozona.SelectedValue;
            registrosProveedores.chnombrezona = txtNombreZona.Text;
            registrosProveedores.chtelefono1 = txtTelefono.Text;
            registrosProveedores.chtelefono2 = txtTelefono.Text;
            registrosProveedores.p_incodpais = (int)cboPais.SelectedValue;
            registrosProveedores.estado = true;
            registrosProveedores.p_inidtipovia = (int)cboTipovia.SelectedValue;
            registrosProveedores.chtipovia = txtNombreVia.Text;
            registrosProveedores.chnumero = txtNumeroVia.Text;
            registrosProveedores.chinterior = txtInterior.Text;
            ProveedorCodigo =proveedorNE.ProveedorModificar(registrosProveedores);
            pasado(ProveedorCodigo);
        }
        private bool ValidarCamposGenerales()
        {
            bool flat = false;
            if (txtDireccion.Text.Length > 0)
            {
                if (txtNombreVia.Text.Length > 0)
                {
                    if (txtInterior.Text.Length > 0)
                    {
                        if (txtNumeroVia.Text.Length > 0)
                        {
                            if (txtNombreZona.Text.Length > 0)
                            {
                                if (txtTelefono.Text.Length > 0)
                                {
                                    if (txtUbigeo.Text.Length > 0)
                                    {
                                        flat = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ubigeo Vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                        txtUbigeo.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Telefono vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                    txtTelefono.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nombre zona vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                txtNombreZona.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Número vía vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            txtNumeroVia.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Interior vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        txtInterior.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de vía vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    txtNombreVia.Focus();
                }
            }
            else
            {
                MessageBox.Show("Direccíon vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtDireccion.Focus();
            }
            return flat;
        }
        private bool ValidarCamposIndependientesModificar()
        {
            bool flat = false;
            if (txtNombre.Text.Length > 0)
            {
                if (txtRazon.Text.Length > 0)
                {
                    if (TXTRUC.Text.Length == 11)
                    {
                        if (ValidarCamposGenerales())
                        {
                            flat = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ruc Incompleto", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        TXTRUC.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Razón social vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    txtRazon.Focus();
                }

            }
            else
            {
                MessageBox.Show("Nombre Comercial vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtNombre.Focus();
            }
            //empresa    

            return flat;
        }
        private void txtUbigeo_TextChanged_1(object sender, EventArgs e)
        {
            int codigo = 0;
            if (txtUbigeo.Text.Length > 0)
            {
                codigo = int.Parse(txtUbigeo.Text);
            }
            BuscarRegistro(codigo);
        }

        private void TXTRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            if (TXTRUC.Text.Length >= 11)
            {

                if (TXTRUC.SelectionLength > 0)
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    e.Handled = true;
                    return;
                }

            }
        }

        private void txtUbigeo_DoubleClick_1(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmBusquedaUbigeo);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmBusquedaUbigeo f = new frmBusquedaUbigeo();
            f.pasadoUbigeo += new frmBusquedaUbigeo.pasarUbigeo(PoneUbigeo);         
            f.MdiParent = this.MdiParent;
            f.Show();
        }
        private void PoneUbigeo(int ubigeo)
        {
            txtUbigeo.Text = ubigeo.ToString();
        }
    }
}
