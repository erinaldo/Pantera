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
    public partial class frmManClienteAnadir : Form
    {
        internal producto tmpProducto;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmManClienteAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;

       

      
      

        private void frmManClienteAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cboSexo.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(8);
            cboSexo.ValueMember = "idmaestrodetalle";
            cboSexo.DisplayMember = "nombreitem";

            cboTipoClienteE.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(18);
            cboTipoClienteE.ValueMember = "idmaestrodetalle";
            cboTipoClienteE.DisplayMember = "nombreitem";

            cboTipoClienteP.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(18);
            cboTipoClienteP.ValueMember = "idmaestrodetalle";
            cboTipoClienteP.DisplayMember = "nombreitem";

            cboTipovia.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(9);
            cboTipovia.ValueMember = "idmaestrodetalle";
            cboTipovia.DisplayMember = "nombreitem";
            cboTipozona.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(11);
            cboTipozona.ValueMember = "idmaestrodetalle";
            cboTipozona.DisplayMember = "nombreitem";

            cboPais.DataSource= maestrodetalleNE.buscarPorCodigoMaestro(10);
            cboPais.ValueMember = "idmaestrodetalle";
            cboPais.DisplayMember = "nombreitem";

            cboTipoDocu.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(20);
            cboTipoDocu.ValueMember = "idmaestrodetalle";
            cboTipoDocu.DisplayMember = "nombreitem";

            cbodocumentoE.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(21);
            cbodocumentoE.ValueMember = "idmaestrodetalle";
            cbodocumentoE.DisplayMember = "nombreitem";

            if (vBoton == "A")
            {

            }else
            {
                if (vBoton == "M")
                {

                }else
                {
                    if (vBoton == "V")
                    {

                    }
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (this.vBoton)
            {
                case "A":
                    if (ValidarCampos())
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ClienteRegistrar();
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
                   
                    break;
                default:
                    break;
            }
            this.Dispose();

        }
        private static bool ValidarCampos()
        {
            return true;
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void ClienteRegistrar()
        {

            int codigoempresa = 0;
            int codigopersona = 0;
            int codigocliente = 0;
            Mcliente ClienteRegistros = new Mcliente();
            ClienteRegistros.chdireccionenvio = txtDireccion.Text;
            ClienteRegistros.p_inidtipovia = int.Parse(cboTipovia.SelectedValue.ToString());
            ClienteRegistros.chnombrevia = txtNombreVia.Text;
            ClienteRegistros.chnumero = txtNumeroVia.Text;
            ClienteRegistros.chnumerointerior = txtInterior.Text;
            ClienteRegistros.p_inidtipozona = int.Parse(cboTipozona.SelectedValue.ToString());
            ClienteRegistros.chnombrezona = txtNombreZona.Text;
            ClienteRegistros.estado = true;
            ClienteRegistros.chtelefono2 = txtTelefono.Text;
            ClienteRegistros.chtelefono3 = txtTelefono.Text;
            ClienteRegistros.p_inidpais = int.Parse(cboPais.SelectedValue.ToString());
            if (tabControl.SelectedIndex == 1)
            {
                //empresa    
                ClienteRegistros.p_inidtipocliente = int.Parse(cboTipoClienteE.SelectedValue.ToString());
            }
            else
            {
                //persona
                ClienteRegistros.p_inidtipocliente = int.Parse(cboTipoClienteP.SelectedValue.ToString());
            }
            codigocliente = clienteNE.ClienteIngresar(ClienteRegistros);
            if (tabControl.SelectedIndex == 1)
            {
                //empresa    
                empresas EmpresaRegistros = new empresas();
                //EmpresaRegistros.p_inidempresa = 0;
                EmpresaRegistros.chrazonsocial = txtRazon.Text;
                EmpresaRegistros.chruc = txtRuc.Text;
                EmpresaRegistros.chtelefono = txtTelefono.Text;
                EmpresaRegistros.chdirecfiscal = txtDireccion.Text;
                EmpresaRegistros.chobservacion = "-";
                EmpresaRegistros.estado = true;
                EmpresaRegistros.chnombrecomercial = txtNombreComercial.Text;
                EmpresaRegistros.p_inidubigeo = int.Parse(txtUbigeo.Text);
                codigoempresa = empresaNE.EmpresaIngresar(EmpresaRegistros);
                Mclientejuridico JuridicoRegistros = new Mclientejuridico();
                //JuridicoRegistros.p_inidclientejuridico = 0;
                JuridicoRegistros.p_inidcliente = codigocliente;
                JuridicoRegistros.p_inidempresa = codigoempresa;
                clienteNE.ClienteJuridicoIngresar(JuridicoRegistros);
            }
            else
            {
                //persona
                persona PersonaRegistro = new persona();
                //PersonaRegistro.p_inidpersona = 0;
                PersonaRegistro.nrodocumento = txtNroDocumento.Text;
                PersonaRegistro.chapellidopaterno = txtApePat.Text;
                PersonaRegistro.chapellidomaterno = txtApeMat.Text;
                PersonaRegistro.chnombres = txtNombres.Text;
                PersonaRegistro.chfechanacimiento = "";
                PersonaRegistro.p_inidtiposexo = int.Parse(cboSexo.SelectedValue.ToString());
                PersonaRegistro.chtelefono = txtTelefono.Text;
                PersonaRegistro.chdireccion = txtDireccion.Text;
                PersonaRegistro.observacion = "-";
                PersonaRegistro.estado = true;
                PersonaRegistro.p_inidubigeo = int.Parse(txtUbigeo.Text);
                PersonaRegistro.p_inidtipodocumento = int.Parse(cboTipoDocu.SelectedValue.ToString());
                codigopersona = personaNE.PersonaIngresar(PersonaRegistro);
                Mclientenatural NaturalRegistros = new Mclientenatural();
                //NaturalRegistros.p_inidclientenatural = 0;
                NaturalRegistros.p_inidcliente = codigocliente;
                NaturalRegistros.p_inidpersona = codigopersona;
                clienteNE.ClienteNaturalIngresar(NaturalRegistros);
            }
            licencia LicenciaRegistros = new licencia();
            LicenciaRegistros.p_inidcliente = codigocliente;
            LicenciaRegistros.chlicencia = txtLicencia.Text;
            LicenciaRegistros.fechavencimiento = txtVenciLicencia.Text;
            LicenciaRegistros.estado = true;
            clienteNE.LicenciaIngresar(LicenciaRegistros);
            tarjetapropiedad Tarjetaregistros = new tarjetapropiedad();
            Tarjetaregistros.p_inidcliente = codigocliente;
            //Tarjetaregistros.chtarjeta = txtTarjeta.Text;
            //Tarjetaregistros.fechavencimiento = txtVenciTarjeta.Text;
            Tarjetaregistros.estado = true;
            clienteNE.TarjetaIngresar(Tarjetaregistros);

            pasado(codigocliente);
        }
        private void ClienteModificar()
        {

        }

        private void txtUbigeo_TextChanged(object sender, EventArgs e)
        {
            int parametro = 0;
            if (txtUbigeo.Text.Length > 0)
            {
                parametro = int.Parse(txtUbigeo.Text);
            }
                
            BuscarUbigeo(parametro);
        }
        private void BuscarUbigeo(int parametro)
        {
            ubigeo ubigeo = ubigeoNE.buscarPorCodigo(parametro);
            if (ubigeo != null)
            {
                txtdepartamento.Text = ubigeo.desc_departamento;
                txtdistrito.Text = ubigeo.desc_departamento;
                txtprovincia.Text = ubigeo.desc_provincia;
            }else
            {
                txtdepartamento.Text = "";
                txtdistrito.Text = "";
                txtprovincia.Text = "";
            }
        }

        private void txtUbigeo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManClienteTarjetaAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmManClienteTarjetaAnadir f = new frmManClienteTarjetaAnadir(vBoton);
            f.pasado += new frmManClienteTarjetaAnadir.pasar(ejecutar);
            f.MdiParent = this.MdiParent;
            f.Show();
        }
        private void ejecutar(int a)
        {

        }
    }
}
