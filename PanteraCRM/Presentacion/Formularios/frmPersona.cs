using Entidades;
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
    public partial class frmPersona : Form
    {
        private string vBoton = "A";
        public frmPersona()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPersonaAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmPersonaAnadir f = new frmPersonaAnadir(vBoton);
                    f.pasado += new frmPersonaAnadir.pasar(ejecutar);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
    private void frmPersona_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData();
        }
        public void cargarData()
        {
            List<persona> listado = personaNE.personaListar();
            dgvPersona.DataSource = listado;
        }
        public void ejecutar(int dato)
        {
            cargarData();
            foreach (DataGridViewRow Row in dgvPersona.Rows)
            {
                int valor = (int)Row.Cells["IDPERSONA"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells[1];
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
                MessageBox.Show(ex.Message.ToString(), "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
            }
        }

        private void cargarFormularioAnadir()
        {
            if (dgvPersona.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPersonaAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmPersonaAnadir f = new frmPersonaAnadir(vBoton);
            f.pasado += new frmPersonaAnadir.pasar(ejecutar);
            f.tmpPersona = new persona();
            f.tmpPersona.idpersona = (int)dgvPersona.CurrentRow.Cells["IDPERSONA"].Value;
            f.tmpPersona.dni = (string)dgvPersona.CurrentRow.Cells["DNI"].Value;
            f.tmpPersona.ape_paterno = (string)(dgvPersona.CurrentRow.Cells["APE_PATERNO"].Value);
            f.tmpPersona.ape_materno = (string)(dgvPersona.CurrentRow.Cells["APE_MATERNO"].Value);
            f.tmpPersona.nombres = (string)(dgvPersona.CurrentRow.Cells["NOMBRES"].Value);
            f.tmpPersona.ubigeo = (string)(dgvPersona.CurrentRow.Cells["UBIGEO"].Value);
            f.tmpPersona.fecha_nac = (string)(dgvPersona.CurrentRow.Cells["FECHA_NAC"].Value);
            f.tmpPersona.sexo = (string)(dgvPersona.CurrentRow.Cells["SEXO"].Value);
            f.tmpPersona.telefono = (string)(dgvPersona.CurrentRow.Cells["TELEFONO"].Value);
            f.tmpPersona.direccion = (string)(dgvPersona.CurrentRow.Cells["DIRECCION"].Value);
            f.ShowDialog();
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