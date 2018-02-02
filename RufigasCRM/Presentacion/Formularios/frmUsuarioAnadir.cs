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
    public partial class frmUsuarioAnadir : Form
    {
        internal usuario tmpUsuario;
        public delegate void pasar(int varreg);
        public event pasar pasado;
        public frmUsuarioAnadir(string vBoton)
        {
            InitializeComponent();
            this.vBoton = vBoton;
        }
        string vBoton;
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int varIdUsuario;
            switch (this.vBoton)
            {
                case "A":
                    //frmUsuario.cargarData(1);
                    tmpUsuario = new usuario();
                    tmpUsuario.nombre = txtNombre.Text;
                    tmpUsuario.login = txtLogin.Text;
                    tmpUsuario.clave = txtClave.Text;
                    tmpUsuario.idperfil = (int) cboPerfil.SelectedValue;
                    tmpUsuario.estadousuario = chkEstado.Checked;
                    varIdUsuario = usuarioNE.usuarioInsertar(tmpUsuario);
                    if (varIdUsuario <= 0)
                    {
                        MessageBox.Show("Registro errado, validar");
                    }
                    else
                    {
//                        MessageBox.Show("Código generado", varIdUsuario.ToString());
                        pasado(varIdUsuario);
                    }
                    break;
                case "M":
                    tmpUsuario.nombre = txtNombre.Text;
                    tmpUsuario.login = txtLogin.Text;
                    tmpUsuario.clave = txtClave.Text;
                    tmpUsuario.idperfil = (int)cboPerfil.SelectedValue;
                    tmpUsuario.estadousuario = chkEstado.Checked;
                    varIdUsuario = usuarioNE.usuarioActualizar(tmpUsuario);
                    if (varIdUsuario <= 0)
                    {
                        MessageBox.Show("Registro errado, validar");
                    }
                    else
                    {
  //                      MessageBox.Show("Registro actualizado");
                        if(varIdUsuario==sesion.usuariosesion.idusuario)
                        {
                            sesion.usuariosesion.nombre = txtNombre.Text;
                            sesion.usuariosesion.login = txtLogin.Text;
                            sesion.usuariosesion.idperfil = (int)cboPerfil.SelectedValue;
                        }
                        pasado(varIdUsuario);
                    }
                    break;
                default:
                    break;
            }
            this.Dispose();
        }

        private void frmUsuarioAnadir_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;

            cboPerfil.DataSource = perfilNE.perfilListar();
            cboPerfil.ValueMember = "idperfil";
            cboPerfil.DisplayMember = "descripcion";

            if (this.vBoton =="A")
            {
                this.Text = "AÑADIR USUARIO";
            }
            else 
                if (this.vBoton == "M")
                {
                    this.Text = "MODIFICAR USUARIO";
                    txtNombre.Text = tmpUsuario.nombre;
                    txtLogin.Text = tmpUsuario.login;
                    txtClave.Text = tmpUsuario.clave;
                    cboPerfil.SelectedValue = tmpUsuario.idperfil;
                    chkEstado.Checked = tmpUsuario.estadousuario;
                }
                else
                   if(this.vBoton == "V")
                    {
                        this.Text = "VER USUARIO";
                        txtNombre.Text = tmpUsuario.nombre;
                        txtLogin.Text = tmpUsuario.login;
                        txtClave.Text = tmpUsuario.clave;
                        cboPerfil.SelectedValue = tmpUsuario.idperfil;
                        chkEstado.Checked = tmpUsuario.estadousuario;
                        btnGrabar.Enabled = false;
                    }
                }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}