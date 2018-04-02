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
                List<cliente> listado = clienteNE.clienteListar();
                //dgvListaClientes.DataSource = listado;
            }
            else
            {
                List<cliente> listado = clienteNE.ClienteListarParametro2(parametro);
                //dgvListaClientes.DataSource = listado;
            }


        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            //foreach (DataGridViewRow Row in dgvListaClientes.Rows)
            //{
            //    int valor = (int)Row.Cells["IDCLIENTE"].Value;
            //    if (valor == dato)
            //    {
            //        int puntero = (int)Row.Index;
            //        //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
            //        dgvListaClientes.CurrentCell = dgvListaClientes.Rows[puntero].Cells[1];
            //        return;
            //    }
            //}
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

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "V";
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
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "I";
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
