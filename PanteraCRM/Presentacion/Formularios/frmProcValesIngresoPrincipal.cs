using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace Presentacion
{
    public partial class frmProcValesIngresoPrincipal : Form
    {
        public frmProcValesIngresoPrincipal()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProcIngresoValesAnadir);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            string vboton = "A";
            frmProcIngresoValesAnadir f = new frmProcIngresoValesAnadir(vboton);
            f.pasado += new frmProcIngresoValesAnadir.pasar(ejecutar);
            f.ShowDialog();
        }
        public void cargarData(int registro)
        {
            List<valecabecera> listado = valeNE.valesListar();
            dgvVales.DataSource = listado;
        }
        public void ejecutar(int dato)
        {
            cargarData(0);
            foreach (DataGridViewRow Row in dgvVales.Rows)
            {
                int valor = (int)Row.Cells["IDVALEC"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvVales.CurrentCell = dgvVales.Rows[puntero].Cells[1];
                    return;
                }
            }
        }

        private void frmProcValesIngresoPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
