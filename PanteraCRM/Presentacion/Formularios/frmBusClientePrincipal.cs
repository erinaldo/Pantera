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
                cargarFormularioAnadir();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
        private void cargarFormularioAnadir()
        {
            if (dgvListaclientes.RowCount == 0)
            {
                MessageBox.Show("Ninun item Seleccionado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            tmpcliente = new clientebusqueda();
            tmpcliente.p_inidcodigoclie = (int)dgvListaclientes.CurrentRow.Cells["IDCLIENTE"].Value;
            tmpcliente.chcodigocliente = (string)dgvListaclientes.CurrentRow.Cells["CHCODIGO"].Value;
            tmpcliente.razon = (string)(dgvListaclientes.CurrentRow.Cells["CHDESCRIPCION"].Value);
            tmpcliente.tipodocu = (string)dgvListaclientes.CurrentRow.Cells["CHTIPOCODU"].Value;
            tmpcliente.nrodocumento = (string)(dgvListaclientes.CurrentRow.Cells["CHNRODOCU"].Value);
            tmpcliente.chdireccion = (string)(dgvListaclientes.CurrentRow.Cells["CHDIRECCION"].Value);
            tmpcliente.tipoclie = (string)(dgvListaclientes.CurrentRow.Cells["CHTIPOCLIENTE"].Value);
            tmpcliente.telefono = (string)(dgvListaclientes.CurrentRow.Cells["CHTELEFONO"].Value);

        }
    }
}
