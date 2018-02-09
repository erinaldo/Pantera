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
    public partial class frmProcSeriesPrincipal : Form
    {
        public frmProcSeriesPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcSeriesAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            string vboton = "A";
            frmProcSeriesAnadir f = new frmProcSeriesAnadir(vboton);
            f.Show();
        }

        private void frmProcSeriesPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0);
        }
        public void cargarData(int registro)
        {
            List<seriebuscada> listado = serieNE.serieListar();
            dgvSeries.DataSource = listado;
        }
        public void ejecutar(int dato)
        {
            cargarData(0);
            foreach (DataGridViewRow Row in dgvSeries.Rows)
            {
                int valor = (int)Row.Cells["IDSERIE"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvSeries.CurrentCell = dgvSeries.Rows[puntero].Cells[1];
                    return;
                }
            }
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
