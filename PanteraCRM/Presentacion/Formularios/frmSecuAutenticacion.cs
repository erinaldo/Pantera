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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DataTable dtPuntoventa = new DataTable();
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            

           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string login = this.txtUsuario.Text;
            string clave = basicas.encriptarStringHD5(this.txtContrasena.Text);

            try
            {
                sessionglobal registroSG = acesoNE.buscarAcesoPorLoginClaveNE(login, clave);
                if (registroSG != null)
                {
                    if (registroSG.estado)
                    {
                        sesion.SessionGlobal = registroSG;
                        this.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario está desactivado");
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetTextBoxSelectAll((TextBox)sender); });
        }
        private void SetTextBoxSelectAll(TextBox txtbox)
        {
            txtbox.SelectionStart = 0;
            txtbox.SelectionLength = txtbox.Text.Length;
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetTextBoxSelectAll((TextBox)sender); });
        }

      
    }
}
