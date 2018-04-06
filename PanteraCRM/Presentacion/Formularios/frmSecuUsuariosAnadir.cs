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
using Presentacion.Programas;
namespace Presentacion
{
    public partial class frmSecuUsuariosAnadir : Form
    {
        internal usuariomenu DatosUsuarioG;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmSecuUsuariosAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;

        private void frmSecuUsuariosAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cboTipDoc.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(20);
            cboTipDoc.ValueMember = "idmaestrodetalle";
            cboTipDoc.DisplayMember = "nombreitem";
            cboGenero.DataSource = maestrodetalleNE.buscarPorCodigoMaestro(8);
            cboGenero.ValueMember = "idmaestrodetalle";
            cboGenero.DisplayMember = "nombreitem";
            cboPuntoVenta.DataSource = puntoventaNE.PuntodeVentaListar();
            cboPuntoVenta.ValueMember = "idpuntoventa";
            cboPuntoVenta.DisplayMember = "nombrepuntaventa";

            switch (vBoton)
            {
                case "A":
                    {
                        cargarDataAgregar();
                    }
                    break;
                case "M":
                    {
                        cargarData();
                    }
                    break;
                case "V":
                    {

                    }
                    break;
            }
        }
        public void cargarDataAgregar()
        {
            List<modulos> ModulosLista = usuarioNE.ModulosListar();
            string[] cadena = new string[7];
            cadena[0] = "MODULO PRINCIPAL-> ";
            int count = 0;
           
             foreach (modulos registros in ModulosLista)
            {
                if (registros.chcodigomenu == 0)
                {
                    cadena[registros.p_inidmenu] = registros.chdescripcionmenu + "-> ";
                    dgvListaModulos.Rows.Add(registros.p_inidmenu, registros.chcodigomenu, cadena[registros.chcodigomenu] + registros.chdescripcionmenu, registros.estado);
                    dgvListaModulos.Rows[count].ReadOnly = true;
                }
                else
                {
                    dgvListaModulos.Rows.Add(registros.p_inidmenu, registros.chcodigomenu, cadena[registros.chcodigomenu] + registros.chdescripcionmenu, registros.estado);
                }
                count++;
            }
        }
        public void cargarData()
        {
            var privilegios = DatosUsuarioG.chprivilegios.ToCharArray();
            List<modulos> ModulosLista = usuarioNE.ModulosListar();
            string[] cadena = new string[7];
            cadena[0] = "MODULO PRINCIPAL-> ";
            int count = 0;
            bool estado = false;

            foreach (modulos registros in ModulosLista)
            {
                if (privilegios[registros.p_inidmenu-1] == '1')
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                if (registros.chcodigomenu == 0)
                {
                    cadena[registros.p_inidmenu] = registros.chdescripcionmenu + "-> ";
                    dgvListaModulos.Rows.Add(registros.p_inidmenu, privilegios[registros.p_inidmenu - 1], cadena[registros.chcodigomenu] + registros.chdescripcionmenu, estado);
                    dgvListaModulos.Rows[count].ReadOnly = true;
                }
                else
                {
                    dgvListaModulos.Rows.Add(registros.p_inidmenu, privilegios[registros.p_inidmenu - 1], cadena[registros.chcodigomenu] + registros.chdescripcionmenu, estado);
                }
                count++;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "G";
                if (basicas.validarAcceso(vBoton))
                {
                    if (ValidarCampos())
                    {
                        DialogResult result = MessageBox.Show("¿Está seguro de Registrar los datos?", "MENSAJE DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            GarbarUsuario();
                        }else
                        {
                            return;
                        }

                    }
                    else
                    {
                        return;
                    }
                    this.Dispose();
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
        private bool ValidarCampos()
        {
            bool flat = false;
            if (txtApePat.Text.Length > 0 )
            {
                if (txtApeMat.Text.Length > 0)
                {
                    if (txtNombres.Text.Length > 0)
                    {
                        if (txtNroDoc.Text.Length > 0)
                        {
                            if (txtTelefono.Text.Length > 0)
                            {
                                if (txtDireccion.Text.Length > 0)
                                {
                                    if (txtUbigeo.Text.Length > 0)
                                    {
                                        if (txtUsuario.Text.Length > 0)
                                        {
                                            if (txtClave1.Text.Length > 0 && txtClave2.Text.Length > 0 && txtClave1.Text.Length == txtClave2.Text.Length )
                                            {
                                                flat = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Claves no coinciden o estan vacías", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                                txtClave1.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Usuario vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                            txtUsuario.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ubigeo vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                        txtUbigeo.Focus();
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
                                MessageBox.Show("Telefono vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                                txtTelefono.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nro. Documento vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                            txtNroDoc.Focus();
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
                MessageBox.Show("Apellido paterno vacío", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                txtApePat.Focus();
            }
            return flat;
        }
        private void GarbarUsuario()
        {

            persona PersonaRegistro = new persona();
            //PersonaRegistro.p_inidpersona = 0;
            PersonaRegistro.nrodocumento = txtNroDoc.Text;
            PersonaRegistro.chapellidopaterno = txtApePat.Text;
            PersonaRegistro.chapellidomaterno = txtApePat.Text;
            PersonaRegistro.chnombres = txtNombres.Text;
            DateTime dt1 = DateTime.Parse(txtFechaNac.Text);
            PersonaRegistro.chfechanacimiento = dt1.ToString("dd/MM/yyyy");
            PersonaRegistro.p_inidtiposexo = (int)cboPuntoVenta.SelectedValue;
            PersonaRegistro.chtelefono = txtTelefono.Text;
            PersonaRegistro.chdireccion = txtDireccion.Text;
            PersonaRegistro.observacion = "";
            PersonaRegistro.estado = true;
            PersonaRegistro.p_inidubigeo = int.Parse(txtUbigeo.Text);
            PersonaRegistro.p_inidtipodocumento = (int)cboTipDoc.SelectedValue;
            int codigoPersona = personaNE.PersonaIngresar(PersonaRegistro);
            string privilegio = "";
            for (int i = 0; i < dgvListaModulos.RowCount; i++)
            {
                if ((bool)dgvListaModulos.Rows[i].Cells["CHVALOR"].Value == true)
                {
                    privilegio += "1";
                }
                else
                {
                    privilegio += "0";
                }
            }
            privilegio += ValidarCheck(cbkAgregar)+"" + ValidarCheck(cbkModificar) + "" + ValidarCheck(cbkGrabar) + "" + ValidarCheck(cbkEliminar) + "" + ValidarCheck(cbkImprimir) + "" + ValidarCheck(cbkExportar) + "" + ValidarCheck(cbkVer);
            usuariomenu usuarioregistros = new usuariomenu();
            //usuarioregistros.p_inidusuario = 0;
            usuarioregistros.p_inidpersona = codigoPersona;
            usuarioregistros.p_inidpuntoventa = (int)cboPuntoVenta.SelectedValue;
            usuarioregistros.chclave = txtClave1.Text;
            usuarioregistros.estado = true;
            usuarioregistros.p_inidperfil = 1;
            usuarioregistros.chusuario = txtUsuario.Text;
            usuarioregistros.chprivilegios = privilegio;
            int codigousuario = usuarioNE.UsuarioIngresar(usuarioregistros);
            //MessageBox.Show("Error de Acceso"+ codigousuario, "Mensaje de Sistema", MessageBoxButtons.OK);
            pasado(codigousuario);

        }
        private string ValidarCheck(CheckBox Check)
        {
            string RT = "";
            if (Check.Checked == true)
            {
                RT = "1";
            }
            else
            {
                RT = "0";
            }
            
            return RT;

        }
        private void txtUbigeo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmBusquedaUbigeo f = new frmBusquedaUbigeo();
            f.pasadoUbigeo += new frmBusquedaUbigeo.pasarUbigeo(PoneUbigeo);
            f.ShowDialog();
        }
        private void PoneUbigeo(int ubigeo)
        {
            txtUbigeo.Text = ubigeo.ToString();
        }

        private void txtUbigeo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && !(8 == Convert.ToInt32(e.KeyChar)))
            {
                e.Handled = true;

            }
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
                txtDepartamento.Text = ubigeo.desc_departamento;
                txtDistrito.Text = ubigeo.desc_distrito;
                txtProvincia.Text = ubigeo.desc_provincia;
            }
            else
            {
                txtDepartamento.Text = "";
                txtDistrito.Text = "";
                txtProvincia.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox CuadroTexto = (TextBox)sender;
            utilidades.LogitudDeCampo(ref CuadroTexto, e, 100);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox CuadroTexto = (TextBox)sender;
            utilidades.LogitudDeCampo(ref CuadroTexto, e, 100);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox CuadroTexto = (TextBox)sender;
            utilidades.LogitudDeCampo(ref CuadroTexto, e, 100);
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox CuadroTexto = (TextBox)sender;
            utilidades.solonumeros(ref CuadroTexto,e);
            utilidades.LogitudDeCampo(ref CuadroTexto, e, 8);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox CuadroTexto = (TextBox)sender;
            utilidades.solonumeros(ref CuadroTexto, e);
            utilidades.LogitudDeCampo(ref CuadroTexto, e, 9);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox CuadroTexto = (TextBox)sender;
            utilidades.LogitudDeCampo(ref CuadroTexto, e, 150);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox CuadroTexto = (TextBox)sender;
            utilidades.LogitudDeCampo(ref CuadroTexto, e, 20);
        }

        private void txtClave1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox CuadroTexto = (TextBox)sender;
            utilidades.LogitudDeCampo(ref CuadroTexto, e, 50);
        }

        private void txtClave2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox CuadroTexto = (TextBox)sender;
            utilidades.LogitudDeCampo(ref CuadroTexto, e, 50);
        }
    }
}
