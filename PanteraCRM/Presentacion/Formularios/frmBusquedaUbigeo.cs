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
    public partial class frmBusquedaUbigeo : Form
    {
        public delegate void pasarUbigeo(int codigo);
        public event pasarUbigeo pasadoUbigeo;
        public frmBusquedaUbigeo()
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
            List<ubigeo> listaUbigeo = ubigeoNE.BuscarPorParametro(parametro);
            dgvListaUbigeo.DataSource = listaUbigeo;
        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvListaUbigeo.Rows)
            {
                int valor = (int)Row.Cells["IDUBIGEO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaUbigeo.CurrentCell = dgvListaUbigeo.Rows[puntero].Cells[1];
                    return;
                }
            }
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
            if (dgvListaUbigeo.RowCount == 0)
            {
                MessageBox.Show("Ningun item Seleccionado", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            int codigo = (int)dgvListaUbigeo.CurrentRow.Cells["IDUBIGEO"].Value;
            pasadoUbigeo(codigo);
            this.Dispose();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmBusquedaUbigeo_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
        }
    }
}
