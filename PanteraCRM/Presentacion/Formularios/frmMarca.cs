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
    public partial class frmMarca : Form
    {
        private string vBoton = "A";
        public frmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData();
        }
        public void cargarData()
        {
            List<marca> listado = marcaNE.marcaListar();
            dgvMarca.DataSource = listado;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMarcaAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmMarcaAnadir f = new frmMarcaAnadir(vBoton);
                    f.pasado += new frmMarcaAnadir.pasar(ejecutar);
                    f.ShowDialog();
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
                    cargarFormularioAnadir();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }

        private void cargarFormularioAnadir()
        {
            if (dgvMarca.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "Mensaje de Sistema", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPerfilAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmMarcaAnadir f = new frmMarcaAnadir(vBoton);
            f.pasado += new frmMarcaAnadir.pasar(ejecutar);
            f.tmpMarca = new marca();
            f.tmpMarca.idmarca = (int)dgvMarca.CurrentRow.Cells[0].Value;
            f.tmpMarca.codigomarca = (string)(dgvMarca.CurrentRow.Cells[1].Value);
            f.tmpMarca.nombremarca = (string)(dgvMarca.CurrentRow.Cells[2].Value);
            f.tmpMarca.estadomarca = (bool)(dgvMarca.CurrentRow.Cells[3].Value);
            f.ShowDialog();
        }
        public void ejecutar(int dato)
        {
            cargarData();
            foreach (DataGridViewRow Row in dgvMarca.Rows)
            {
                int valor = (int)Row.Cells[0].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    dgvMarca.CurrentCell = dgvMarca.Rows[puntero].Cells[1];
                    return;
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            vBoton = "V";
            cargarFormularioAnadir();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
