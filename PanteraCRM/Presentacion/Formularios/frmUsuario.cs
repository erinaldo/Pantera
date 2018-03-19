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
using Presentacion.Dataset;

namespace Presentacion
{
    public partial class frmUsuario : Form
    {
        private string vBoton = "A";
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData();   
        }
        public void cargarData()
        {
            List<usuario> listado = null;// usuarioNE.usuarioListar();
            dgvUsuario.DataSource = listado;
        }
        private void cmdAnadir_Click(object sender, EventArgs e)
        {
            vBoton = "A";
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmUsuarioAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmUsuarioAnadir f = new frmUsuarioAnadir(vBoton);
            f.pasado += new frmUsuarioAnadir.pasar(ejecutar);
            f.ShowDialog();
        }
        public void ejecutar(int dato) {
            cargarData();
            foreach (DataGridViewRow Row in dgvUsuario.Rows)
            {
                int valor = (int)Row.Cells[0].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    dgvUsuario.CurrentCell = dgvUsuario.Rows[puntero].Cells[1];
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
            if (dgvUsuario.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmUsuarioAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frmUsuarioAnadir f = new frmUsuarioAnadir(vBoton);
            f.pasado += new frmUsuarioAnadir.pasar(ejecutar);
            f.tmpUsuario = new usuario();
            //f.tmpUsuario.idusuario = (int)dgvUsuario.CurrentRow.Cells[0].Value;
            //f.tmpUsuario.nombre = (string)(dgvUsuario.CurrentRow.Cells[1].Value);
            //f.tmpUsuario.login = (string)(dgvUsuario.CurrentRow.Cells[2].Value);
            //f.tmpUsuario.clave = (string)(dgvUsuario.CurrentRow.Cells[3].Value);
            //f.tmpUsuario.estadousuario = (bool)(dgvUsuario.CurrentRow.Cells[4].Value);
            //f.tmpUsuario.idperfil = (int)(dgvUsuario.CurrentRow.Cells[5].Value);
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporte f = new Reportes.FrmReporte();
            CrystalDecisions.CrystalReports.Engine.ReportDocument Rpt1;
            DataSet Dts = new DtsUsuario();
            List<usuario> listado = null;// usuarioNE.usuarioListar();
            foreach (usuario x in listado) {
                Dts.Tables["TUsuario"].LoadDataRow(new object[] { x.p_inidperfil, x.nombre }, true);
                Dts.AcceptChanges();
            }
            Rpt1 = new Reportes.CrpUsuario();
            Rpt1.SetDataSource(Dts);
            f.Rpt = Rpt1;
            f.ShowDialog(this);
        }
    }
}
