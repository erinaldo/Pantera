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
    public partial class frmManClientePrincipal : Form
    {
        public frmManClientePrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void frmManClientePrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0);
        }
        public void cargarData(int registro)
        {
            List<cliente> listado = clienteNE.clienteListar();
            dgvCliente.DataSource = listado;
        }
        public void ejecutar(int dato)
        {
            cargarData(0);
            foreach (DataGridViewRow Row in dgvCliente.Rows)
            {
                int valor = (int)Row.Cells["IDCLIENTE"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvCliente.CurrentCell = dgvCliente.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
