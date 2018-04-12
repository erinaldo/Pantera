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
    public partial class frmManVariosPrincipal : Form
    {
        string vBoton;
        public frmManVariosPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmManVariosPrincipal_Load(object sender, EventArgs e)
        {

            this.Top = (Screen.PrimaryScreen.Bounds.Height - DesktopBounds.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - DesktopBounds.Width) / 2;
            cargarData(0, "");
        }
        public void cargarData(int registro, string parametro)
        {
            if (parametro == "")
            {
                List<maestrocabecera> listado = maestrodetalleNE.MaestroCabeceraListar();
                dgvListaCabecera.DataSource = listado;
            }
            else
            {
                List<maestrocabecera> listado = maestrodetalleNE.MaestroCabeceraListarParametro(parametro);
                dgvListaCabecera.DataSource = listado;
            }

        }
        public void ejecutar(int dato)
        {
            cargarData(0, "");
            foreach (DataGridViewRow Row in dgvListaCabecera.Rows)
            {
                int valor = (int)Row.Cells["IDMAESTRO"].Value;
                if (valor == dato)
                {
                    int puntero = (int)Row.Index;
                    //                    dgvPersona.CurrentCell = dgvPersona.Rows[puntero].Cells["IDPERSONA"];
                    dgvListaCabecera.CurrentCell = dgvListaCabecera.Rows[puntero].Cells[1];
                    return;
                }
            }
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            string parametro = txtParametro.Text;
            cargarData(0,parametro);
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "M";
                if (basicas.validarAcceso(vBoton))
                {
                    CargarVista(vBoton);
                }
                else
                {
                    MessageBox.Show("Error de Acceso", "Mensaje de Sistema", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
        private void CargarVista(string vBoton)
        {
            if (dgvListaCabecera.RowCount == 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "MENSAJE DE SISTEMA", MessageBoxButtons.OK);
                return;
            }
           
            frmManVariosAnadir f = new frmManVariosAnadir(vBoton);
            f.Maestrocodigo = (int)dgvListaCabecera.CurrentRow.Cells["IDMAESTRO"].Value;
            f.pasado += new frmManVariosAnadir.pasar(ejecutar);
            f.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                vBoton = "V";
                if (basicas.validarAcceso(vBoton))
                {
                    CargarVista(vBoton);
                }
                else
                {
                    MessageBox.Show("Error de Acceso", "Mensaje de Sistema", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Mensaje de Sistema", MessageBoxButtons.OK);
            }
        }
    }
}
