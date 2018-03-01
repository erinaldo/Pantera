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
    public partial class frmBusClientePrincipal : Form
    {
        public clientebusqueda tmpcliente;
        public delegate void PasarClienteCodigo(string CodigoCliente);
        public event PasarClienteCodigo Pasado;

        public frmBusClientePrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametroBusqueda.Text;
            cargarData(0, parametro);
        }
        public void cargarData(int registro, string parametro)
        {
            List<clientebusqueda> listado = clienteNE.ClienteListarParametro(parametro);
            dgvListaclientes.DataSource = listado;
        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvListaclientes.Rows)
            {
                int valor = (int)Row.Cells["IDCLIENTE"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaclientes.CurrentCell = dgvListaclientes.Rows[puntero].Cells[1];
                    return;
                }
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
                Pasado((string)dgvListaclientes.CurrentRow.Cells["CHCODIGO"].Value);
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }


        private void frmBusClientePrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmManClienteAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmManClienteAnadir f = new frmManClienteAnadir(vBoton);
                    f.pasado += new frmManClienteAnadir.pasar(ejecutar);
                    f.MdiParent = this.MdiParent;
                    f.Show();
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
    }
}
