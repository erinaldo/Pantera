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
    public partial class frmPerfil : Form
    {
        private string vBoton = "A";
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0);
        }

        public void cargarData(int registro)
        {
            List<perfil> listado = perfilNE.perfilListar();
            dgvPerfil.DataSource = listado;
        }

        private void cmdAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPerfilAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmPerfilAnadir f = new frmPerfilAnadir(vBoton);
                    f.pasado += new frmPerfilAnadir.pasar(ejecutar);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
        public void ejecutar(int dato) {
            cargarData(0);
            foreach (DataGridViewRow Row in dgvPerfil.Rows)
            {
                int valor = (int)Row.Cells[0].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    dgvPerfil.CurrentCell = dgvPerfil.Rows[puntero].Cells[1];
                    return;
                }
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
            if (dgvPerfil.RowCount == 0)
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
            frmPerfilAnadir f = new frmPerfilAnadir(vBoton);
            f.pasado += new frmPerfilAnadir.pasar(ejecutar);
            f.tmpPerfil = new perfil();
            f.tmpPerfil.idperfil = (int)dgvPerfil.CurrentRow.Cells[0].Value;
            f.tmpPerfil.descripcion = (string)(dgvPerfil.CurrentRow.Cells[1].Value);
            f.tmpPerfil.comentarioperfil = (string)(dgvPerfil.CurrentRow.Cells[2].Value);
            f.tmpPerfil.estadoperfil = (bool)(dgvPerfil.CurrentRow.Cells[3].Value);
            f.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            vBoton = "V";
            cargarFormularioAnadir();
        }
    }
}
