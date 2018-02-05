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
    public partial class frmManProveedoresPrincipal : Form
    {
        public frmManProveedoresPrincipal()
        {
            InitializeComponent();
        }
        private void frmManProveedoresPrincipal_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0);
        }
        public void cargarData(int registro)
        {
            List<proveedor> listado = proveedorNE.proveedorListar();
            dgvProveedores.DataSource = listado;
        }
        public void ejecutar(int dato)
        {
            cargarData(0);
            foreach (DataGridViewRow Row in dgvProveedores.Rows)
            {
                int valor = (int)Row.Cells["IDPROV"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvProveedores.CurrentCell = dgvProveedores.Rows[puntero].Cells[1];
                    return;
                }
            }
        }
    }
}
