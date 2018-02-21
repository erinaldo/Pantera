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
    public partial class frmPersonaAnadir : Form
    {
        internal persona tmpPersona;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmPersonaAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;

        public void cargarUbigeo(ubigeo ubigeo)
        {
            //mtbUbigeo.Text = ubigeo.cod_ubigeo;
            txtDepartamento.Text = ubigeo.desc_departamento;
            txtProvincia.Text = ubigeo.desc_provincia;
            txtDistrito.Text = ubigeo.desc_distrito;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int varIdPersona;
            switch (this.vBoton)
            {
                case "A":
                    tmpPersona = new persona();
                    tmpPersona.dni = txtDni.Text;
                    tmpPersona.ape_paterno = txtApe_paterno.Text;
                    tmpPersona.ape_materno= txtApe_materno.Text;
                    tmpPersona.nombres = txtNombres.Text;
                    tmpPersona.ubigeo = mtbUbigeo.Text;
                    tmpPersona.fecha_nac = txtFecha_nac.Text;
                    tmpPersona.sexo = txtSexo.Text;
                    tmpPersona.telefono = txtTelefono.Text;
                    tmpPersona.direccion = txtDireccion.Text;
                    tmpPersona.telefono = txtTelefono.Text;
                    varIdPersona = personaNE.personaInsertar(tmpPersona);
                    if (varIdPersona == 0)
                    {
                        MessageBox.Show("Registro errado, validar");
                    }
                    else
                    {
                        MessageBox.Show("DNI registrado", varIdPersona.ToString());
                        pasado(varIdPersona);
                    }
                    break;
                case "M":
                    tmpPersona.dni = txtDni.Text;
                    tmpPersona.ape_paterno = txtApe_paterno.Text;
                    tmpPersona.ape_materno = txtApe_materno.Text;
                    tmpPersona.nombres = txtNombres.Text;
                    tmpPersona.ubigeo = mtbUbigeo.Text;
                    tmpPersona.fecha_nac = txtFecha_nac.Text;
                    tmpPersona.sexo = txtSexo.Text;
                    tmpPersona.telefono = txtTelefono.Text;
                    tmpPersona.direccion = txtDireccion.Text;
                    varIdPersona = personaNE.personaActualizar(tmpPersona);
                    if (varIdPersona == 0)
                    {
                        MessageBox.Show("Registro errado, validar");
                    }
                    else
                    {
                        MessageBox.Show("DNI actualizado");
                        pasado(varIdPersona);
                    }
                    break;
                default:
                    break;
            }
            this.Dispose();
        }

        private void frmPersonaAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;

            if (this.vBoton =="A")
            {
                this.Text = "AÑADIR PERSONA";
                this.txtDni.Enabled = true;
            }
            else 
                if (this.vBoton == "M")
                {
                    this.Text = "MODIFICAR PERSONA";
                    txtDni.Text = tmpPersona.dni;
                    txtApe_paterno.Text = tmpPersona.ape_paterno;
                    txtApe_materno.Text = tmpPersona.ape_materno;
                    txtNombres.Text = tmpPersona.nombres;
                    mtbUbigeo.Text = tmpPersona.ubigeo;
                    txtFecha_nac.Text = tmpPersona.fecha_nac;
                    txtSexo.Text = tmpPersona.sexo;
                    txtTelefono.Text = tmpPersona.telefono;
                    txtDireccion.Text = tmpPersona.direccion;

                    string cod_ubigeo = mtbUbigeo.Text;
                    try
                    {
                        ubigeo registro = ubigeoNE.buscarPorCodigo(1);
                        if (registro != null)
                        {
                            txtDepartamento.Text = registro.desc_departamento;
                            txtProvincia.Text = registro.desc_provincia;
                            txtDistrito.Text = registro.desc_distrito;
                        }
                        else
                        {
                            MessageBox.Show("Ubigeo no encontrado, informar para su verificación", "Mensaje de confirmación", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    persona registro2 = reniecNE.buscaPorDNI(txtDni.Text);
                    if (registro2 != null)
                    {
                    txtDireccion.Enabled = true;
                    txtTelefono.Enabled = true;
                    mtbUbigeo.Enabled = true;
                    txtApe_paterno.Enabled = false;
                    txtApe_materno.Enabled = false;
                    txtNombres.Enabled = false;
                    txtFecha_nac.Enabled = false;
                    txtSexo.Enabled = false;
                }
                else
                {
                        mtbUbigeo.Enabled = true;
                        txtTelefono.Enabled = true;
                        txtApe_paterno.Enabled = true;
                        txtApe_materno.Enabled = true;
                        txtNombres.Enabled = true;
                        txtFecha_nac.Enabled = true;
                        txtSexo.Enabled = true;
                        txtDireccion.Enabled = true;
                        txtDni.Enabled = true;        
                }

            }
                else
                   if(this.vBoton == "V")
                    {
                        this.Text = "VER PERSONA";
                        txtDni.Text = tmpPersona.dni;
                        txtApe_paterno.Text = tmpPersona.ape_paterno;
                        txtApe_materno.Text = tmpPersona.ape_materno;
                        txtNombres.Text = tmpPersona.nombres;
                        mtbUbigeo.Text = tmpPersona.ubigeo;
                        txtFecha_nac.Text = tmpPersona.fecha_nac;
                        txtSexo.Text = tmpPersona.sexo;
                        txtTelefono.Text = tmpPersona.telefono;
                        txtDireccion.Text = tmpPersona.direccion;
                        string cod_ubigeo = mtbUbigeo.Text;
                        btnGrabar.Enabled = false;
                        mtbUbigeo.Enabled = false;
                        txtApe_paterno.Enabled = false;
                        txtApe_materno.Enabled = false;
                        txtNombres.Enabled = false;
                        txtFecha_nac.Enabled = false;
                        txtSexo.Enabled = false;
                        txtDireccion.Enabled = false;
                try
                {
                            ubigeo registro = ubigeoNE.buscarPorCodigo(1);
                            if (registro != null)
                            {
                                txtDepartamento.Text = registro.desc_departamento;
                                txtProvincia.Text = registro.desc_provincia;
                                txtDistrito.Text = registro.desc_distrito;
                            }
                            else
                            {
                                MessageBox.Show("Ubigeo no encontrado, informar para su verificación", "Mensaje de confirmación", MessageBoxButtons.OK);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (int.Parse(txtSexo.Text) < 1 || int.Parse(txtSexo.Text) > 2)
            //{
            //    MessageBox.Show("Solo se permiten 1 o 2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            string dni = txtDni.Text;
            try
            {
                if (dni == string.Empty || dni.Trim().Length == 0)
                {
                    txtDni.Focus();
                    throw new Exception("Ingrese un DNI ");
                }
                if (dni.Trim().Length != 8)
                {
                    txtDni.Focus();
                    throw new Exception("Ingrese un DNI de 8 dígitos");
                }
                persona registro = personaNE.buscaPorDNI(dni);
                if ((this.vBoton == "A" && registro != null) || (this.vBoton == "M" && dni != tmpPersona.dni))
                {
                    MessageBox.Show("DNI ingresado ya se encuentra registrado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                    txtDni.Focus();
                }
                else
                {
                    persona registro2 = reniecNE.buscaPorDNI(dni);
                    if (registro2 != null)
                    {
                        mtbUbigeo.Text = registro2.ubigeo;
                        txtApe_paterno.Text = registro2.ape_paterno;
                        txtApe_materno.Text = registro2.ape_materno;
                        txtNombres.Text = registro2.nombres;
                        txtFecha_nac.Text = registro2.fecha_nac;
                        txtSexo.Text = registro2.sexo;
                        txtDireccion.Enabled = false;
                        ubigeo registro3 = ubigeoNE.buscarPorCodigo(1);
                        //mtbUbigeo.Text = registro3.cod_ubigeo;
                        txtDepartamento.Text = registro3.desc_departamento;
                        txtProvincia.Text = registro3.desc_provincia;
                        txtDistrito.Text = registro3.desc_distrito;
                        mtbUbigeo.Enabled = true;
                        txtApe_paterno.Enabled = false;
                        txtApe_materno.Enabled = false;
                        txtNombres.Enabled = false;
                        txtFecha_nac.Enabled = false;
                        txtSexo.Enabled = false;
                        txtDireccion.Enabled = true;
                    }
                    else
                    {
                        if (this.vBoton == "A")
                        {
                            mtbUbigeo.Text = "";
                            txtApe_paterno.Text = "";
                            txtApe_materno.Text = "";
                            txtNombres.Text = "";
                            txtFecha_nac.Text = "";
                            txtSexo.Text = "";
                            txtTelefono.Text = "";
                            txtDepartamento.Text = "";
                            txtProvincia.Text = "";
                            txtDistrito.Text = "";
                        }
                        mtbUbigeo.Enabled = true;
                        txtApe_paterno.Enabled = true;
                        txtApe_materno.Enabled = true;
                        txtNombres.Enabled = true;
                        txtFecha_nac.Enabled = true;
                        txtSexo.Enabled = true;
                        txtDireccion.Enabled = true;
                        txtTelefono.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void mtbUbigeo_Validating(object sender, CancelEventArgs e)
        {
            string cod_ubigeo = mtbUbigeo.Text;
            try
            {
                ubigeo registro = ubigeoNE.buscarPorCodigo(1);
                if (registro != null)
                {
                    //mtbUbigeo.Text = registro.cod_ubigeo;
                    txtDepartamento.Text = registro.desc_departamento;
                    txtProvincia.Text = registro.desc_provincia;
                    txtDistrito.Text = registro.desc_distrito;
                }
                else
                {
                    if (MessageBox.Show("Código no encontrado, desea buscar por descripción?", "Mensaje de confirmación", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmUbigeoBuscar);
                        if (frm != null)
                        {
                            frm.BringToFront();
                            return;
                        }
                        frmUbigeoBuscar f = new frmUbigeoBuscar();
                        f.pasadoUbigeo += new frmUbigeoBuscar.pasarUbigeo(cargarUbigeo);
                        f.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void mtbUbigeo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}