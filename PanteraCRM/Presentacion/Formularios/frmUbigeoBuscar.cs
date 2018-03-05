using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmUbigeoBuscar : Form
    {
        public frmUbigeoBuscar()
        {
            InitializeComponent();
        }
        public delegate void pasarUbigeo(ubigeo ubigeo);

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            //string desc_distrito = txtDescripcion.Text.Trim();

            //List<ubigeo> listado = ubigeoNE.buscarPorDistrito(desc_distrito);
            //if (listado.Count == 0)
            //{
            //    MessageBox.Show("Mensaje de Sistema", "No se encontró conincidencias con el dato ingresado", MessageBoxButtons.OK);
            //}
            //else
            //{ 
            //    dgvCursor.DataSource = listado;
            //}
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUbigeoBuscar_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //ubigeo registro = new ubigeo();
            //registro.cod_ubigeo = (string)dgvCursor.CurrentRow.Cells[0].Value;
            //registro.desc_departamento = (string)dgvCursor.CurrentRow.Cells[1].Value;
            //registro.desc_provincia = (string)dgvCursor.CurrentRow.Cells[2].Value;
            //registro.desc_distrito = (string)dgvCursor.CurrentRow.Cells[3].Value;
            //pasadoUbigeo(registro);
            //this.Dispose();
        }
    }
}
