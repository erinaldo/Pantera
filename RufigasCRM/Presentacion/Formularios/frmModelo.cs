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
    public partial class frmModelo : Form
    {
        private string vBoton = "A";
        public frmModelo()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void frmModelo_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData();
        }
        public void cargarData()
        {
            List<modelo> listado = modeloNE.modeloListar();
            dgvModelo.DataSource = listado;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "A";
                if (basicas.validarAcceso(vBoton))
                {
                    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModeloAnadir);
                    if (frm != null)
                    {
                        frm.BringToFront();
                        return;
                    }
                    frmModeloAnadir f = new frmModeloAnadir(vBoton);
                    f.pasado += new frmModeloAnadir.pasar(ejecutar);
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
            if (dgvModelo.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "Mensaje de Sistema", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModeloAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmModeloAnadir f = new frmModeloAnadir(vBoton);
            f.pasado += new frmModeloAnadir.pasar(ejecutar);
            f.tmpModelo = new modelo();
            f.tmpModelo.idmodelo = (int)dgvModelo.CurrentRow.Cells[0].Value;
            f.tmpModelo.codigomodelo = (string)(dgvModelo.CurrentRow.Cells[1].Value);
            f.tmpModelo.nombremodelo = (string)(dgvModelo.CurrentRow.Cells[2].Value);
            f.tmpModelo.idmarca = (int)(dgvModelo.CurrentRow.Cells[3].Value);
            f.tmpModelo.nombremarca = (string)(dgvModelo.CurrentRow.Cells[4].Value);
            f.tmpModelo.estadomodelo= (bool)(dgvModelo.CurrentRow.Cells[5].Value);
            f.ShowDialog();
        }
        public void ejecutar(int dato)
        {
            cargarData();
            foreach (DataGridViewRow Row in dgvModelo.Rows)
            {
                int valor = (int)Row.Cells[0].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    dgvModelo.CurrentCell = dgvModelo.Rows[puntero].Cells[1];
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
