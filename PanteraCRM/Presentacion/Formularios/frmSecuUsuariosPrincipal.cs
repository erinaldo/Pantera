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
    public partial class frmSecuUsuariosPrincipal : Form
    {
        public frmSecuUsuariosPrincipal()
        {
            InitializeComponent();
        }
        string vBoton;
        private void frmSecuUsuariosPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0, "");
        }
        public void cargarData(int registro, string parametro)
        {
            if (parametro == "")
            {
                List<usuariomenu> listado = usuarioNE.UsuarioListar();
                CargarTabla(listado);
            }
            else
            {
                List<usuariomenu> listado = usuarioNE.UsuarioListarParametro(parametro);
                CargarTabla(listado);
                
            }


        }
        public void CargarTabla(List<usuariomenu> listado)
        {
            dgvListaUsuarios.Rows.Clear();
           
            foreach (usuariomenu registro in  listado)
            {
                persona personaRegistro = personaNE.PersonaBusquedaCodigo(registro.p_inidpersona);
                dgvListaUsuarios.Rows.Add(registro.p_inidusuario, personaRegistro.chapellidopaterno+" "+ personaRegistro.chapellidomaterno +", "+ personaRegistro.chnombres,registro.chusuario);                
            }
        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvListaUsuarios.Rows)
            {
                int valor = (int)Row.Cells["IDUSUARIO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaUsuarios.CurrentCell = dgvListaUsuarios.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {                  
                    frmSecuUsuariosAnadir f = new frmSecuUsuariosAnadir(vBoton);
                    f.pasado += new frmSecuUsuariosAnadir.pasar(ejecutar);                    
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
                    //frmSecuUsuariosAnadir f = new frmSecuUsuariosAnadir(vBoton);
                    //f.pasado += new frmSecuUsuariosAnadir.pasar(ejecutar);                    
                    //f.ShowDialog();
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
                    //frmSecuUsuariosAnadir f = new frmSecuUsuariosAnadir(vBoton);
                    //f.pasado += new frmSecuUsuariosAnadir.pasar(ejecutar);                    
                    //f.ShowDialog();
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
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "I";
                if (basicas.validarAcceso(vBoton))
                {
                    //frmSecuUsuariosAnadir f = new frmSecuUsuariosAnadir(vBoton);
                    //f.pasado += new frmSecuUsuariosAnadir.pasar(ejecutar);                    
                    //f.ShowDialog();
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0, parametro);
        }

       
    }
}
