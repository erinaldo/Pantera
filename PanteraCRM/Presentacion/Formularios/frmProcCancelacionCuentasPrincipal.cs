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
    public partial class frmProcCancelacionCuentasPrincipal : Form
    {
        public frmProcCancelacionCuentasPrincipal()
        {
            InitializeComponent();
        }

        private void frmProcCancelacionCuentasPrincipal_Load(object sender, EventArgs e)
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
                dgvListaClientes.DataSource = listado;
            }
            else
            {
                List<cliente> listado = clienteNE.ClienteListarParametro2(parametro);
                dgvListaClientes.DataSource = listado;
            }
        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvListaClientes.Rows)
            {
                int valor = (int)Row.Cells["IDCLIENTE"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaClientes.CurrentCell = dgvListaClientes.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvListaClientes.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            frmProcCancelacionCuentasDetalle f = new frmProcCancelacionCuentasDetalle();            
            f.p_inidCliente = (int)dgvListaClientes.CurrentRow.Cells["IDCLIENTE"].Value;
            f.RazonG = dgvListaClientes.CurrentRow.Cells["CHRAZON"].Value.ToString();
            f.NroDocG = dgvListaClientes.CurrentRow.Cells["NRODOCU"].Value.ToString();
            f.codigoG = dgvListaClientes.CurrentRow.Cells["CHCODIGO"].Value.ToString();
            f.pasado += new frmProcCancelacionCuentasDetalle.pasar(ejecutar);
            f.ShowDialog();
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0, parametro);
        }
    }
}
