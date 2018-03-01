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
        internal int codigoCliente;
        internal Mcliente ClienteGeneral;
        internal Mclientejuridico ClienteJuridicoG;
        internal Mclientenatural ClienteNaturalG;
        internal licencia LicenciaG;
        internal empresas EmpresaG;
        internal persona PersonaG;
        internal List<tarjetapropiedad> ListaTarjetasdePropiedad;
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
                txtcantidadtarjetas.Text = "0";
            }else
            {
                if (vBoton == "M")
                {
                    this.Text = "MODIFICAR CLIENTE";
                    CargarRegistros();


                } else
                {
                    if (vBoton == "V")
                    {
                        this.Text = "VISUALIZAR CLIENTE";
                        CargarRegistros();
                        CambiarForma(txtDireccion);
                        CambiarForma(txtNombreVia);
                        CambiarForma(txtNumeroVia);
                        CambiarForma(txtInterior);
                        CambiarForma(txtNombreZona);
                        CambiarForma(txtTelefono);
                        CambiarForma(txtRazon);
                        CambiarForma(txtRuc);
                        CambiarForma(txtNombreComercial);

                        CambiarForma(txtNroDocumento);
                        CambiarForma(txtApePat);
                        CambiarForma(txtApeMat);
                        CambiarForma(txtNombres);
                        
                        CambiarForma(txtUbigeo);
                        CambiarForma(txtLicencia);
                        txtVenciLicencia.ReadOnly = true;
                        txtVenciLicencia.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
                        txtVenciLicencia.ForeColor = Color.Blue;
                        txtVenciLicencia.TabStop = false;
                        CambiarForma(txtcantidadtarjetas);
                        btnGrabar.Enabled = false;
                    }
                }
            }
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
                    if (ValidarCamposIndependientes())
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
                    if (ValidarCamposIndependientesModificar())
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ClienteModificar();
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
        private void CargarRegistros()
        {
            ClienteGeneral = clienteNE.ClienteBusquedaCodigo(codigoCliente);

            LicenciaG = clienteNE.LicenciaBusquedaCodigo(codigoCliente);
            ListaTarjetasdePropiedad = clienteNE.TarjetaPropiedadBusquedaCodigo(codigoCliente);

            txtDireccion.Text = ClienteGeneral.chdireccionenvio;
            cboTipovia.SelectedValue = ClienteGeneral.p_inidtipovia;
            txtNombreVia.Text = ClienteGeneral.chnombrevia;
            txtNumeroVia.Text = ClienteGeneral.chnumero;
            txtInterior.Text = ClienteGeneral.chnumerointerior;
            cboTipozona.SelectedValue = ClienteGeneral.p_inidtipozona;
            txtNombreZona.Text = ClienteGeneral.chnombrezona;
            txtTelefono.Text = ClienteGeneral.chtelefono2;
            cboPais.SelectedValue = ClienteGeneral.p_inidpais;
            //MessageBox.Show(":"+ ClienteGeneral.p_inidjurinat, "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            if (ClienteGeneral.p_inidjurinat == 1)
            {

                //empresa    CambiarForma(txtRazon);
                CambiarForma(txtRuc);
                CambiarForma(txtNombreComercial);
                
                //tbPersona.
                tabControl.SelectedIndex = 1;
                cboTipoClienteP.SelectedValue = ClienteGeneral.p_inidtipocliente;

                ClienteJuridicoG = clienteNE.ClienteJuridicoBusquedaCodigo(codigoCliente);
                EmpresaG = empresaNE.EmpresaBusquedaCodigo(ClienteJuridicoG.p_inidempresa);
                txtRazon.Text = EmpresaG.chrazonsocial;
                txtRuc.Text = EmpresaG.chruc;
                txtTelefono.Text = EmpresaG.chtelefono;
                txtDireccion.Text = EmpresaG.chdirecfiscal;
                txtNombreComercial.Text = EmpresaG.chnombrecomercial;
                txtUbigeo.Text = EmpresaG.p_inidubigeo.ToString();
            }
            else
            {
                CambiarForma(txtRazon);
                CambiarForma(txtRuc);
                CambiarForma(txtNombreComercial);
                
                //persona
                tabControl.SelectedIndex = 0;

                ClienteNaturalG = clienteNE.ClienteNaturalBusquedaCodigo(codigoCliente);
                PersonaG = personaNE.PersonaBusquedaCodigo(ClienteNaturalG.p_inidpersona);
                cboTipoClienteP.SelectedValue = ClienteGeneral.p_inidtipocliente;
                txtNroDocumento.Text = PersonaG.nrodocumento;
                txtApePat.Text = PersonaG.chapellidopaterno;
                txtApeMat.Text = PersonaG.chapellidomaterno;
                txtNombres.Text = PersonaG.chnombres;

                cboSexo.SelectedValue = PersonaG.p_inidtiposexo;
                txtTelefono.Text = PersonaG.chtelefono;
                txtDireccion.Text = PersonaG.chdireccion;


                txtUbigeo.Text = PersonaG.p_inidubigeo.ToString();
                cboTipoDocu.SelectedValue = PersonaG.p_inidtipodocumento;
            }

            txtLicencia.Text = LicenciaG.chlicencia;
            txtVenciLicencia.Text = LicenciaG.fechavencimiento;
            txtcantidadtarjetas.Text = ListaTarjetasdePropiedad.Count.ToString();
        }
        private bool ValidarCamposIndependientes()
        {
            bool flat = false;
            if (tabControl.SelectedIndex == 1)
            {
                //empresa    
                if (txtNombreComercial.Text.Length > 0)
                {
                    if (txtRazon.Text.Length > 0)
                    {
                        if (txtRuc.Text.Length == 11)
                        {
                            if (ValidarCamposGenerales())
                            {
                                flat = true;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ruc Incompleto", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            txtNombres.Focus();
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
                    txtNombreComercial.Focus();
                }

            }
            else
            {
                //persona
                if (txtApePat.Text.Length > 0)
                {
                    if (txtApeMat.Text.Length > 0)
                    {
                        if (txtNombres.Text.Length > 0)
                        {
                            if (validarNrodocumento())
                            {
                                if (ValidarCamposGenerales())
                                {
                                    flat = true;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Número de documento incompleto", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                txtNroDocumento.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nombres vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            txtNombres.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Apellido materno vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        txtApeMat.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Apellido Paterno vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    txtApePat.Focus();
                }
            }


            return flat;
        }
        private  bool ValidarCamposIndependientesModificar()
        {
            bool flat = false;
            if (ClienteGeneral.p_inidjurinat == 1)
            {
                //empresa    
                if (txtNombreComercial.Text.Length > 0)
                {
                    if (txtRazon.Text.Length > 0)
                    {
                        if (txtRuc.Text.Length == 11)
                        {
                            if (ValidarCamposGenerales())
                            {
                                flat = true;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ruc Incompleto", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            txtNombres.Focus();
                        }
                    } else
                    {
                        MessageBox.Show("Razón social vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        txtRazon.Focus();
                    }

                } else
                {
                    MessageBox.Show("Nombre Comercial vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    txtNombreComercial.Focus();
                }
                
            }
            else
            {
                //persona
                if (txtApePat.Text.Length > 0)
                {
                    if (txtApeMat.Text.Length > 0)
                    {
                        if (txtNombres.Text.Length > 0)
                        {
                            if (validarNrodocumento())
                            {
                                if (ValidarCamposGenerales())
                                {
                                    flat = true;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Número de documento incompleto", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                txtNroDocumento.Focus();
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Nombres vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            txtNombres.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Apellido materno vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                        txtApeMat.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Apellido Paterno vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    txtApePat.Focus();
                }
            }
            

            return flat;
        }
        private bool ValidarCamposGenerales()
        {
            bool flat = false;
            if (txtLicencia.Text.Length > 0)
            {
                if (txtVenciLicencia.Text.Length > 0)
                {
                    if (int.Parse(txtcantidadtarjetas.Text) > 0)
                    {
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
                    }
                    else
                    {
                        MessageBox.Show("Añada almenos una Tarjeta de propiedad", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Fecha de vencimiento de licencia vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    txtVenciLicencia.Focus();
                }
            }
            else
            {
                MessageBox.Show("Licencia vacía", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtLicencia.Focus();
            }
            return flat;
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
                ClienteRegistros.p_inidjurinat = 1;
                ClienteRegistros.p_inidtipocliente = int.Parse(cboTipoClienteE.SelectedValue.ToString());
            }
            else
            {
                //persona
                ClienteRegistros.p_inidjurinat = 0;
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
            foreach (tarjetapropiedad Registros in ListaTarjetasdePropiedad)
            {
                Registros.p_inidcliente = codigocliente;
                Registros.estado = true;
                clienteNE.TarjetaIngresar(Registros);
            }

            pasado(codigocliente);
        }
        private void ClienteModificar()
        {

            int codigoempresa = 0;
            int codigopersona = 0;
            int codigocliente = 0;
            Mcliente ClienteRegistros = new Mcliente();
            ClienteRegistros.p_inidcliente = codigoCliente;
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
            if (ClienteGeneral.p_inidjurinat == 1)
            {
                //empresa    
                ClienteRegistros.p_inidtipocliente = int.Parse(cboTipoClienteE.SelectedValue.ToString());
            }
            else
            {
                //persona
                ClienteRegistros.p_inidtipocliente = int.Parse(cboTipoClienteP.SelectedValue.ToString());
            }
            //modificar cliente
            codigocliente = clienteNE.ClienteModificar(ClienteRegistros);

            if (ClienteGeneral.p_inidjurinat == 1)
            {
                //empresa    
                empresas EmpresaRegistros = new empresas();
                EmpresaRegistros.p_inidempresa = EmpresaG.p_inidempresa ;
                EmpresaRegistros.chrazonsocial = txtRazon.Text;
                EmpresaRegistros.chruc = txtRuc.Text;
                EmpresaRegistros.chtelefono = txtTelefono.Text;
                EmpresaRegistros.chdirecfiscal = txtDireccion.Text;
                EmpresaRegistros.chobservacion = "-";
                EmpresaRegistros.estado = true;
                EmpresaRegistros.chnombrecomercial = txtNombreComercial.Text;
                EmpresaRegistros.p_inidubigeo = int.Parse(txtUbigeo.Text);
                //modificarempresa
                codigoempresa = empresaNE.EmpresaModificar(EmpresaRegistros);
            }
            else
            {
                //persona
                persona PersonaRegistro = new persona();
                PersonaRegistro.p_inidpersona = PersonaG.p_inidpersona;
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
                //modificar emprsa
                codigopersona = personaNE.PersonaModificar(PersonaRegistro);
            }
            licencia LicenciaRegistros = new licencia();
            LicenciaRegistros.p_inidlicencia = LicenciaG.p_inidlicencia;
            LicenciaRegistros.p_inidcliente = codigocliente;
            LicenciaRegistros.chlicencia = txtLicencia.Text;
            LicenciaRegistros.fechavencimiento = txtVenciLicencia.Text;
            LicenciaRegistros.estado = true;
            //modificar licencia
            clienteNE.LicenciaModificar(LicenciaRegistros);
            //MessageBox.Show("E: "+con, "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            // falsear tarjeta
            List<tarjetapropiedad> Listas = clienteNE.TarjetaPropiedadBusquedaCodigo(codigoCliente); 
            foreach (tarjetapropiedad Registros in Listas)
            {                
                clienteNE.TarjetaFalsear(Registros.p_inidtarjeta);
            }
            // ingresar tarjeta
            foreach (tarjetapropiedad Registros in ListaTarjetasdePropiedad)
            {
                Registros.p_inidcliente = codigocliente;
                Registros.estado = true;
                clienteNE.TarjetaIngresar(Registros);
            }

            pasado(codigocliente);

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
                txtdistrito.Text = ubigeo.desc_distrito;
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
            f.pasado += new frmManClienteTarjetaAnadir.PasarListaTarjetas(ejecutar);
            f.pasadocantidad += new frmManClienteTarjetaAnadir.pasarcantidad(ponerCantidad);
            
            if (int.Parse(txtcantidadtarjetas.Text) > 0)
            {               
                f.ListaTarjetadeProiedadG = ListaTarjetasdePropiedad;             
            }
            f.MdiParent = this.MdiParent;
            f.Show();

        }
        private void ejecutar(List<tarjetapropiedad> ListaRegistros)
        {
            ListaTarjetasdePropiedad = ListaRegistros;
        }
        private void ponerCantidad(int cantidad)
        {
            txtcantidadtarjetas.Text = cantidad.ToString();
        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
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
            if (cboTipoDocu.Text == "DNI")
            {
                if (txtNroDocumento.Text.Length >= 8)
                {                   
                        if (txtNroDocumento.SelectionLength > 0)
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
            else
            {
                if (cboTipoDocu.Text == "CARNE EXTRANJERIA")
                {
                    if (txtNroDocumento.Text.Length >= 12)
                    {
                        if (txtNroDocumento.SelectionLength > 0)
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
                else
                {
                    if (cboTipoDocu.Text == "PASAPORTE")
                    {
                        if (txtNroDocumento.Text.Length >= 12)
                        {
                            if (txtNroDocumento.SelectionLength > 0)
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
                    else
                    {
                        if (txtNroDocumento.Text.Length >= 15)
                        {
                            if (txtNroDocumento.SelectionLength > 0)
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
                }
            }            
        }
        private bool validarNrodocumento()
        {
            bool flat = false;
            if (cboTipoDocu.Text == "DNI")
            {
                if (txtNroDocumento.Text.Length == 8)
                {
                    flat = true;
                }
            }
            else
            {
                if (cboTipoDocu.Text == "CARNE EXTRANJERIA")
                {
                    if (txtNroDocumento.Text.Length == 12)
                    {
                        flat = true;
                    }
                }
                else
                {
                    if (cboTipoDocu.Text == "PASAPORTE")
                    {
                        if (txtNroDocumento.Text.Length == 12)
                        {
                            flat = true;
                        }
                    }
                    else
                    {
                        if (txtNroDocumento.Text.Length == 15)
                        {
                            flat = true;
                        }
                    }
                }
            }
            return flat;
        }
        private void txtNroDocumento_Enter(object sender, EventArgs e)
        {
            txtNroDocumento.SelectAll();
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txtRuc.Text.Length >=11)
            {
                
                    if (txtRuc.SelectionLength > 0)
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

        private void txtUbigeo_DoubleClick(object sender, EventArgs e)
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
