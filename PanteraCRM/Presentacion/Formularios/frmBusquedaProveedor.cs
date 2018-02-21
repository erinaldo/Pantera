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
    public partial class frmBusquedaProveedor : Form
    {
        public delegate void pasarproveedor(string ruc);
        public event pasarproveedor pasadoproveedor;
        public frmBusquedaProveedor()
        {
            InitializeComponent();
        }

        private void txtParametroBusqueda_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametroBusqueda.Text;
            cargarData(0,parametro);
        }
        public void cargarData(int registro, string parametro)
        {
            List<proveedor> ListaProveedor = proveedorNE.ProveedorBusquedaParametro(parametro);
            dgvListaProveedores.DataSource = ListaProveedor;
        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvListaProveedores.Rows)
            {
                int valor = (int)Row.Cells["IDPROVE"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaProveedores.CurrentCell = dgvListaProveedores.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
        private void frmBusquedaProveedor_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
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
            if (dgvListaProveedores.RowCount == 0)
            {
                MessageBox.Show("Ningun item Seleccionado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            string codigo = (string)dgvListaProveedores.CurrentRow.Cells["NRODOCU"].Value;
            pasadoproveedor(codigo);
            this.Dispose();

        }
    }
}
